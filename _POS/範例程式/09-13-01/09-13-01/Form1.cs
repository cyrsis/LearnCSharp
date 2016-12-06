using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_13_01
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
            //不自動載入相關物件
            context.ContextOptions.LazyLoadingEnabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var qry = (from R in context.Customer
                       where R.CustomerID == txtCustomerID.Text
                       select R).FirstOrDefault();
            if (qry == null)
            {
                //找不到記錄
                txtCompanyName.Text = "";
                listBox1.Items.Clear();
            }
            else
            {
                 //找到記錄，取得客戶名稱
                 txtCompanyName.Text = qry.CompanyName;
            }
        }

        private void btnQryOrders_Click(object sender, EventArgs e)
        {
            string FProductID, FUnitPrice, FQuantity, FAmount;
            string FSubTotal;
            listBox1.Items.Clear();
            var cust = (from R in context.Customer
                        where R.CustomerID == txtCustomerID.Text
                        select R).FirstOrDefault();

            //檢查客戶的出貨單是否載入
            if (! cust.Delivery.IsLoaded)
            {
                cust.Delivery.Load();
            }

            foreach (Delivery docs in cust.Delivery)
            {
                listBox1.Items.Add(string.Format(
                         "出貨單號：{0} 出貨日期：{1}",
                         docs.DeliveryID, docs.DeliveryDate.ToShortDateString()));
                listBox1.Items.Add(string.Format("出貨客戶：({0})-{1}",
                                   docs.CustomerID, docs.Customer.CompanyName));
                listBox1.Items.Add("=========================================");
                listBox1.Items.Add(" 商品編號   數  量   單  價    金    額  ");
                listBox1.Items.Add("---------- -------- -------- ------------");
                //檢查出貨單的相關出貨單明細是否載入
                if (! docs.DeliveryDetails.IsLoaded)
                {
                    //載入出貨單相關的出貨單明細
                    docs.DeliveryDetails.Load();
                }
                foreach (DeliveryDetails item in docs.DeliveryDetails)
                {
                    FProductID = item.ProductID.PadRight(10);
                    FUnitPrice = item.UnitPrice.ToString().PadLeft(8);
                    FQuantity = item.Quantity.ToString().PadLeft(8);
                    FAmount = item.Amount.ToString().PadLeft(12);
                    listBox1.Items.Add(FProductID + " " + FQuantity + " " + 
                                       FUnitPrice + " " + FAmount);
                }
                listBox1.Items.Add("=========================================");
                FSubTotal = docs.SubTotal.ToString();
                listBox1.Items.Add("出貨單總計(未稅)：        " + FSubTotal);
                listBox1.Items.Add("");
                listBox1.Items.Add("");
            }
        }
    }
}
