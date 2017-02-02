using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_023
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];   // Cast it to array of doubles

            // Creates new array of specified size in memory. Copies all items from old array into new one and deletes old one
            Array.Resize(ref hours, hours.Length + 1);  // Get a reference to location in memory

            int newestItem = hours.GetUpperBound(0); // GetUpperBound gets largest index in an array (no need to do                                               size-1)

            hours[newestItem] = double.Parse(hoursTextBox.Text);
            ViewState["Hours"] = hours;

            // Follow the "N" by the number of decimal places you want the answer to be formatted to.
            resultLabel.Text = String.Format("Total hours: {0}<br />Least Hours: {2}<br />Average Hours: {3:N2}", 
                hours.Sum(),
                hours.Max(),
                hours.Min(),
                hours.Average());  

        }
    }
}