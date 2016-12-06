using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace XIN2012
{
    public partial class fmRptProduct : XIN2012.fmBasePreviewReport
    {
        public fmRptProduct()
        {
            InitializeComponent();
        }

        public override void GenerateReport()
        {
            using (var context = new XINEntities())
            {
                var qry = from P in context.Product
                          orderby P.ProductID
                          select P;
                ProductBindingSource.DataSource = qry;
            }
        }

        private void RptProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
