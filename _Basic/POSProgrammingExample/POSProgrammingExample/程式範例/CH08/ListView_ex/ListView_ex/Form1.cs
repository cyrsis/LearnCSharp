using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Product = txtProduct.Text;
            int Price = int.Parse(txtPrice.Text);
            int Quantity = int.Parse(txtQuantity.Text);
            int Totals = Price * Quantity;
            bool isDuplicate = false;
            DialogResult Dr;
            Dr = MessageBox.Show("是否將商品[" + Product + "]加入出貨單中?",
                       "出貨作業", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (Dr == DialogResult.Yes)
            {
                //第一個商品不用判斷商品是否重複
                if (lvwItemsList.Items.Count < 1)
                {
                    ListViewItem LVI = new ListViewItem(Product);
                    LVI.SubItems.Add(Price.ToString());
                    LVI.SubItems.Add(Quantity.ToString());
                    LVI.SubItems.Add(Totals.ToString());
                    lvwItemsList.Items.Add(LVI);
                }
                else
                {
                    //檢查是否有重複商品項目，若有則進行累加動作
                    for (int i = 0; i < lvwItemsList.Items.Count; i++)
                    {
                        if (Product == lvwItemsList.Items[i].SubItems[0].Text)
                        {
                            string NewFood = lvwItemsList.Items[i].SubItems[0].Text;
                            int OldPrice = Convert.ToInt32(lvwItemsList.Items[i].SubItems[1].Text);
                            int OldNums = Convert.ToInt32(lvwItemsList.Items[i].SubItems[2].Text) + int.Parse(txtQuantity.Text);
                            int OldTotal = OldPrice * OldNums;
                            string NewPrice = OldPrice.ToString();
                            string NewNums = OldNums.ToString();
                            string NewTotals = OldTotal.ToString();

                            lvwItemsList.Items.RemoveAt(i);

                            ListViewItem LVI = new ListViewItem(NewFood);
                            LVI.SubItems.Add(NewPrice);
                            LVI.SubItems.Add(NewNums);
                            LVI.SubItems.Add(NewTotals);
                            lvwItemsList.Items.Add(LVI);
                            isDuplicate = true;
                        }
                    }

                    if (isDuplicate ==false) // 若商品沒有重複則直接加入到ListView
                    {
                        ListViewItem LVI = new ListViewItem(Product);
                        LVI.SubItems.Add(Price.ToString());
                        LVI.SubItems.Add(Quantity.ToString());
                        LVI.SubItems.Add(Totals.ToString());
                        lvwItemsList.Items.Add(LVI);
                    }

                }

            }
        }
    }
}
