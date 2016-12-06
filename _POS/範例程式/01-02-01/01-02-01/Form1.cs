using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_02_01
{
    public partial class Form1 : Form
    {

        int INum1;
        int INum2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            try
            {
                INum1 = 10 / INum2; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            try
            {
                INum1 = 10 / INum2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, "Source");
            }
        }

        private void btnToString_Click(object sender, EventArgs e)
        {
            try
            {
                INum1 = 10 / INum2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ToString()");
            }
        }

        private void btnAllErrors_Click(object sender, EventArgs e)
        {
            try
            {
                INum1 = 10 / INum2;
            }
            catch
            {
                MessageBox.Show("錯誤。", "All Errors");
            }
        }

        private void btnNullReferenceException_Click(object sender, EventArgs e)
        {
            try
            {
                INum1 = 10/INum2;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString(), "NullReferenceException");
            }
            finally
            {
                MessageBox.Show("Finally is happen in here");
            }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                Exception MyError = new Exception("TextBox控制項不可空白");
                MyError.Source = "HaveValue";
                if (textBox1.Text.Length == 0)
                {
                    throw MyError;
                }
                INum1 = 10 / INum2;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤。" + "\r\n" +
                                ex.Message + "\r\n" +
                                ex.Source + "\r\n", "Users");
            }
        }
    }
}
