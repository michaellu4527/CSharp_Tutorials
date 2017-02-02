using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_009
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //int myInteger = 7;
            //int myOtherInteger = 4;

            ////int myResult = myInteger / myOtherInteger;
            //// double myResult = myInteger / myOtherInteger;   // Division is done first so number is already truncated by the time it gets assigned to myResult

            //double myResult = (double)myInteger / myOtherInteger;   // Need to cast it first

            //resultLabel.Text = myResult.ToString();

            int firstNumber = 2000000000;
            int secondNumber = 2000000000;
            int resultNumber = firstNumber * secondNumber;  // Will produce a number that will overflow, outputting "garbage"

            resultLabel.Text = resultNumber.ToString();
        }
    }
}