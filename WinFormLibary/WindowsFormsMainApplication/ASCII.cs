using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class ASCII : Form
    {
        public ASCII()
        {
            InitializeComponent();
        }

        private void btn_ToASCII_Click(object sender, EventArgs e)
        {
            if (txt_char.Text != string.Empty)//�P�_��J�O�_����
            {
                if (Encoding.GetEncoding("unicode").//�P�_��J�O�_���r��
                    GetBytes(new char[] { txt_char.Text[0] })[1] == 0)
                {
                    txt_ASCII.Text = Encoding.GetEncoding(//�o��r�Ū�ASCII�X��
                        "unicode").GetBytes(txt_char.Text)[0].ToString();
                }
                else
                {
                    txt_ASCII.Text = string.Empty;//��X�Ŧr��
                    MessageBox.Show("�п�J�r���I", "���ܡI");//���ܥΤ�T��
                }
            }
        }
        private void btn_ToChar_Click(object sender, EventArgs e)
        {
            if (txt_ASCII2.Text != string.Empty)//�P�_��J�O�_����
            {
                int P_int_Num;//�w�q�㫬�����ܼ�
                if (int.TryParse(//�N��J���r���ഫ���Ʀr
                    txt_ASCII2.Text, out P_int_Num))
                {
                    txt_Char2.Text =
                        ((char)P_int_Num).ToString();//�NASCII�X�ഫ���r��
                }
                else
                {
                    MessageBox.Show(//�p�G��J���ŦX�n�D�u�X���ܮ�
                        "�п�J���TASCII�X�ȡC", "���~�I");
                }
            }
            string P_str_temp = "abc";
            string P_str = Encoding.GetEncoding("unicode").GetBytes(new char[] { P_str_temp[0] })[0].ToString();
        }
    }
}
