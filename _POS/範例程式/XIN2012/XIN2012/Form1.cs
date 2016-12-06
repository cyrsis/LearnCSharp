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
using System.Data.Common;

namespace XIN2012
{
    public partial class fmForm1 : Form
    {
        XINEntities context = new XINEntities();        

        public fmForm1()
        {
            InitializeComponent();
        }

        private void transferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            transferBindingSource.EndEdit();
            context.SaveChanges();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var qry = from M in context.Transfer
                       select M;
            //           context.Refresh(RefreshMode.StoreWins, context.Receipt.First(R => R.ReceiptID == PrimaryID));
            //將BindingSource物件繫結至資料來源
            transferBindingSource.DataSource = qry;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //EntityState.Added
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Added))
            {
                string NewEmplNo, NewEmplName;
                NewEmplNo = ((Transfer)(entry.Entity)).TransferID;
                NewEmplName = ((Transfer)(entry.Entity)).Description;
                listBox1.Items.Add(String.Format(
                                   "員工代碼{0}為Added，目前的員工名稱：{1} ",
                                   NewEmplNo, NewEmplName));
            }

            //EntityState.Modified
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Modified))
            {
                string NewEmplName, OldEmplName, OrginalEmplNo;
                //取得員工名稱目前值
                CurrentValueRecord curr = entry.CurrentValues;
                NewEmplName = (string)(curr.GetValue(curr.GetOrdinal("Description")));
                //取得員工名稱原來值
                OriginalValueRecord org = entry.GetUpdatableOriginalValues();
                OldEmplName = (string)(org.GetValue(org.GetOrdinal("Description")));
                OrginalEmplNo = ((Transfer)(entry.Entity)).TransferID;
                listBox1.Items.Add(String.Format("員工代碼{0}為Modified， " +
                                   "目前的員工名稱：{1}，原來的員工名稱：{2} ",
                                   OrginalEmplNo, NewEmplName, OldEmplName));
            }

            //EntityState.Deleted
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Deleted))
            {
                string OldEmplNo, OldEmplName;
                OldEmplNo = ((Transfer)(entry.Entity)).TransferID;
                OldEmplName = ((Transfer)(entry.Entity)).Description;
                listBox1.Items.Add(String.Format("員工代碼{0}為Deleted， " +
                                   "原來的員工名稱：{1} ", OldEmplNo, OldEmplName));
            }

            //EntityState.Unchanged
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Unchanged))
            {
                string currEmplNo, currEmplName;
                currEmplNo = ((Transfer)(entry.Entity)).TransferID;
                currEmplName = ((Transfer)(entry.Entity)).Description;
                listBox1.Items.Add(String.Format("員工代碼{0}為Unchanged， " +
                                   "目前的員工名稱：{1} ", currEmplNo, currEmplName));
            }
        }
    }
}
