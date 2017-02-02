using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //string[] values = new string[5];    // Initialize array of size 5
            //values[0] = TextBox1.Text;
            //values[1] = TextBox2.Text;
            //values[2] = TextBox3.Text;
            //values[3] = TextBox4.Text;
            //values[4] = TextBox5.Text;

            //resultLabel.Text = values[2];
            //resultLabel.Text = values.Length.ToString();    // Returns length of array

            string[] vals = new string[5] { "Michael", "Steve", "Brian", "Andy", "Eloy" };
            ViewState.Add("MyValues", vals);
            resultLabel.Text = "Values added...";

        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            string[] vals = (string[])ViewState["MyValues"];  // Need to cast ViewState to string array
            TextBox1.Text = vals[0];
            TextBox2.Text = vals[1];
            TextBox3.Text = vals[2];
            TextBox4.Text = vals[3];
            TextBox5.Text = vals[4];

            resultLabel.Text = "Values retrieved...";


        }
    }
}