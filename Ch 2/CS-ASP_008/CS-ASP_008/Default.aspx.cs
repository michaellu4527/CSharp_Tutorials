using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_008
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //// Up cast
            //int i = 2000000000;
            //long j = i;

            //// Down cast
            //long i = 2000000000;
            //int j = (int)i;

            //double k = 2.5;
            //int j = (int)k;

            //resultLabel.Text = j.ToString();    // Converts j to string

            string i = inputTextBox.Text;
            int j = int.Parse(i);       // Will take string value and convert it to specified data type
            int k = j + 1;

            resultLabel.Text = k.ToString();
        }
    }
}