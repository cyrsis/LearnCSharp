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
    public partial class fmRptCustomer : XIN2012.fmBasePreviewReport
    {
        public fmRptCustomer()
        {
            InitializeComponent();
        }

        public override void GenerateReport()
        {
            using (var context = new XINEntities())
            {
                var qry = from R in context.Customer
                          orderby R.CustomerID
                          select R;
                CustomerBindingSource.DataSource = qry;
            }
        }

        private void fmRptCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
