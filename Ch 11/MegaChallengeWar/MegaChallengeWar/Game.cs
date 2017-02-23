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
            string result = deck.Deal(player1, player2, player3, player4);

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
                result += "<br/>Player 1 wins!";
            }
            else if (player2.Cards.Count > player1.Cards.Count && player2.Cards.Count > player3.Cards.Count && player2.Cards.Count > player4.Cards.Count)
            {
                result += "<br/>Player 2 wins!";
            }
            else if (player3.Cards.Count > player1.Cards.Count && player3.Cards.Count > player2.Cards.Count && player3.Cards.Count > player4.Cards.Count)
            {
                result += "<br/>Player 3 wins!";
            }
            else
                result += "<br/>Player 4 wins!";

            result += "<br/>Player 1: " + player1.Cards.Count + "<br/>Player 2: " + player2.Cards.Count + "<br/>Player 3: " + player3.Cards.Count + "<br/>Player 4: " + player4.Cards.Count;
            return result;
        }
    }
}