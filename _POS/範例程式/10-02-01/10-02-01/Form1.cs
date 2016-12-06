using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            using (var context = new XINEntities())
            {
                var qry = (from S in context.Supplier
                           where S.SupplierID == txtQrySupplierID.Text
                           select S).FirstOrDefault();
                if (qry == null)
                {
                    //找不到記錄
                    MessageBox.Show(String.Format(
                       "找不到廠商編號{0}的記錄。", txtQrySupplierID.Text));
                }
                else
                {
                    //找到記錄，取得廠商記錄
                    txtSupplierID.Text = qry.SupplierID;
                    txtAttribName.Text = qry.AttribName;
                    txtCompanyName.Text = qry.CompanyName;
                    txtEarNo.Text = qry.EarNo;
                    txtJoinMan.Text = qry.JoinMan;
                    txtTel1.Text = qry.Tel1;
                    txtTel2.Text = qry.Tel2;
                    txtFax.Text = qry.Fax;
                    txtMobilePhone.Text = qry.MobilePhone;
                    txtCompanyAddress.Text = qry.CompanyAddress;
                    txtDeliveryAddress.Text = qry.DeliveryAddress;
                    txtComment.Text = qry.Comment;
                    //判斷最後進貨日是否有值
                    if (qry.LastReceiptDate == null) 
                    {
                        txtLastReceiptDate.Text = "";
                    }
                    else
                    {
                        txtLastReceiptDate.Text = ((DateTime)(qry.LastReceiptDate)
                                                  ).ToShortDateString();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new XINEntities())
                {
                    var supplier = context.Supplier.First(
                                   S => S.SupplierID == txtQrySupplierID.Text);
                    //將修改後的廠商資料填滿Supplier的每個屬性
                    supplier.AttribName = txtAttribName.Text;
                    supplier.CompanyName = txtCompanyName.Text;
                    supplier.EarNo = txtEarNo.Text;
                    supplier.JoinMan = txtJoinMan.Text;
                    supplier.Tel1 = txtTel1.Text;
                    supplier.Tel2 = txtTel2.Text;
                    supplier.Fax = txtFax.Text;
                    supplier.MobilePhone = txtMobilePhone.Text;
                    supplier.CompanyAddress = txtCompanyAddress.Text;
                    supplier.DeliveryAddress = txtDeliveryAddress.Text;              
                    supplier.Comment = txtComment.Text;
                    context.SaveChanges();
                    MessageBox.Show("廠商基本資料修改成功。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改廠商基本資料發生錯誤。\r\n" +
                                ex.InnerException.Message);
            }
        }
    }
}
