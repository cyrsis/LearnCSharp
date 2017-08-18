using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebEvents
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountriesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputLabel.Text = CountriesDropDown.SelectedIndex.ToString();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Clicked me";
        }

    }
}