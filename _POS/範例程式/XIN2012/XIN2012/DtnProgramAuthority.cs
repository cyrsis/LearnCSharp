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
    public partial class fmDtnProgramAuthority : XIN2012.fmBase
    {

        XINEntities context = new XINEntities();
        
        public fmDtnProgramAuthority()
        {
            InitializeComponent();
        }

        private void DtnProgramAuthority_Load(object sender, EventArgs e)
        {
            //指定BindingSource物件
            BS = programsBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "ProgramID";
            //指定主索引鍵的資料表名稱
            TableName = "Programs";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.Programs
                     orderby M.ProgramID descending
                     select M.ProgramID).FirstOrDefault();
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
            var qry = from M in context.Programs
                      where M.ProgramID == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            programsBindingSource.DataSource = qry;
        }

        public override bool UpdateData()
        {
            try
            {
                this.Validate();
                //結束編輯
                programsBindingSource.EndEdit();
                PrimaryID = programIDTextBox.Text;
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

        private void userAuthorityDataGridView_RowPrePaint(object sender, 
            DataGridViewRowPrePaintEventArgs e)
        {
            UserAuthority rowAuthority;
            //取得目前的UserAuthority
            rowAuthority = (UserAuthority)userAuthorityBindingSource[e.RowIndex];
            //判斷UserAuthority的導覽屬性Users是否有值
            if (rowAuthority.XINUsers != null)
            {
                //員工名稱
                userAuthorityDataGridView.Rows[e.RowIndex]
                                         .Cells[colEmployeeName.Index].Value =
                                         rowAuthority.XINUsers.EmployeeName;
            }
        }
    }
}
