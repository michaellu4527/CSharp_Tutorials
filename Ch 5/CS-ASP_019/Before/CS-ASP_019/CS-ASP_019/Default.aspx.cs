using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank you, {0}, for your business", nameTextBox.Text);

            long ss = long.Parse(ssTextBox.Text);     // Converting value inside social security box into an int

            long phone = long.Parse(phoneTextBox.Text);

            /*
            string result = String.Format("Thank you, {0}, for your business. " +
                "<br />Your Social Security number is: {1:000-00-000}" +
                "<br />Phone: {2: (000)-000-0000}" +
                "<br />Loan Date: {3:ddd -- MM/dd/yyyy}",
                nameTextBox.Text, 
                ssTextBox.Text, 
                ss,
                loanDateCalendar.SelectedDate);   // Use : followed by desired format
                */

            double salary = double.Parse(salaryTextBox.Text);
            string result = String.Format("Thank you, {0}, for your business. " +
                      "<br />Your Social Security number is: {1:000-00-000}" +
                      "<br />Phone: {2: (000)-000-0000}" +
                      "<br />Loan Date: {3:ddd -- MM/dd/yyyy}" +
                      "<br />Salary: {4:C}",
                      nameTextBox.Text,
                      ssTextBox.Text,
                      ss,
                      loanDateCalendar.SelectedDate,
                      salary);   // Use : followed by desired format    


            resultLabel.Text = result;
        }
    }
}