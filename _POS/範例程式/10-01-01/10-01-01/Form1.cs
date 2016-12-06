using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_01_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text.Trim() == "")
            {
                MessageBox.Show("請輸入廠商編號。");
                return;
            }

            using (var context = new XINEntities())
            {
                try
                {
                    Supplier NewSupplier = new Supplier();
                    //填滿NewSupplier的每個屬性
                    NewSupplier.SupplierID = txtSupplierID.Text;
                    NewSupplier.AttribName = txtAttribName.Text;
                    NewSupplier.CompanyName = txtCompanyName.Text;
                    NewSupplier.EarNo = txtEarNo.Text;
                    NewSupplier.JoinMan = txtJoinMan.Text;
                    NewSupplier.Tel1 = txtTel1.Text;
                    NewSupplier.Tel2 = txtTel2.Text;
                    NewSupplier.Fax = txtFax.Text;
                    NewSupplier.MobilePhone = txtMobilePhone.Text;
                    NewSupplier.CompanyAddress = txtCompanyAddress.Text;
                    NewSupplier.DeliveryAddress = txtDeliveryAddress.Text;              
                    NewSupplier.Comment = txtComment.Text;
                    //將NewSupplier加入Supplier實體類型
                    context.AddObject("Supplier", NewSupplier);
                    context.SaveChanges();
                    MessageBox.Show("新增廠商成功。");
                    //清空所有文字方塊控制項的內容
                    txtSupplierID.Text = "";
                    txtAttribName.Text = "";
                    txtCompanyName.Text = "";
                    txtEarNo.Text = "";
                    txtJoinMan.Text = "";
                    txtTel1.Text = "";
                    txtTel2.Text = "";
                    txtFax.Text = "";
                    txtMobilePhone.Text = "";
                    txtCompanyAddress.Text = "";
                    txtDeliveryAddress.Text = "";
                    txtComment.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("新增廠商發生錯誤。\r\n " + 
                            ex.InnerException.Message);
                }
            }
        }
    }
}
