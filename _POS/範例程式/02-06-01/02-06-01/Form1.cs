using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立資料表
            DataTable dtDetails = new DataTable();
            //建立Primary Key欄位陣列
            DataColumn[] dtlsPrimaryKey = new DataColumn[2];
            //加入欄位到資料表
            dtDetails.Columns.Add("DeliveryID", typeof(String));
            dtDetails.Columns.Add("ProductID", typeof(String));
            //設定Primary Key欄位陣列
            dtlsPrimaryKey[0] = dtDetails.Columns["DeliveryID"];
            dtlsPrimaryKey[1] = dtDetails.Columns["ProductID"];
            //設定資料表的PrimaryKey屬性
            dtDetails.PrimaryKey = dtlsPrimaryKey;
            //顯示欄位的AllowDBNull屬性與Unique屬性的值
            listBox1.Items.Add(dtDetails.Columns["DeliveryID"].ColumnName +
                               "的AllowDBNull屬性: " +
                               dtDetails.Columns["DeliveryID"].AllowDBNull);
            listBox1.Items.Add(dtDetails.Columns["DeliveryID"].ColumnName + 
                               "的Unique屬性: " +
                               dtDetails.Columns["DeliveryID"].Unique);
            listBox1.Items.Add(dtDetails.Columns["ProductID"].ColumnName + 
                               "的AllowDBNull屬性: " +
                               dtDetails.Columns["ProductID"].AllowDBNull);
            listBox1.Items.Add(dtDetails.Columns["ProductID"].ColumnName + 
                               "的Unique屬性: " +
                               dtDetails.Columns["ProductID"].Unique);
            //找出資料表的條件約束
            foreach (Constraint dtConstraint in dtDetails.Constraints)
            {
                listBox1.Items.Add("條件約束:" + dtConstraint.ConstraintName);
            }
        }
    }
}
