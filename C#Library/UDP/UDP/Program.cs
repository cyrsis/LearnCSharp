using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = "192.168.100.134";
            int port = 7474;
            UdpClient server;
            ASCIIEncoding byteEncoder = new ASCIIEncoding();

            Encoding ASCIIEncoding8Bit = Encoding.GetEncoding(1252);

            Send(hostName, port);

            server = new UdpClient(hostName, port);

            server.Connect(hostName, port);

            string message = "Bar Samples 99827.88";


            string[] str = message.Split(',');
            ArrayList al=new ArrayList();
            al.AddRange(str);
             //byte[] messageBytes = ASCIIEncoding8Bit.GetBytes(message);

           
            padNull(al);

            

            server.Send(al, message.Length);
            Console.WriteLine("I have send!!");
            Console.ReadLine();

        }

        protected static void padNull(ArrayList data)
        {
            byte zero = 0;
            int pad = 4 - (data.Count % 4);
            for (int i = 0; i < pad; i++)
            {
                data.Add(zero);
            }
        }

        internal static byte[] swapEndian(byte[] data)
        {
            byte[] swapped = new byte[data.Length];
            for (int i = data.Length - 1, j = 0; i >= 0; i--, j++)
            {
                swapped[j] = data[i];
            }
            return swapped;
        }

        private static void Send(string hostName, int port)
        {
            //server = new UdpClient(hostName, port);

            //server.Connect(hostName, port);

            // TEST //
            //SendFloat("RouteArg0", Random.value);
        }

        // Sends an Int value to Max //
        public void SendInt(string maxRouteArgument, int val)
        {
            //string message = maxRouteArgument + " " + val;
            //byte[] messageBytes = byteEncoder.GetBytes(message);
            //SendBytes(messageBytes);
        }

        // Sends an Float value to Max //
        public void SendFloat(string maxRouteArgument, float val)
        {
        //    string message = maxRouteArgument + " " + val;
        //    byte[] messageBytes = byteEncoder.GetBytes(message);
        //    SendBytes(messageBytes);
        }


        private void SendBytes(byte[] message)
        {
            //    try
            //    {
            //        server.Send(message, message.Length);
            //    }
            //    catch (SocketException e)
            //    {
            //        Debug.LogError(e);
            //    }
            //}
        }

    }
}
