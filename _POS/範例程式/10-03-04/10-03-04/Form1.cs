using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_03_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new XINEntities())
                {
                    var docs = context.Delivery
                                      .Where(M => M.DeliveryID == txtDeliveryID.Text)
                                      .FirstOrDefault();
                    if (docs == null)
                    {
                        MessageBox.Show(String.Format("找不到要刪除的出貨單{0}。",
                                        txtDeliveryID.Text));
                    }
                    else
                    {
                        if (! docs.DeliveryDetails.IsLoaded)
                        {
                            docs.DeliveryDetails.Load();
                        }
                        //刪除出貨單
                        context.DeleteObject(docs);
                        //完成刪除
                        context.SaveChanges();
                        MessageBox.Show(String.Format("出貨單{0}刪除成功。",
                                                      txtDeliveryID.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除出貨單資料發生錯誤。\r\n" +
                                ex.InnerException.Message);
            }
        }
    }
}
