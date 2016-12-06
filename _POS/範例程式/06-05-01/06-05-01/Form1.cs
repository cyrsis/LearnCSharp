using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.xINDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'xINDataSet.DeliveryDetails' 資料表。您可以視需要進行移動或移除。
            this.deliveryDetailsTableAdapter.Fill(this.xINDataSet.DeliveryDetails);
            // TODO: 這行程式碼會將資料載入 'xINDataSet.Delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.xINDataSet.Delivery);
            // TODO: 這行程式碼會將資料載入 'xINDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter.Fill(this.xINDataSet.Customer);
            // TODO: 這行程式碼會將資料載入 'xINDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            this.customerTableAdapter.Fill(this.xINDataSet.Customer);
        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.xINDataSet);
        }
    }
}
