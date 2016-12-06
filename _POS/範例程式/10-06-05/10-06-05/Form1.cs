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

namespace _10_06_05
{
    public partial class Form1 : Form
    {

        XINEntities context;
        string strEmplNo;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new XINEntities();
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //定義傳回可列舉的物件集合
            ObjectResult<XINUsers> query;
            //取得XINUsers類型的資料
            if (radioAppendOnly.Checked)
            {
                //合併選項:AppendOnly
                query = context.XINUsers.Execute(MergeOption.AppendOnly);
            }
            else if (radioOverwriteChanges.Checked)
            {
                //合併選項:OverwriteChanges
                query = context.XINUsers.Execute(MergeOption.OverwriteChanges);
            }
            else if (radioPreserveChanges.Checked)
            {
                //合併選項:PreserveChanges
                query = context.XINUsers.Execute(MergeOption.PreserveChanges);
            }
            else
            {
                //合併選項:NoTracking
                query = context.XINUsers.Execute(MergeOption.NoTracking);
            }
            //將BindingSource物件繫結至資料來源
            xINUsersBindingSource.DataSource = query;
        }

        private void xINUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            xINUsersBindingSource.EndEdit();
            context.SaveChanges();
        }

        private void xINUsersDataGridView_CellEnter(object sender, 
            DataGridViewCellEventArgs e)
        {
            var ID = xINUsersDataGridView.Rows[e.RowIndex]
                                         .Cells["colEmployeeNo"].Value;
            if (ID == null)
            {
                strEmplNo = "";
            }
            else
            {
                strEmplNo = (string)ID;
            }
        }

        private void btnEntityState_Click(object sender, EventArgs e)
        {
            if (strEmplNo.Trim() == "")
            {
                return;
            }
            //取得目前的XINUsers物件
            var EmplNo = (from X in context.XINUsers
                          where X.EmployeeNo == strEmplNo
                          select X).FirstOrDefault();
            if (EmplNo == null)
            {
                textBox1.Text = "  -  ";
            }
            else
            {
                //取得目前的XINUsers物件的ObjectStateEntry
                ObjectStateEntry OSE = context.ObjectStateManager
                                                     .GetObjectStateEntry(EmplNo);
                if ((OSE.State == EntityState.Detached) ||
                    (OSE.State == EntityState.Deleted))
                {
                    textBox1.Text = "員工代碼：" + strEmplNo + "\r\n" +
                                    "EntryState：" + OSE.State.ToString();
                }
                else 
                {
                    string OldNo, NewNo;
                    //取得員工名稱目前值
                    CurrentValueRecord cur = OSE.CurrentValues;
                    OldNo = (string)(cur.GetValue(cur.GetOrdinal("EmployeeName")));
                    //取得員工名稱原來值
                    OriginalValueRecord org = OSE.GetUpdatableOriginalValues();
                    NewNo = (string)(org.GetValue(cur.GetOrdinal("EmployeeName")));
                    textBox1.Text = "員工代碼：" + strEmplNo + "\r\n" +
                                    "EntryState：" + OSE.State.ToString() + "\r\n" +
                                    "員工名稱目前值為：" + OldNo + "\r\n" +
                                    "員工名稱原來值為：" + NewNo;
                }
            }
        }
    }
}
