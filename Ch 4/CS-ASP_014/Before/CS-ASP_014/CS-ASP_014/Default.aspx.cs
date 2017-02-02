using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;
            ////resultLabel.Text = myValue.ToString();

            //resultLabel.Text = myValue.AddMonths(2).ToString();     // Returns date 2 months from now
            //resultLabel.Text = myValue.Month.ToString();        // Returns current month

            DateTime myValue = DateTime.Parse("9/21/1993");
            resultLabel.Text = myValue.ToLongDateString();
        }
    }
}