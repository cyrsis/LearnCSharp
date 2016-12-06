using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_12_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string FProductID, FUnitPrice, FQuantity, FAmount;
            string FSubTotal ;
            
            using (var context = new XINEntities())
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
                    foreach (var M in qry.Delivery)
                    {
                        listBox1.Items.Add(string.Format(
                                   "出貨單號：{0} 出貨日期：{1}",
                                   M.DeliveryID, M.DeliveryDate.ToShortDateString()));
                        listBox1.Items.Add(string.Format("出貨客戶：({0})-{1}",
                                           M.CustomerID, M.Customer.CompanyName));
                        listBox1.Items.Add("=========================================");
                        listBox1.Items.Add(" 商品編號   數  量   單  價    金    額  ");
                        listBox1.Items.Add("---------- -------- -------- ------------");
                        foreach (DeliveryDetails D in M.DeliveryDetails)
                        {
                             FProductID =  D.ProductID.PadRight(10);  
                             FUnitPrice =  D.UnitPrice.ToString().PadLeft(8); 
                             FQuantity = D.Quantity.ToString().PadLeft(8);
                             FAmount = D.Amount.ToString().PadLeft(12);
                             listBox1.Items.Add(FProductID + " " + FQuantity + " " + 
                                                FUnitPrice + " " + FAmount);
                        }
                        listBox1.Items.Add("=========================================");
                        FSubTotal = M.SubTotal.ToString();
                        listBox1.Items.Add("出貨單總計(未稅)：        " + FSubTotal);
                        listBox1.Items.Add("");
                        listBox1.Items.Add("");
                    }
                }
            }
        }
    }
}
