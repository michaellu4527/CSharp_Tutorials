using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            totalLabel.Text = " ";
        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total = 0;

            // Totaling price for size of pizza
            if (babySizeRadioButton.Checked)
            {
                total = 10.00;
            }
            else if (mamaSizeRadioButton.Checked)
            {
                total = 13.00;
            }
            else if (papaSizeRadioButton.Checked)
            {
                total = 16.00;
            }
            else
            {
                total = 0;
            }

            // Totalling price for type of pizza
            if (deepDishRadioButton.Checked)
            {
                total = total + 2.00;
            }

            // Calculating prices for toppings
            if (pepperoniCheckBox.Checked)
            {
                total = total + 1.50;
            }
            if (onionsCheckBox.Checked)
            {
                total = total + 0.75;
            }
            if (greenPeppersCheckBox.Checked)
            {
                total = total + 0.50;
            }
            if (redPeppersCheckBox.Checked)
            {
                total = total + 0.75;
            }
            if (anchoviesCheckBox.Checked)
            {
                total = total + 2.00;
            }

            // Factoring in the "special deal"
            if ((pepperoniCheckBox.Checked && greenPeppersCheckBox.Checked && anchoviesCheckBox.Checked) ||
                (pepperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked))
            {
                total = total - 2.00;
            }

            // Show the subtotal to the user
            totalLabel.Text = total.ToString();
        }
    }
}