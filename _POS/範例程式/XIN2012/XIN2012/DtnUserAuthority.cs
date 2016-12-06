using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Linq;

namespace XIN2012
{
    public partial class fmDtnUserAuthority : XIN2012.fmBase
    {

        XINEntities context = new XINEntities();
        
        public fmDtnUserAuthority()
        {
            InitializeComponent();
        }

        private void fmDtnUserAuthority_Load(object sender, EventArgs e)
        {
            //指定BindingSource物件
            BS = xINUsersBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "EmployeeNo";
            //指定主索引鍵的資料表名稱
            TableName = "XINUsers";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.XINUsers
                     orderby M.EmployeeNo descending
                     select M.EmployeeNo).FirstOrDefault();
            if (NewID != null)
            {
                PrimaryID = NewID;
            }
            else
            {
                PrimaryID = "";
            }
            //移至主索引鍵最大值的記錄
            FillData();
            //不允許新增
            AllowAddNew = false;
        }

        public override void FillData()
        {
            var qry = from M in context.XINUsers
                      where M.EmployeeNo == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            xINUsersBindingSource.DataSource = qry;
        }

        public override bool UpdateData()
        {
            try
            {
                this.Validate();
                //結束編輯
                xINUsersBindingSource.EndEdit();
                PrimaryID = employeeNameTextBox.Text;
                //更新資料
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "更新錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public override void SetControls()
        {
            base.SetControls();
            userAuthorityDataGridView.ReadOnly = (TBStatus == 0);
        }

        public override bool BeforeEdit()
        {
            //系統預設的最高權限使用者不允許修改
            if (employeeNoTextBox.Text == "ADMIN")
            {
                MessageBox.Show("員工代碼ADMIN為系統內建的最高權限使用者，" +
                                "不允許修改它的權限記錄。", "警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        private void userAuthorityDataGridView_RowPrePaint(object sender, 
            DataGridViewRowPrePaintEventArgs e)
        {
            UserAuthority rowAuthority;
            //取得目前的UserAuthority
            rowAuthority = (UserAuthority)userAuthorityBindingSource[e.RowIndex];
            //判斷UserAuthority的導覽屬性Users是否有值
            if (rowAuthority.XINUsers != null)
            {
                //程式名稱
                userAuthorityDataGridView.Rows[e.RowIndex]
                                         .Cells[colProgramName.Index].Value =
                                         rowAuthority.Programs.ProgramName;
            }
        }
    }
}
