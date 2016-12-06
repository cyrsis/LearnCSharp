using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace _04_06_02
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
            if (OepnDlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(OepnDlg.FileName))
                {
                    String TotalLine = "";
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        TotalLine += line;
                    }
                    txtEncryptData.Text = TotalLine;
                }
                txtConnectionString.Text = Decrypt(txtEncryptData.Text);
            }
        }

        String Decrypt(String strToDecrypt)
        {
            //將要解密的字串編碼成Byte
            Byte[] inputByteArray = Convert.FromBase64String(strToDecrypt);
            using (MemoryStream objOutputStream = new MemoryStream())
            {
                //將字串解密
                CryptoStream objCryptoStream = new CryptoStream(objOutputStream,
                        objTripleDES.CreateDecryptor(bytKey, bytIV), 
                        CryptoStreamMode.Write);
                objCryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                objCryptoStream.FlushFinalBlock();
                //將解密過的字串以字串傳回
                return (Encoding.UTF8.GetString(objOutputStream.ToArray()));
            }
        }
    }
}
