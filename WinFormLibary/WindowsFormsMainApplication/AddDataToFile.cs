using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class AddDataToFile : Form
    {
        public AddDataToFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文字檔案(*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("請設定檔案");
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("請輸入要寫入的檔案內容");
                return;
            }

            try
            {
                StreamWriter SWriter = new StreamWriter(textBox1.Text);
                SWriter.Write(textBox2.Text);
                SWriter.Close();
                MessageBox.Show("寫入檔案成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
