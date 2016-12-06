using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_07_07
{
    public partial class Form1 : Form
    {

        DataTable dtBooks;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RowVersion();
        }

        private void RowVersion()
        {
            listBox1.Items.Clear();
            dtBooks = new DataTable("Books");
            //書名
            DataColumn colTitle = new DataColumn("Title");
            colTitle.DataType = System.Type.GetType("System.String");
            colTitle.MaxLength = 30;
            //將欄位加入資料表
            dtBooks.Columns.Add(colTitle);
            DataRow drDataRow;
            drDataRow = dtBooks.NewRow();
            if (rbNewRow.Checked)
            {
                listBox1.Items.Add("執行dtBooks的NewRow()");
                CheckRowVersion(drDataRow);
            }
            drDataRow["Title"] = "Visual Basic.Net進銷存程式設計";
            dtBooks.Rows.Add(drDataRow);
            if (rbNewRow.Checked)
            {
                listBox1.Items.Add("將NewRow()加入dtProduct");
                CheckRowVersion(drDataRow);
            }
            if ((rbAcceptChanges.Checked) || (rbBeginEdit.Checked))
            {
                if (rbNewRow.Checked)
                {
                    listBox1.Items.Add("執行DataRow的AcceptChanges()方法");
                }
                drDataRow.AcceptChanges();
            }
            else
            {
                if (rbNewRow.Checked)
                {
                    listBox1.Items.Add("執行DataRow的RejectChanges()方法");
                    drDataRow.RejectChanges();
                }
            }
            if (rbNewRow.Checked)
            {
                CheckRowVersion(drDataRow);
            }
            if (rbBeginEdit.Checked)
            {
                drDataRow.BeginEdit();
                listBox1.Items.Add("執行DataRow的BeginEdit()方法");
                drDataRow["Title"] = "Visual Basic 2005資料庫程式設計";
                CheckRowVersion(drDataRow);
                if (rbEndEdit.Checked)
                {
                    listBox1.Items.Add("執行DataRow的EndEdit()方法");
                    drDataRow.EndEdit();
                    CheckRowVersion(drDataRow);
                    if (rbAcceptChanges.Checked)
                    {
                        listBox1.Items.Add("執行DataRow的AcceptChanges()方法");
                        drDataRow.AcceptChanges();
                        CheckRowVersion(drDataRow);
                    }
                    else
                    {
                        listBox1.Items.Add("執行DataRow的RejectChanges()方法");
                        drDataRow.RejectChanges();
                        CheckRowVersion(drDataRow);
                    }
                }
                else
                {
                    listBox1.Items.Add("執行DataRow的CancelEdit()方法");
                    drDataRow.CancelEdit();
                    CheckRowVersion(drDataRow);
                }
            }
        }

        private void CheckRowVersion(DataRow drDataRow)
        {
            //Current
            if (drDataRow.HasVersion(DataRowVersion.Current))
            {
                listBox1.Items.Add("Title的Current值: " + 
                    drDataRow["Title", DataRowVersion.Current]);
            }
            else
            {
                listBox1.Items.Add("Title無Current值.");
            }
            //Default
            if (drDataRow.HasVersion(DataRowVersion.Default))
            {
                listBox1.Items.Add("Title的Default值: " + 
                    drDataRow["Title", DataRowVersion.Default]);
            }
            else
            {
                listBox1.Items.Add("Title無Default值.");
            }
            //Original
            if (drDataRow.HasVersion(DataRowVersion.Original))
            {
                listBox1.Items.Add("Title的Original值: " +
                    drDataRow["Title", DataRowVersion.Original]);
            }
            else
            {
                listBox1.Items.Add("Title無Original值.");
            }
            //Proposed
            if (drDataRow.HasVersion(DataRowVersion.Proposed))
            {
                listBox1.Items.Add("Title的Proposed值: " +
                    drDataRow["Title", DataRowVersion.Proposed]);
            }
            else
            {
                listBox1.Items.Add("Title無Proposed值.");
            }
        }
    }
}
