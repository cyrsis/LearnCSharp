using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_02_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter.Fill(dsXIN1, "Customer");
            dsXIN1.AcceptChanges();
            //Fill資料後不要自動AcceptChanges
            adapter.AcceptChangesDuringFill = false;
            //修改後的記錄
            DataView viewCusrrent = new DataView(dsXIN1.Tables["Customer"]);
            viewCusrrent.RowStateFilter = DataViewRowState.ModifiedCurrent;
            gridCurrent.DataSource = viewCusrrent;
            //修改前的記錄
            DataView viewOriginal = new DataView(dsXIN1.Tables["Customer"]);
            viewOriginal.RowStateFilter = DataViewRowState.ModifiedOriginal;
            gridOriginal.DataSource = viewOriginal;
            //未修改的記錄
            DataView viewUnchanged = new DataView(dsXIN1.Tables["Customer"]);
            viewUnchanged.RowStateFilter = DataViewRowState.Unchanged;
            gridUnchanged.DataSource = viewUnchanged;
            //刪除的記錄
            DataView viewDeleted = new DataView(dsXIN1.Tables["Customer"]);
            viewDeleted.RowStateFilter = DataViewRowState.Deleted;
            gridDeleted.DataSource = viewDeleted;
            //新增的記錄
            DataView viewAdded = new DataView(dsXIN1.Tables["Customer"]);
            viewAdded.RowStateFilter = DataViewRowState.Added;
            gridAdded.DataSource = viewAdded;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (radioOverwriteChanges.Checked)
            {
                //OverwriteChanges
                adapter.FillLoadOption = LoadOption.OverwriteChanges;
            }
            else if (radioPreserveChanges.Checked)
            {
                //PreserveChanges
                adapter.FillLoadOption = LoadOption.PreserveChanges;
            }
            else
            {
                //Upsert
                adapter.FillLoadOption = LoadOption.Upsert;
            }
            adapter.Fill(dsXIN1, "Customer");
        }
    }
}
