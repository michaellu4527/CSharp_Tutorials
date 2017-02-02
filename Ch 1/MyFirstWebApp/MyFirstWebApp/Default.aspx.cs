using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //string firstName = firstNameTextBox.Text;   // Storing user input for first name in variable

            string firstName;
            firstName = "Michael";
            resultLabel.Text = firstName;

            //string lastName = lastNameTextBox.Text;     // Storing user input for last name in variable

            //string result = "Hello " + firstName + " " + lastName;  // Concatenating strings

            //resultLabel.Text = result;  // Displaying string into label
        }
    }
}