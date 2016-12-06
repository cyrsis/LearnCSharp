using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnShip_Click(object sender, EventArgs e)
        {
            SIS.Ship sisShip = new SIS.Ship();      //建立sisShip出貨物件
            SIS.Items item1 = new SIS.Items();   //建立item1商品物件
            SIS.Items item2 = new SIS.Items();  //建立item2商品物件

            item1.NAME = "ASUS NB";  //設定屬性
            item1.Price = 12000; //設定屬性
            item1.Quantity = 2; //設定屬性

            item2.NAME = "Acer NB"; //設定屬性
            item2.Price = 11000; //設定屬性
            item2.Quantity = 3; //設定屬性

            List<SIS.Items> items = new List<SIS.Items>(); //建立商品集合items物件
            items.Add(item1);
            items.Add(item2);
            sisShip.ShipItems = items;

            double totals = sisShip.getTaxTotals(); //使用方法
            MessageBox.Show("您購買商品稅後總計:" + totals.ToString() + "元","建立物件");
        }
    }
}

