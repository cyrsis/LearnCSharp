using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Objects;

namespace _09_07_01
{
    public partial class Form1 : Form
    {

        //建立DataContext類別的物件
        XINEntities context = new XINEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //出貨金額統計(Sum)
            if (radioLINQtoEntities.Checked)
            {
                //Linq to Entities
                var qry = context.Delivery.Sum(M => M.Amount);
                listBox1.Items.Add("出貨金額統計:" + qry);
            }
            else if (radioEntitySQL.Checked) 
            {
                //Entity SQL
                string sSQL  = "SELECT SUM(M.Amount) AS Amount " +
                               "FROM XINEntities.Delivery AS M ";
                var qry = new ObjectQuery<DbDataRecord>
                                    (sSQL, context).FirstOrDefault();
                listBox1.Items.Add("出貨金額統計:" + qry[0]);
            }
            else
            {
                //Query Builder Methods
                ObjectQuery<DbDataRecord> qry = 
                    context.Delivery.Select("SUM(it.Amount)");
                DbDataRecord rec = qry.FirstOrDefault();
                listBox1.Items.Add("出貨金額統計:" + rec[0]);
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //出貨單平均接單金額(Average)
            if (radioLINQtoEntities.Checked)
            {
                //Linq to Entities
                var qry = context.DeliveryDetails.Average(D => D.Amount);
                listBox1.Items.Add("出貨單平均接單金額:" + qry.ToString("##0"));
            }
            else if (radioEntitySQL.Checked)
            {
                //Entity SQL
                string sSQL = "SELECT AVG(D.Amount) AS Amount " +
                              "FROM XINEntities.DeliveryDetails AS D ";
                var qry = new ObjectQuery<DbDataRecord>
                                    (sSQL, context).FirstOrDefault();
                listBox1.Items.Add("出貨單平均接單金額:" + qry[0]);
            }
            else
            {
                //Query Builder Methods
                ObjectQuery<DbDataRecord> qry =
                    context.DeliveryDetails.Select("AVG(it.Amount)");
                DbDataRecord rec = qry.FirstOrDefault();
                listBox1.Items.Add("出貨單平均接單金額:" + rec[0]);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //單筆最高的出貨金額(Max)
            if (radioLINQtoEntities.Checked)
            {
                //Linq to Entities
                var qry = context.Delivery.Max(M => M.Amount);
                listBox1.Items.Add("單筆最高的出貨金額:" + qry);
            }
            else if (radioEntitySQL.Checked)
            {
                //Entity SQL
                string sSQL = "SELECT MAX(M.Amount) AS Amount " +
                              "FROM XINEntities.Delivery AS M ";
                var qry = new ObjectQuery<DbDataRecord>
                                    (sSQL, context).FirstOrDefault();
                listBox1.Items.Add("單筆最高的出貨金額:" + qry[0]);
            }
            else
            {
                //Query Builder Methods
                ObjectQuery<DbDataRecord> qry =
                    context.Delivery.Select("MAX(it.Amount)");
                DbDataRecord rec = qry.FirstOrDefault();
                listBox1.Items.Add("單筆最高的出貨金額:" + rec[0]);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //金額最小的出貨明細(Min)
            if (radioLINQtoEntities.Checked)
            {
                //Linq to Entities
                var qry = context.DeliveryDetails.Min(D => D.Amount);
                listBox1.Items.Add("金額最小的出貨明細:" + qry);
            }
            else if (radioEntitySQL.Checked)
            {
                //Entity SQL
                string sSQL = "SELECT MIN(D.Amount) AS Amount " +
                              "FROM XINEntities.DeliveryDetails AS D ";
                var qry = new ObjectQuery<DbDataRecord>
                                    (sSQL, context).FirstOrDefault();
                listBox1.Items.Add("金額最小的出貨明細:" + qry[0]);
            }
            else
            {
                //Query Builder Methods
                ObjectQuery<DbDataRecord> qry =
                    context.DeliveryDetails.Select("MIN(it.Amount)");
                DbDataRecord rec = qry.FirstOrDefault();
                listBox1.Items.Add("金額最小的出貨明細:" + rec[0]);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //累計出貨單筆數(Count)
            if (radioLINQtoEntities.Checked)
            {
                //Linq to Entities
                var qry = context.Delivery.Count();
                listBox1.Items.Add("累計出貨單筆數:" + qry);
            }
            else if (radioEntitySQL.Checked)
            {
                //Entity SQL
                string sSQL = "SELECT COUNT(M.DeliveryID) AS Amount " +
                              "FROM XINEntities.Delivery AS M ";
                var qry = new ObjectQuery<DbDataRecord>
                                    (sSQL, context).FirstOrDefault();
                listBox1.Items.Add("累計出貨單筆數:" + qry[0]);
            }
            else
            {
                //Query Builder Methods
                ObjectQuery<DbDataRecord> qry =
                    context.Delivery.Select("COUNT(it.DeliveryID)");
                DbDataRecord rec = qry.FirstOrDefault();
                listBox1.Items.Add("累計出貨單筆數:" + rec[0]);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //是否所有的售價皆大於500(All)
            if (radioLINQtoEntities.Checked)
            {
                //Linq to Entities
                var qry = context.DeliveryDetails.All(D => D.UnitPrice > 500);
                listBox1.Items.Add("是否所有的售價皆大於500:" + qry);
            }
            else if (radioEntitySQL.Checked)
            {
                //Entity SQL
                listBox1.Items.Add("是否所有的售價皆大於500:" + 
                                   "Entity SQL不支援ALL運算子");
            }
            else
            {
                //Query Builder Methods
                listBox1.Items.Add("是否所有的售價皆大於500:" +
                                   "查詢產生器不支援ALL運算子");
            }
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            //是否有任何一筆的售價大於500(Any)
            if (radioLINQtoEntities.Checked)
            {
                //Linq to Entities
                var qry = context.DeliveryDetails.Any(D => D.Amount > 500);
                listBox1.Items.Add("是否有任何一筆的售價大於500:" + qry);
            }
            else if (radioEntitySQL.Checked)
            {
                //Entity SQL
                listBox1.Items.Add("是否有任何一筆的售價大於500:" + 
                                   "Entity SQL不支援ANY運算子");
            }
            else
            {
                //Query Builder Methods
                listBox1.Items.Add("是否有任何一筆的售價大於500:" + 
                                   "查詢產生器不支援ANY運算子");
            }
        }
    }
}
