using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Linq;
using System.Data.Common;

namespace XIN2012
{
    public partial class fmDtnXINUsers : XIN2012.fmBase
    {
        
        XINEntities context = new XINEntities();
        
        public fmDtnXINUsers()
        {
            InitializeComponent();
        }

        private void fmDtnXINUsers_Load(object sender, EventArgs e)
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
            //是否允許刪除
            AllowDelete = true;
        }

        public override void FillData()
        {
            var qry = from M in context.XINUsers
                      where M.EmployeeNo == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            xINUsersBindingSource.DataSource = qry;
        }

        public override bool BeforeEndEdit()
        {
            bool blnValidation = true;
            if (TBStatus == 1)
            {
                if (employeeNoTextBox.Text == "")
                {
                    MessageBox.Show("員工代碼不可空白！", "錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    employeeNoTextBox.Focus();
                    return false;
                }                
                var qry = context.XINUsers.Execute(MergeOption.OverwriteChanges).Where(U => U.EmployeeNo == employeeNoTextBox.Text).FirstOrDefault();
                                          
                if (qry != null)
                {
                    MessageBox.Show("員工代碼重複！", "錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    employeeNoTextBox.Focus();
                    return false;
                }
            }
            if (employeeNameTextBox.Text == "")
            {
                MessageBox.Show("員工名稱不可空白！", "錯誤", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                employeeNameTextBox.Focus();
                return false;
            }
            if (passwordCodeTextBox.Text == "")
            {
                MessageBox.Show("密碼不可空白！", "錯誤", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                passwordCodeTextBox.Focus();
                return false;
            }
            if (passwordCodeTextBox.Text != ConfirmPasswordCodeTextBox.Text)
            {
                MessageBox.Show("密碼與確認密碼不符，請重新輸入！", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfirmPasswordCodeTextBox.Focus();
                return false;
            }
            return blnValidation;
        }

        public override bool UpdateData()
        {
            try
            {
                this.Validate();
                //結束編輯
                xINUsersBindingSource.EndEdit();
                PrimaryID = employeeNoTextBox.Text;
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
            employeeNoTextBox.ReadOnly = (TBStatus == 0) || (TBStatus == 2);
            employeeNameTextBox.ReadOnly = (TBStatus == 0);
            passwordCodeTextBox.ReadOnly = (TBStatus == 0);
            ConfirmPasswordCodeTextBox.Visible = (TBStatus != 0);
            ConfirmPasswordCodeLabel.Visible = (TBStatus != 0);
        }

        public override void SetDefaultValue()
        {
            passwordCodeTextBox.Text = "";
            ConfirmPasswordCodeTextBox.Text = "";
        }

        public override void AfterAddNew()  
        {
            employeeNoTextBox.Focus();
        }

        public override bool BeforeEdit()
        {
            //系統預設的最高權限使用者不允許修改
            if (employeeNoTextBox.Text == "ADMIN")
            {
                MessageBox.Show("使用者代碼ADMIN為系統預設的最高權限使用者，" +
                                "不允許修改。", "警告", 
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            };
            return true;
        }

        public override void AfterEdit()
        {
            ConfirmPasswordCodeTextBox.Text = passwordCodeTextBox.Text;
        }

        public override bool BeforeDelete()
        {
            if (MessageBox.Show(string.Format("刪除本筆使用者記錄？\r\n\r\n員工代碼：{0}", employeeNoTextBox.Text), "刪除記錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }            
            return base.BeforeDelete();
        }

        public override bool DeleteData()
        {
            try
            {
                //找出目前的使用者記錄的物件
                var rowUsers = (XINUsers)(xINUsersBindingSource.Current);
                if (rowUsers != null)
                {
                    if (! rowUsers.UserAuthority.IsLoaded)
                    {
                        rowUsers.UserAuthority.Load();
                    }
                    //刪除使用者記錄
                    context.DeleteObject(rowUsers);
                    //更新資料
                    context.SaveChanges(); 
                }
       
            }
            catch (Exception ex)
            {
                //秀出錯誤訊息
                MessageBox.Show(ex.Message, "刪除錯誤", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            PrimaryID = employeeNoTextBox.Text;
            return true;            
        }
    }
}
