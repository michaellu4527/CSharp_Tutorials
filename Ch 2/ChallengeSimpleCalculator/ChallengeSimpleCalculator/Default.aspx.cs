using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBox1.Text); // User input is considered a string, so converting it to int
            int number2 = int.Parse(TextBox2.Text);
            int sum = number1 + number2;

            resultLabel.Text = sum.ToString();
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBox1.Text); // User input is considered a string, so converting it to int
            int number2 = int.Parse(TextBox2.Text);
            int difference = number1 - number2;

            resultLabel.Text = difference.ToString();
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBox1.Text); // User input is considered a string, so converting it to int
            int number2 = int.Parse(TextBox2.Text);
            double product = number1 * number2;

            resultLabel.Text = product.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBox1.Text); // User input is considered a string, so converting it to int
            int number2 = int.Parse(TextBox2.Text);
            double quotient = (double)number1 / number2;

            resultLabel.Text = quotient.ToString();
        }
    }
}