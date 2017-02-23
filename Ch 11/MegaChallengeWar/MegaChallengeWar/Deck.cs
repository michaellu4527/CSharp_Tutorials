using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        private List<Card> _deck;
        private Random _random;
        private StringBuilder _sb;

        public Deck()
        {

            //// NO this would take 52 lines...
            //_deck = new List<Card>()
            //{
            //    new Card { Suit = "Heart", Rank = "Ace"} // ...
            //};

            _deck = new List<Card>();
            _random = new Random();
            _sb = new StringBuilder();

            string[] suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    _deck.Add(new Card() { Suit = suit, Rank = rank });
                }
            }
        }

        public string Deal(Player player1, Player player2, Player player3, Player player4)
        {
            while(_deck.Count > 0)
            {
                // Deal card to each player randomly
                dealCard(player1);
                dealCard(player2);
                dealCard(player3);
                dealCard(player4);
            }
            return _sb.ToString();
        }

        public void dealCard(Player player)
        {
            // Getting card from deck, adding it to player's hand and removing it from the deck
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            // Formatting output displayed on screen
            _sb.Append("<br />");
            _sb.Append(player.Name);
            _sb.Append(" is dealt the ");
            _sb.Append(card.Rank);
            _sb.Append(" of ");
            _sb.Append(card.Suit);
            _sb.Append(".");
            _sb.Append("<br />");
        }
    }
}