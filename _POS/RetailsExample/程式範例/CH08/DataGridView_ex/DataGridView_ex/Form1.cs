using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0) // 確保一行Row只執行一次。 
            {
                dgvItems.Rows[e.RowIndex].HeaderCell.Value = String.Format("{0}", e.RowIndex + 1);
            }
        }

        private int FindDataGridViewCell(DataGridView dgv, string ColumnName, string ColumnValue)
        {
            if (dgv.Rows.Count >= 1)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {

                    if (row.Cells[ColumnName].Value != null)
                    {
                        if (row.Cells[ColumnName].Value.ToString() == ColumnValue)
                            return row.Cells[ColumnName].RowIndex;
                    }
                }
            }

            return -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int price , quantity, totals;
            int rowIndex = FindDataGridViewCell(dgvItems, "Item", txtItem.Text);
            if (rowIndex != -1) //有找到相同商品名稱
            {
                dgvItems.Rows[rowIndex].Cells["Item"].Value = txtItem.Text;
                price = int.Parse(txtPrice.Text);
                quantity = int.Parse(txtQuantity.Text);
                totals = price * quantity;
                int totalQuantity = quantity + int.Parse(dgvItems.Rows[rowIndex].Cells["Quantity"].Value.ToString());
                dgvItems.Rows[rowIndex].Cells["Quantity"].Value = totalQuantity.ToString();
                int newTotals = price * totalQuantity;
                dgvItems.Rows[rowIndex].Cells["Totals"].Value = newTotals.ToString();
            }
            else
            {
                var index = dgvItems.Rows.Add();
                price = int.Parse(txtPrice.Text);
                quantity = int.Parse(txtQuantity.Text);
                totals = price * quantity;
                dgvItems.Rows[index].Cells["Item"].Value = txtItem.Text;
                dgvItems.Rows[index].Cells["Price"].Value = price.ToString();
                dgvItems.Rows[index].Cells["Quantity"].Value = quantity.ToString();
                dgvItems.Rows[index].Cells["Totals"].Value = totals.ToString();
            }
        }

        private void btnGetItems_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count >= 1)
            {
                string msg = "";
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells["Item"].Value != null)
                    {
                        msg = msg + "商品名稱:" + row.Cells["Item"].Value.ToString() + ", ";
                    }
                    if (row.Cells["Price"].Value != null)
                    {
                        msg = msg + "商品價格:" + row.Cells["Price"].Value.ToString() + ", ";
                    }
                    if (row.Cells["Quantity"].Value != null)
                    {
                        msg = msg + "商品數量:" + row.Cells["Quantity"].Value.ToString() + ", ";
                    }
                    if (row.Cells["Totals"].Value != null)
                    {
                        msg = msg + "小計:" + row.Cells["Totals"].Value.ToString() + "\n";
                    }

                }
                MessageBox.Show(msg, "購買商品清單");
            }
            else
            {
                MessageBox.Show("商品清單上無任何資料!!", "購買商品清單");
            }
        }
    }
}
