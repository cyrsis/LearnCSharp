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

namespace _10_07_01
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
            xINUsersBindingSource.DataSource =
                         context.XINUsers.Execute(MergeOption.OverwriteChanges);
        }

        private void xINUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //結束編輯
            xINUsersBindingSource.EndEdit();
            //將異動更新回資料庫
            context.SaveChanges();
        }
    }
}
