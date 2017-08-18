using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using meanreversion;


//guts from quantlabs.net/private/2013/10/07/london-quant-improved-working-model-of-iqfeed-to-interactive-brokers-tws-market-order-submission/

namespace IBMeanRevWinForm
{
    public partial class Form1 : Form
    {
        //NOTE: ensure this Visual Studio project is in correct debug/release mode and correct bit version matches the DLL
 
        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int BuyMarket(string sym, int qty);

        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SellMarket(string sym, int qty);


        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int InitReqMktData(ref int uid, string  sym, string secType, string currency, string exch);

        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WaitForEvent(int msec);

        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Disconnect();

        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetEventValI(int uid_event, int par);

        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetEventValD(int uid_event, int par);

        [DllImport(@"C:\Users\i7-acer\Documents\Visual Studio 2012\Projects\twslink2\TWSLink2DLL\TWSLink2DLL update\x64\Release\TWSLink2DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqMktData(int uid);

        int msgCounter = 0;
        int uid_event = 0;
        Queue<Tick> ticks = new Queue<Tick>();

        int ROLL_WINDOW_SZ = 50; //should be the same as pd in Matlab function 
        Timer timer = new Timer();
        string sym  = "AAPL";


        public Form1()
        {

            InitializeComponent();

            int msgCounter = 0; 
            int uid = 0;
            int reqMktData = InitReqMktData(ref uid, sym, "STK", "USD", "ISLAND");

            timer.Tick += new EventHandler(ReceiveTimerTick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (1);              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start();  

        }

        
        void ReceiveTimerTick(object sender, EventArgs e)
        {
            BeginInvoke((Action) delegate
                {

                     /// wait at the most 50 milliseconds for next event
                    uid_event = WaitForEvent(20); 

                    /// there is an event in the meantime
                    if (uid_event > 0)
                    /// and this event category is a real data event (in other events we are not interested at this point)
                    //&& twslink.GET_EVENT_VAL_I(uid_event,1) == __realtime_data_event_id)
                    {
                        /// type of tick
                        int ticktype = GetEventValI(uid_event, 3);
                        /// price value,if there was a price tick
                        int price =  GetEventValD(uid_event, 5);
                        /// size value, if tick was size tick
                        int size = GetEventValI(uid_event, 15);
                        //Console.WriteLine("\t\t: {0}  \t: price {1}  size=", uid,price, size);
                        string msg = "price= " + price +" size= " + size + " counter=" + msgCounter++;
                        richTextBox1.AppendText(msg + Environment.NewLine);
                        Tick t = new Tick();
                        t.Price = price;
                        t.Size = size;

                        ticks.Enqueue(t);


                        
                        if (ticks.Count >= ROLL_WINDOW_SZ + 1) //0 based
                        {
                            ticks.Dequeue();
                        }

                        try
                        {
                            if (msgCounter > ROLL_WINDOW_SZ + 1) //should be a large size to run Matlab calculations
                            {
                                MeanReversion mr = new MeanReversion();

                                //convert to an array of integers types for the Matlab function 
                                double[] tiks = new double[ticks.Count];
                                int i = 0;
                                Random random = new Random();
                                double minimum = 175.0;
                                double maximum = 180.0;

                                foreach (Tick tik in ticks)
                                {
                                    //tiks[i] = tik.Price;

                                    //fudge tick price sent oMatlab function due to crappy price from IB demo TWS 
                                    tiks[i] = random.NextDouble() * (maximum - minimum) + minimum;
                                    ++i;
                                }


                                //MATLAB signature definition function [revRate,meanLevel,vol] = meanreversion(S)
                                MWArray[] Results = (MWArray[])mr.meanreversion(3, (MWNumericArray)tiks); //3 represents number of out arguments

                                double[,] longsEntry = (double[,])Results[0].ToArray();
                                double[,] longExit = (double[,])Results[1].ToArray();
                                double[,] shortEntry = (double[,])Results[2].ToArray();
                                double[,] shortExit = (double[,])Results[3].ToArray();

                                string stats = "stats rev= " + revRate[0, 0] + " meanLevel= " + meanLevel[0, 0] + " vol=" + vol[0, 0];
                                richTextBox1.AppendText(stats + Environment.NewLine);

                                if (price < meanLevel[0, 0]) // && meanLevel[0, 0]!="NaN")
                                {
                                    richTextBox1.AppendText("Buy 1" + Environment.NewLine);
                                    BuyMarket(sym, 1);
                                }
                                else if (price > meanLevel[0, 0]) // && meanLevel[0, 0]!="NaN")
                                {
                                    richTextBox1.AppendText("Sell 1" + Environment.NewLine);
                                    SellMarket(sym, 1);
                                }
                            }
                        }
                        catch(Exception exception)
                        {
                            string exc = "Error: " + exception;
                            richTextBox1.AppendText(exc + Environment.NewLine);
                        }


                    }

                    
                });
        }



        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
