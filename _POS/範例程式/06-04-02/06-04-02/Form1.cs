using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FillData()
        {
            //暫時關閉條件約束
            dsXIN1.EnforceConstraints = false;
            //載入資料
            daDelivery.Fill(dsXIN1, "Delivery");
            daDeliveryDetails.Fill(dsXIN1, "DeliveryDetails");
            //開啟條件約束
            dsXIN1.EnforceConstraints = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //終止目前所有的資料異動   
            //明細先儲存再儲存主檔
            deliveryDetailsBindingSource.EndEdit();
            deliveryBindingSource.EndEdit();
            //有刪除的資料嗎?
            if (!dsXIN1.HasChanges(DataRowState.Deleted))
            {
                try
                {
                    //先更新主檔再更新明細檔
                    daDelivery.Update(dsXIN1, "Delivery");
                    daDeliveryDetails.Update(dsXIN1, "DeliveryDetails");
                    dsXIN1.AcceptChanges();
                }
                catch (System.SystemException err)
                {
                    dsXIN1.RejectChanges();
                    MessageBox.Show(err.ToString());
                    throw;
                }
            }
            else
            {
                try
                {
                    //先更新明細檔再更新主檔
                    daDeliveryDetails.Update(dsXIN1, "DeliveryDetails");
                    daDelivery.Update(dsXIN1, "Delivery");
                    dsXIN1.AcceptChanges();
                }
                catch (System.SystemException err)
                {
                    dsXIN1.RejectChanges();
                    MessageBox.Show(err.ToString());
                    throw;
                }
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void deliveryDetailsDataGridView_CellBeginEdit(object sender, 
            DataGridViewCellCancelEventArgs e)
        {
            deliveryBindingSource.EndEdit();
        }
    }
}
