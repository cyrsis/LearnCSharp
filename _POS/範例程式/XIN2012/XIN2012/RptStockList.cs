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
    public partial class fmRptStockList : XIN2012.fmBasePreviewReport
    {
        public fmRptStockList()
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
    }
}
