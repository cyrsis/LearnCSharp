using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class CalcRAreaByAbstractClass : Form
    {
        public CalcRAreaByAbstractClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcArea calcArea = new CalcArea();//��Ҥƭl����
            Roll roll = calcArea;//�ϥέl���������ҤƩ⹳��
            string strNum = textBox1.Text.Trim();//�O��TextBox��r�ؤ������e
            if (strNum != "")//�P�_�O�_��J�F��b�|
            {
                try
                {
                    roll.R = int.Parse(strNum);//�ϥΩ⹳������X�ݩ⹳�������b�|�ݩ�
                    textBox2.Text = roll.Area().ToString();//�I�s�۩w�q��k�i��D�ꭱ�n
                }
                catch
                {
                    MessageBox.Show("�п�J���T����b�|�I");
                }
            }
        }
    }
    public abstract class Roll
    {
        private int r = 0;
        /// <summary>
        /// ��b�|
        /// </summary>
        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
        /// <summary>
        /// �⹳��k�A�Ψӭp��ꭱ�n
        /// </summary>
        public abstract double Area();
    }
    public class CalcArea : Roll//�~�ө⹳��
    {
        /// <summary>
        /// ���g�⹳�����p��ꭱ�n����k
        /// </summary>
        public override double Area()
        {
            return Math.PI * R * R;
        }
    }
}
