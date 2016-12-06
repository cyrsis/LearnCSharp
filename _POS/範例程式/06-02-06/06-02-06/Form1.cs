using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_02_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            adapter.Fill(dsXIN1, "Product");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dsXIN1, "Product");
            }
            catch (System.Data.DBConcurrencyException dbErr)
            {
                //先看DataSet有沒有錯誤
                if (dsXIN1.HasErrors)
                {
                    //再找DataSet裡的每一個DataTable
                    foreach (DataTable dtProduct in dsXIN1.Tables)
                    {
                        //看問題是不是發生在dtProduct
                        if (dtProduct.HasErrors)
                        {
                            //看是哪一筆記錄有問題
                            foreach (DataRow drProduct in dtProduct.Rows)
                            {
                                if (drProduct.HasErrors)
                                {
                                    MessageBox.Show("記錄:" +
                                        Convert.ToString(drProduct["ProductID"]) + 
                                        "\r\n\r\n" + drProduct.RowError,
                                        "更新發生錯誤");
                                    //再找出來是哪個欄位出了問題
                                    foreach (DataColumn colProduct in 
                                             drProduct.GetColumnsInError())
                                    {
                                        MessageBox.Show(colProduct.ColumnName);
                                    }
                                    //清除DataRow的錯誤
                                    drProduct.ClearErrors();
                                    //取消發生錯誤的DataRow之更新
                                    drProduct.RejectChanges();
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
                dsXIN1.RejectChanges();
            }
        }
    }
}
