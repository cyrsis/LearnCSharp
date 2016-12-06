using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;

namespace _10_08_01
{
    public partial class Form1 : Form
    {

        XINEntities context;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new XINEntities();
            //將BindingSource物件繫結至資料來源
            customerBindingSource.DataSource = 
                         context.Customer.Execute(MergeOption.OverwriteChanges);
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //結束編輯
            customerBindingSource.EndEdit();
            //將異動更新回資料庫
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
