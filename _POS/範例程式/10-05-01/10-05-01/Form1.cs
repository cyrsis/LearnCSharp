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
using System.Collections;

namespace _10_05_01
{
    public partial class Form1 : Form
    {

        XINEntities context = new XINEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定義傳回可列舉的物件集合
            ObjectResult<Programs> qryPrograms;
            //取得Programs類型的資料
            qryPrograms = context.Programs.Execute(MergeOption.OverwriteChanges);
            //將BindingSource物件繫結至資料來源
            programsBindingSource.DataSource = qryPrograms;
        }

        private void programsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //結束編輯
            programsBindingSource.EndEdit();
            //
            if (programIDTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入程式代碼。", "錯誤", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (programNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入程式名稱。", "錯誤", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //檢查是否有重複輸入資料
            Hashtable ht = new Hashtable();
            DataGridView Grid = userAuthorityDataGridView;
            try
            {
                for (int I = 0; I <= Grid.Rows.Count - 2; I++)
            {
                ht.Add((Grid.Rows[I].Cells["EmplNo"].EditedFormattedValue), I);
            }
            }
            catch
            {
                MessageBox.Show("使用者代碼重覆輸入。", "錯誤", 
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //更新資料
            context.SaveChanges();
        }

        private void userAuthorityDataGridView_RowPrePaint(object sender, 
            DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView Grid = userAuthorityDataGridView;
            if ((Grid.Rows.Count - 2) >= e.RowIndex)
            {
                UserAuthority rowDetails;
                //取得目前的UserAuthority
                rowDetails = (UserAuthority)(userAuthorityBindingSource[e.RowIndex]);
                //判斷UserAuthority的導覽屬性XINUsers是否有值
                if (rowDetails.XINUsers != null)
                {
                    //員工姓名
                    Grid.Rows[e.RowIndex].Cells[EmplName.Index].Value = 
                        rowDetails.XINUsers.EmployeeName;
                }
            }
        }

        private void userAuthorityDataGridView_CellValidated(object sender, 
            DataGridViewCellEventArgs e)
        {

        }

        private void userAuthorityDataGridView_CellValueChanged(object sender, 
            DataGridViewCellEventArgs e)
        {
            //如果不是員工編號，就離開
            if (e.ColumnIndex != 0)
            {
                return;
            }
            DataGridView Grid = userAuthorityDataGridView;
            if ((Grid.Rows.Count - 2) >= e.RowIndex)
            {
                string EmployeeNo;
                EmployeeNo = (string)(Grid.Rows[e.RowIndex].Cells["EmplNo"].Value);
                //取得員工姓名
                string sSQL = "SELECT VALUE XINUsers " +
                               "FROM XINEntities.XINUsers AS XINUsers " +
                               "WHERE XINUsers.EmployeeNo = @EmployeeNo ";
                var qry = new ObjectQuery<XINUsers>(sSQL, context);
                qry.Parameters.Add(new ObjectParameter("EmployeeNo", EmployeeNo));
                XINUsers M = qry.FirstOrDefault();
                //判斷是否有值
                if (M != null)
                {
                    Grid.Rows[e.RowIndex].Cells[EmplName.Index].Value = M.EmployeeName;
                }
            }
        }
    }
}
