using Sixeyed.CarValet.Web.ApiClient;
using Sixeyed.Core.Logging;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace Sixeyed.CarValet.Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Log.Debug("Index.Page_Load called");
            var contentItems = ContentClient.GetItems("WEB_HOME");
            foreach (var item in contentItems.OrderBy(x => x.Index))
            {
                var literal = new Literal();
                literal.Text = item.Value;
                cms.Controls.Add(literal);
            }
        }
    }
}