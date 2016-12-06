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
    public partial class fmRptSupplier : XIN2012.fmBasePreviewReport
    {
        public fmRptSupplier()
        {
            InitializeComponent();
        }

        public override void GenerateReport()
        {
            using (var context = new XINEntities())
            {
                var qry = from S in context.Supplier
                          orderby S.SupplierID
                          select S;
                SupplierBindingSource.DataSource = qry;
            }
        }
    }
}
