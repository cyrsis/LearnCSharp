using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckID_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (mtbID.Text !="")
            {
                bool Result = CheckID(mtbID.Text);
                if (Result)
                {
                    MessageBox.Show(mtbID.Text, "身份證字號正確");
                }
                else
                {
                    MessageBox.Show(mtbID.Text, "身份證字號錯誤");
                }
            }
        }

        private bool CheckID(string ID)
        {
            bool checkResult = false;
            if (ID.Length == 10) //檢查身分證字號長度
            {
                ID = ID.ToUpper();
                if (ID[0] >= 0x41 && ID[0] <= 0x5A) //檢查第一個字元是否為英文字母字母(A~Z)
                {
                    if (ID[1] != '1' && ID[1] != '2') //檢查第一個數字是否為1或2，1代表男生,2代表女生
                    {
                        return checkResult;
                    }
                    int[] n = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 34, 
                        18, 19, 20, 21, 22, 35, 23, 24, 25, 26, 27, 28, 29, 32, 30, 31, 33 };
                    int[] m = new int[11]; //因為第一個字母會拆分為二個數字，故須2+9 = 11空間來存放
                    m[1] = n[(ID[0]) - 65] % 10;               //拆解第一個字母如A = 10 , b[0] = 1 , b[1]=0 
                    int total = m[0] = n[(ID[0]) - 65] / 10; 
                    for (int i = 1; i <= 9; i++)
                    {
                        m[i + 1] = ID[i] - 48;
                        total += m[i] * (10 - i);
                    }
                    if (((total % 10) + m[10]) % 10 == 0) //總計之後取餘數等於0表示身分證正確
                    {
                        checkResult = true;
                    }
                }
            }
            return checkResult;
        }

    }
}
