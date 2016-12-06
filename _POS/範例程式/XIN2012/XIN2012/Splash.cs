using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace XIN2012
{
    public partial class fmSplash : Form
    {
        public fmSplash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmSplash_Load(object sender, EventArgs e)
        {
            ApplicationTitle.Text = "";
            Company.Text = "";
            object[] attributes;
            //應用程式標題             
            attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(
                                 typeof(AssemblyProductAttribute), false);
           if (attributes.Length != 0)
           {
               ApplicationTitle.Text = ((AssemblyProductAttribute)attributes[0]).Product; 
           }           
           //版本
           Version.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
           //公司
           attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(
                                 typeof(AssemblyCompanyAttribute), false);
           if (attributes.Length != 0)
           {
               Company.Text = ((AssemblyCompanyAttribute)attributes[0]).Company;
           }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Type myType;
                    myType = this.GetType();

            Type at = typeof(AssemblyCopyrightAttribute);

            object[] r = myType.Assembly.GetCustomAttributes(at, false);

            AssemblyCopyrightAttribute ct =
            (AssemblyCopyrightAttribute)(r[0]);

            MessageBox.Show(ct.Copyright);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] oo = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), true);
            if (oo != null && oo.Length > 0)
            {
                AssemblyProductAttribute productAttribute = (AssemblyProductAttribute)oo[0];
                Console.WriteLine(productAttribute.Product);
            }

            Assembly thisAsm = this.GetType().Assembly;

            object[] attrs = thisAsm.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

            string test1 = ((AssemblyTitleAttribute)attrs[0]).Title;

            object[] attrs1 = thisAsm.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);

            string test2 = ((AssemblyCompanyAttribute)attrs1[0]).Company;

            Console.WriteLine(test1 + test2);

        }
    }
}

