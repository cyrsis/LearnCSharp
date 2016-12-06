using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.xINDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'xINDataSet.DeliveryDetails' 資料表。您可以視需要進行移動或移除。
            this.taDetails.Fill(this.xINDataSet.DeliveryDetails);
            // TODO: 這行程式碼會將資料載入 'xINDataSet.Delivery' 資料表。您可以視需要進行移動或移除。
            this.taDelivery.Fill(this.xINDataSet.Delivery);
        }

        private void deliveryDetailsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //認可父資料表的記錄
            deliveryBindingSource.EndEdit();
        }

        private void txtCustomerID_Validated(object sender, EventArgs e)
        {
            //依客戶編號帶出客戶名稱
            companyNameTextBox.Text = taDelivery.GetCompanyName(txtCustomerID.Text);
        }

        private void dgvDetails_CellValidated(object sender, 
                                              DataGridViewCellEventArgs e)
        {
            //依商品編號帶出商品名稱
            if (dgvDetails.Columns[e.ColumnIndex].Name == "colProductID")
            {
                //如果商品編號是空值,就將商品名稱清成空白
                if (DBNull.Value.Equals(dgvDetails.Rows[e.RowIndex].Cells[
                                     "colProductID"].Value))
                {
                    dgvDetails.Rows[e.RowIndex].Cells["colProductName"].Value = "";
                }
                else
                {
                    dgvDetails.Rows[e.RowIndex].Cells["colProductName"].Value =
                           taDetails.GetProductName(Convert.ToString(
                           dgvDetails.Rows[e.RowIndex].Cells["colProductID"].Value));
                }
            }
        }
    }
}
