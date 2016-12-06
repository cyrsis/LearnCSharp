using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_07_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //如果productTextBox的ReadOnly=false,代表是新增記錄
            if (productIDTextBox.ReadOnly == false)
            {
                Exception MyError1 = new Exception("商品編號不可空白!");
                Exception MyError2 = new Exception("商品編號重覆!");
                try
                {
                    if (productIDTextBox.Text.Length == 0)
                    {
                        productIDTextBox.Focus();
                        throw MyError1;
                    }
                    String ProductID = productTableAdapter.QueryByProductID(
                                                            productIDTextBox.Text);
                    if (ProductID != null)
                    {
                        productIDTextBox.Focus();
                        throw MyError2;
                    }
                    productIDTextBox.ReadOnly = true;
                    this.Validate();
                    this.productBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dataSet1.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            productIDTextBox.ReadOnly = false;
        }
    }
}
