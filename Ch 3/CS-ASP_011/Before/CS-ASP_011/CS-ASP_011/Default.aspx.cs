using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = "";  // Empty string beforehand

            //if (firstTextBox.Text == secondTextBox.Text)    // Testing if numbers are equal
            //{
            //    resultLabel.Text = "Yes! The numbers are equal!";
            //}
            //else
            //{
            //    resultLabel.Text = "No, the numbers aren't equal...";
            //}

            //if (!coolCheckBox.Checked)   // For booleans, referencing the variable means "true", ! means "false"
            //{
            //    resultLabel.Text = "Yes, you are definitely cool.";
            //}
            //else
            //{
            //    resultLabel.Text = "Don't be so hard on yourself.";
            //}

            if (lobsterRadioButton.Checked)
            {
                resultLabel.Text = "You must be from the Blue Ginger!";
            }
            else if (chickenRadioButton.Checked)
            {
                resultLabel.Text = "Gobble gobble";
            }
            else if (muffinRadioButton.Checked)
            {
                resultLabel.Text = "Muffy";
            }
            else
            {
                resultLabel.Text = "Please select one of the options.";
            }

        }
    }
}