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

namespace _10_06_06
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
        }

        private void xINUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            xINUsersBindingSource.EndEdit();
            context.SaveChanges();
        }

        private void btnAppendOnly_Click(object sender, EventArgs e)
        {
            xINUsersBindingSource.DataSource = context.XINUsers.Execute(MergeOption.AppendOnly);
        }

        private void btnAcceptChanges_Click(object sender, EventArgs e)
        {
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Modified))
            {
                entry.AcceptChanges();
            }
        }

        private void btnEntityState_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            //EntityState.Added
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Added))
            {
                string NewEmplNo, NewEmplName;
                NewEmplNo = ((XINUsers)(entry.Entity)).EmployeeNo;
                NewEmplName = ((XINUsers)(entry.Entity)).EmployeeName;
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
                NewEmplName = (string)(curr.GetValue(curr.GetOrdinal("EmployeeName")));
                //取得員工名稱原來值
                OriginalValueRecord org = entry.GetUpdatableOriginalValues();
                OldEmplName = (string)(org.GetValue(org.GetOrdinal("EmployeeName")));
                OrginalEmplNo = ((XINUsers)(entry.Entity)).EmployeeNo;
                listBox1.Items.Add(String.Format("員工代碼{0}為Modified， " +
                                   "目前的員工名稱：{1}，原來的員工名稱：{2} ", 
                                   OrginalEmplNo, NewEmplName, OldEmplName));
            }

            //EntityState.Deleted
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Deleted))
            {
                string OldEmplNo, OldEmplName;
                OldEmplNo = ((XINUsers)(entry.Entity)).EmployeeNo;
                OldEmplName = ((XINUsers)(entry.Entity)).EmployeeName;
                listBox1.Items.Add(String.Format("員工代碼{0}為Deleted， " +
                                   "原來的員工名稱：{1} ", 
                                   OldEmplNo, OldEmplName));
            }

            //EntityState.Unchanged
            foreach (var entry in context.ObjectStateManager
                                         .GetObjectStateEntries(EntityState.Unchanged))
            {
                string currEmplNo, currEmplName;
                currEmplNo = ((XINUsers)(entry.Entity)).EmployeeNo;
                currEmplName = ((XINUsers)(entry.Entity)).EmployeeName;
                listBox1.Items.Add(String.Format("員工代碼{0}為Unchanged， " +
                                   "目前的員工名稱：{1} ", 
                                   currEmplNo, currEmplName));
            }
        }
    }
}
