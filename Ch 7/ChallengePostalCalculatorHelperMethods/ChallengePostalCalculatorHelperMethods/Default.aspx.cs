using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void handleChange(object sender, EventArgs e)
        {
            performCalculations();
        }

        private void performCalculations()
        {
            // Do the values in the textboxes and checkboxes exist?
            if (!valuesExist())
            {
                return;
            }

            // What is the volume?
            int volume = 0;
            if (!tryGetVolume(out volume))
            {
                return;
            }

            // What is the multiplier?
            double postageMultiplier = getPostageMultiplier();

            // Determine the cost
            double postageCost = getPostageCost(postageMultiplier,volume);

            // Show the user
            displayShippingInfo(postageCost);
        }

        // Checks to make sure checkboxes are checked and values are entered into the textboxes.
        private bool valuesExist()
        {
            if (!airRadioButton.Checked && !groundRadioButton.Checked && !overnightRadioButton.Checked)
            {
                return false;
            }
            if (widthTextBox.Text.Trim().Length == 0 ||
                heightTextBox.Text.Trim().Length == 0)
            {
                return false;
            }
            return true;          
        }

        // Makes sure values are correctly entered and calcs volume
        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width))
            {
                return false;
            }
            if (!int.TryParse(heightTextBox.Text.Trim(), out height))
            {
                return false;
            }
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length))
            {
                length = 1;
            }
            volume = width * height * length;
            return true;          
        }

        // Obtains corresponding postage multiplier depending on which radio button is checked
        private double getPostageMultiplier()
        {
            if (groundRadioButton.Checked)
            {
                return 0.15;
            }
            else if (airRadioButton.Checked)
            {
                return 0.25;
            }
            else if (overnightRadioButton.Checked)
            {
                return 0.45;
            }
            else
            {
                return 0;
            }
        }

        // Calculates the total cost to ship a parcel using specific configuration
        private double getPostageCost(double postageMultiplier, int volume)
        {
            double cost;

            cost = volume * postageMultiplier;
            return cost;
        }

        // Displays shipping info to user
        private void displayShippingInfo(double postageCost)
        {
            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship. Thanks for using the Postal Calculator!", postageCost);
        }
    }
}