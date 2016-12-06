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

namespace _10_06_02
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
            LoadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //定義傳回可列舉的物件集合
            ObjectResult<XINUsers> query;
            //取得XINUsers類型的資料
            query = context.XINUsers.Execute(MergeOption.OverwriteChanges);
            //將BindingSource物件繫結至資料來源
            xINUsersBindingSource.DataSource = query;
        }
    }
}
