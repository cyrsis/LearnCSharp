using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_03_02
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
                    object entity = null;
                    //定義要刪除的實體之索引鍵
                    var ID = new EntityKey("XINEntities.Product", 
                                           "ProductID", txtProductID.Text);
                    //嘗試找出要刪除的實體之索引鍵
                    if (! context.TryGetObjectByKey(ID, out entity))
                    {
                        MessageBox.Show(String.Format("找不到要刪除的商品編號。", 
                                                      txtProductID.Text));
                    }
                    else
                    {
                        var prod = context.GetObjectByKey(ID);
                        context.DeleteObject(prod);
                        context.SaveChanges();
                        MessageBox.Show(String.Format(
                                        "刪除商品編號{0}的商品記錄成功。",
                                        txtProductID.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除廠商基本資料發生錯誤。\r\n" +
                                ex.InnerException.Message);
            }
        }
    }
}
