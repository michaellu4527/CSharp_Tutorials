using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Initializes set of reels when  you first run the program
                string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
                displayImages(reels);
                ViewState.Add("PlayersMoney", 100);
                displayPlayerMoney();
            }
        }

        private void displayPlayerMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet))
            {
                return;
            }
            int winnings = pullLever(bet);
            displayResult(bet, winnings);
            adjustPlayerMoney(bet, winnings);
            displayPlayerMoney();
        }

        private void adjustPlayerMoney(int bet, int winnings)
        {
            int playerMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playerMoney -= bet;
            playerMoney += winnings;
            ViewState["PlayersMoney"] = playerMoney;
        }

        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
            {
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            }
            else
            {
                resultLabel.Text = String.Format("Ouch...you lost {0:C}. Better luck next time!", bet);
            }
        }

        private string spinReel()
        {
            string[] images = new string[] { "bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermelon" };

            // 12 images so we want to randomize to index 11
            return images[random.Next(12)];
        }

        private int pullLever(int bet)
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
            displayImages(reels);

            int multiplier = evaluateSpin(reels);
            return bet * multiplier;
        }

        private void displayImages(string[] reels)
        {
            Image1.ImageUrl = "/Images/" + reels[0] + ".png";
            Image2.ImageUrl = "/Images/" + reels[1] + ".png";
            Image3.ImageUrl = "/Images/" + reels[2] + ".png";
        }

        private int evaluateSpin(string[] reels)
        {
            // If there's even 1 bar, then return 0
            if (isBar(reels))
            {
                return 0;
            }

            // If there's 3 7s return 100
            if (isJackpot(reels))
            {
                return 100;
            }

            // If there's 1 or more cherries, return 2,3,4
            if (cherryCount(reels) == 1)
            {
                return 2;
            }
            else if (cherryCount(reels) == 2)
            {
                return 3;
            }
            else if (cherryCount(reels) == 3)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        private bool isBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int cherryCount(string[] reels)
        {
            int cherryCount = 0;

            if (reels[0] == "Cherry")
            {
                cherryCount++;
            }
            if (reels[1] == "Cherry")
            {
                cherryCount++;
            }
            if (reels[2] == "Cherry")
            {
                cherryCount++;
            }
            return cherryCount;
        }
    }
}