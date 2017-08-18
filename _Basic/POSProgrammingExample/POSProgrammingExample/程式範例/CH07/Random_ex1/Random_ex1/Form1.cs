using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimulation_Click(object sender, EventArgs e)
        {
            string msg = "";
            string[] Lotterys = BigLottery();
            foreach (string num in Lotterys)
            {
                msg = msg + num + ",";
            }
            msg = msg.Substring(0,msg.LastIndexOf(",")); //去除最後一個逗號

            MessageBox.Show(msg,"本期樂透開獎");
        }

        private string[] BigLottery()
        {
            string[] result = new string[7];
            int[] d = new int[50];
            int n = 0;
            int RanValue;
            bool flag;

            n = 0;     //n代表已經開獎號碼個數
            do {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());//DateTime.Now.Millisecond
                RanValue = (int)rnd.Next(1, 49);
                if (n==0)
                {
                    result[n] = string.Format("{0:D2}",RanValue);
                    n = n + 1;
                }
                else
                {
                    flag = false;
                    foreach(var obj in result)
                    {
                        if (obj != null)
                        {
                            if (int.Parse(obj) == RanValue)
                            {
                                flag = true;
                            }
                        }
                       
                    }

                    if (flag==false)
                    {
                        result[n] = string.Format("{0:D2}", RanValue);
                        n = n + 1;
                    }
                }

            } while (!(n == 7));

            return result;
        }

    }
}
