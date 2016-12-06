using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace _10_02_02
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
                    //取得Supplier物件的ObjectStateEntry
                    ObjectStateEntry stateEntry = context
                                                  .ObjectStateManager
                                                  .GetObjectStateEntry(supplier);
                    //取得Supplier物件的目前值
                    CurrentValueRecord rec = stateEntry.CurrentValues;
                    //廠商簡稱
                    if (txtAttribName.Text !=
                       (string)(rec.GetValue(rec.GetOrdinal("AttribName"))))
                    {
                        supplier.AttribName = txtAttribName.Text;
                    }
                    //廠商名稱
                    if (txtCompanyName.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("CompanyName"))))
                    {
                        supplier.CompanyName = txtCompanyName.Text;
                    }
                    //統一編號
                    if (txtEarNo.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("EarNo"))))
                    {
                        supplier.EarNo = txtEarNo.Text;
                    }
                    //聯絡人
                    if (txtJoinMan.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("JoinMan"))))
                    {
                        supplier.JoinMan = txtJoinMan.Text;
                    }
                    //電話1
                    if (txtTel1.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("Tel1"))))
                    {
                        supplier.Tel1 = txtTel1.Text;
                    }
                    //電話2
                    if (txtTel2.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("Tel2"))))
                    {
                        supplier.Tel2 = txtTel2.Text;
                    }
                    //傳真
                    if (txtFax.Text != (string)(rec.GetValue(rec.GetOrdinal("Fax"))))
                    {
                        supplier.Fax = txtFax.Text;
                    }
                    //行動電話
                    if (txtMobilePhone.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("MobilePhone"))))
                    {
                        supplier.MobilePhone = txtMobilePhone.Text;
                    }
                    //公司地址
                    if (txtCompanyAddress.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("CompanyAddress"))))
                    {
                        supplier.CompanyAddress = txtCompanyAddress.Text;
                    }
                    //送貨地址
                    if (txtDeliveryAddress.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("DeliveryAddress"))))
                    {
                        supplier.DeliveryAddress = txtDeliveryAddress.Text;
                    }
                    //備註
                    if (txtComment.Text != 
                        (string)(rec.GetValue(rec.GetOrdinal("Comment"))))
                    {
                        supplier.Comment = txtComment.Text;
                    }
                    //儲存變更
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
