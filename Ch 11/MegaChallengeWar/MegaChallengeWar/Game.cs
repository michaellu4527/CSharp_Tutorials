using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        private Player player1;
        private Player player2;
        private Player player3;
        private Player player4;

        public Game(string player1Name, string player2Name, string player3Name, string player4Name)
        {
            player1 = new Player() { Name = player1Name };
            player2 = new Player() { Name = player2Name };
            player3 = new Player() { Name = player3Name };
            player4 = new Player() { Name = player4Name };
        }

        public string Play()
        {
            Deck deck = new Deck();
            string result = "<h3>Dealing cards...</h3>";
            result += deck.Deal(player1, player2, player3, player4);

            result += "<h3>Begin battle!</h3>";
            int round = 0;
            while (player1.Cards.Count != 0 && player2.Cards.Count != 0 && player3.Cards.Count != 0 && player4.Cards.Count != 0)
            {
                Battle battle = new Battle();
                result += battle.PerformBattle(player1, player2, player3, player4);
                round++;
                if (round > 20)
                    break;
            }
            result += determineWinner();
            return result;
        }

        private string determineWinner()
        {
            string result = "";

            if (player1.Cards.Count > player2.Cards.Count && player1.Cards.Count > player3.Cards.Count && player1.Cards.Count > player4.Cards.Count)
            {
                result += "<br/><span style='color:red;font-weight:bolder'>Player 1 wins!</span><br/>";
            }
            else if (player2.Cards.Count > player1.Cards.Count && player2.Cards.Count > player3.Cards.Count && player2.Cards.Count > player4.Cards.Count)
            {
                result += "<br/><span style='color:blue;font-weight:bolder'>Player 2 wins!</span><br/>";
            }
            else if (player3.Cards.Count > player1.Cards.Count && player3.Cards.Count > player2.Cards.Count && player3.Cards.Count > player4.Cards.Count)
            {
                result += "<br/><span style='color:green;font-weight:bolder'>Player 3 wins!</span><br/>";
            }
            else if (player4.Cards.Count > player1.Cards.Count && player4.Cards.Count > player2.Cards.Count && player4.Cards.Count > player3.Cards.Count)
            {
                result += "<br/><span style='color:purple;font-weight:bolder'>Player 4 wins!</span><br/>";
            }           
            else
                result += "<br/><span style='color:red;font-weight:bolder;'>Unfortunately, there is no winner. Please play again!</span><br/>";


            result += "<br/><span style='color:red;font-weight:bolder'>Player 1: " + player1.Cards.Count + "</span><br/><span style='color:blue;font-weight:bolder'>Player 2: " + player2.Cards.Count + "</span><br/><span style='color:green;font-weight:bolder'>Player 3: " + player3.Cards.Count + "</span><br/><span style='color:purple;font-weight:bolder'>Player 4: " + player4.Cards.Count + "</span>";

            return result;
        }
    }
}