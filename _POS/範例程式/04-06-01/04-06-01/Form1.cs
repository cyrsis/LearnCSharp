using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace _04_06_01
{
    public partial class Form1 : Form
    {

        Byte[] bytKey = new Byte[24];
        Byte[] bytIV = new Byte[24];
        TripleDESCryptoServiceProvider objTripleDES;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定義Key
            bytKey = System.Text.Encoding.UTF8.GetBytes(
                                    "1234567890123456789~1234");
            //定義IV
            bytIV = System.Text.Encoding.UTF8.GetBytes("1234~678");
            //建立TripleDESCryptoServiceProvider類別
            objTripleDES = new TripleDESCryptoServiceProvider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //加密
            txtEncryptData.Text = Encrypt(txtConnectionString.Text);
            //將加密後的文字儲存成文字檔
            using (StreamWriter sw = new StreamWriter("ConnectionString.txt"))
            {
                sw.Write(txtEncryptData.Text);
            }
        }

        string Encrypt(String strToEncrypt)
        {
            //將要加密的字串編碼成Byte
            Byte[] bytInput = Encoding.UTF8.GetBytes(strToEncrypt);

            using (MemoryStream objOutputStream = new MemoryStream())
            {
                //將字串加密
                CryptoStream objCryptoStream = new CryptoStream(objOutputStream,
                        objTripleDES.CreateEncryptor(bytKey, bytIV),
                        CryptoStreamMode.Write);
                objCryptoStream.Write(bytInput, 0, bytInput.Length);
                objCryptoStream.FlushFinalBlock();
                //將加密過的字串以字串傳回
                return (Convert.ToBase64String(objOutputStream.ToArray()));
            }
        }
    }
}
