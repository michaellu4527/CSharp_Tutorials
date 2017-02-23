using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar
{
    public class Battle
    {
        private List<Card> _bounty;
        private StringBuilder _sb;

        public Battle()
        {
            _bounty = new List<Card>();
            _sb = new StringBuilder();
        }


        public string PerformBattle(Player player1, Player player2, Player player3, Player player4)
        {
            Card player1Card = GetCard(player1);
            Card player2Card = GetCard(player2);
            Card player3Card = GetCard(player3);
            Card player4Card = GetCard(player4);

            determineResult(player1, player2, player3, player4, player1Card, player2Card, player3Card, player4Card);
            return _sb.ToString();
        }

        private Card GetCard(Player player)
        {
            Card card = player.Cards.ElementAt(0);
            player.Cards.Remove(card);
            _bounty.Add(card);
            return card;
        }

        private void determineResult(Player player1, Player player2, Player player3, Player player4,
            Card card1, Card card2, Card card3, Card card4)
        {
            displayBattleCards(card1, card2, card3, card4);
            // If any of the cards are equal to one another...then WAR
            if (card1.CardValue() == card2.CardValue() || card1.CardValue() == card2.CardValue() || card3.CardValue() == card4.CardValue() || card2.CardValue() == card3.CardValue() || card2.CardValue() == card4.CardValue() ||  card3.CardValue() == card4.CardValue())
            {
                War(player1, player2, player3, player4);
            }

            // If Player1 has highest card, give him all the cards
            if (card1.CardValue() > card2.CardValue() && card1.CardValue() > card3.CardValue() && card1.CardValue() > card4.CardValue())
            {
                 awardWinner(player1);           
            }
            // If Player2 has highest card, give him all the cards
            else if (card2.CardValue() > card1.CardValue() && card2.CardValue() > card3.CardValue() && card2.CardValue() > card4.CardValue())
            {
                 awardWinner(player2);
            }
            else if (card3.CardValue() > card1.CardValue() && card3.CardValue() > card2.CardValue() && card3.CardValue() > card4.CardValue())
            {
                 awardWinner(player3);
            }
            else
            {
                 awardWinner(player4);
            }
            _bounty.Clear();
        }

        private void awardWinner(Player player)
        {
            if (_bounty.Count == 0)
                return;
            displayBountyCards();
            player.Cards.AddRange(_bounty);
            _bounty.Clear();

            _sb.Append("<br/><strong>");
            _sb.Append(player.Name);
            _sb.Append(" wins!</strong><br/>");
        }

        private void War(Player player1, Player player2, Player player3, Player player4)
        {
            _sb.Append("<br />**********************WAR***********************<br />");
            GetCard(player1);
            Card warCard1 = GetCard(player1);
            GetCard(player1);

            GetCard(player2);
            Card warCard2 = GetCard(player2);
            GetCard(player2);

            GetCard(player3);
            Card warCard3 = GetCard(player3);
            GetCard(player3);

            GetCard(player4);
            Card warCard4 = GetCard(player4);
            GetCard(player4);

            determineResult(player1, player2, player3, player4, warCard1, warCard2, warCard3, warCard4);
        }

        private void displayBattleCards(Card card1, Card card2, Card card3, Card card4)
        {
            _sb.Append("<br/>Battle Cards: ");
            _sb.Append(card1.Rank);
            _sb.Append(" of ");
            _sb.Append(card1.Suit);
            _sb.Append(" vs. ");

            _sb.Append(card2.Rank);
            _sb.Append(" of ");
            _sb.Append(card2.Suit);
            _sb.Append(" vs. ");

            _sb.Append(card3.Rank);
            _sb.Append(" of ");
            _sb.Append(card3.Suit);
            _sb.Append(" vs. ");

            _sb.Append(card4.Rank);
            _sb.Append(" of ");
            _sb.Append(card4.Suit);
        }

        private void displayBountyCards()
        {
            _sb.Append("<br/>Bounty... ");
            foreach (var card in _bounty)
            {
                _sb.Append("<br/>&nbsp;&nbsp&nbsp&nbsp");
                _sb.Append(card.Rank);
                _sb.Append(" of ");
                _sb.Append(card.Suit);
            }
           
        }
    }
}