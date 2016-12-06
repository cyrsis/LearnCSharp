using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_06_01
{
    public partial class Form1 : Form
    {
        int iState;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'xINDataSet.XINUsers' 資料表。
            //您可以視需要進行移動或移除。
            this.taXINUsers.Fill(this.xINDataSet.XINUsers);
            iState = 0;
            ChangeControlReadOnly();
        }

        private void SaveData()
        {
            bsXINUsers.EndEdit();
            if (iState == 1)
            {
                //新增記錄
                //使用TableAdapter物件的Insert方法來新增記錄
                taXINUsers.Insert(employeeNoTextBox.Text,
                                  employeeNameTextBox.Text,
                                  passwordCodeTextBox.Text);
            }
            else
            {
                //修改記錄
                DataRow rowEmployee;
                //取得修改的記錄指標
                rowEmployee = xINDataSet.Tables["XINUsers"].Rows[bsXINUsers.Position];
                //使用TableAdapter物件的Update方法來修改記錄
                taXINUsers.Update(employeeNoTextBox.Text, 
                                  employeeNameTextBox.Text,
                                  passwordCodeTextBox.Text,
                                  employeeNoTextBox.Text);
            }
        }

        private void DeleteData()
        {
            DataRow rowEmployee;
            //取得刪除的記錄指標
            rowEmployee = xINDataSet.Tables["XINUsers"].Rows[bsXINUsers.Position];
            //使用TableAdapter物件的Delete方法來刪除記錄
            taXINUsers.Delete(employeeNoTextBox.Text);
            bsXINUsers.RemoveAt(bsXINUsers.Position);
        }

        private void ChangeControlReadOnly()
        {
            employeeNoTextBox.ReadOnly = (iState != 1);
            employeeNameTextBox.ReadOnly = (iState == 0);
            passwordCodeTextBox.ReadOnly = (iState == 0);
            btnAddNew.Enabled = (iState == 0);
            btnModify.Enabled = (iState == 0);
            btnDelete.Enabled = (iState == 0);
            btnSave.Enabled = (iState != 0);
            btnCancel.Enabled = (iState != 0);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            iState = 1;
            //新增一筆空白記錄
            bsXINUsers.AddNew();
            //改變控制項的唯讀屬性
            ChangeControlReadOnly();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            iState = 2;
            ChangeControlReadOnly();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            iState = 0;
            ChangeControlReadOnly();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsXINUsers.CancelEdit();
            iState = 0;
            ChangeControlReadOnly();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            iState = 0;
            ChangeControlReadOnly();
        }
    }
}
