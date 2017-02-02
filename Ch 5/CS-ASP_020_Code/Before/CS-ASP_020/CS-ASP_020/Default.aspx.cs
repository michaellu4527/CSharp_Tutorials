using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// View state PRESERVES any information added to a page after a page is loaded.

namespace CS_ASP_020
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState.Add("MyValue", "");   // Creating dictionary
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string value = ViewState["MyValue"].ToString();     // Will return as type object. Cast into string
            value += valueTextBox.Text + " ";   // Using certain format "value "
            ViewState["MyValue"] = value;       // Storing this new format for value into the viewstate
            resultLabel.Text = value;       // Show in result label

            valueTextBox.Text = "";     // Clear out value text box after the user enters in a value.
        }
    }
}