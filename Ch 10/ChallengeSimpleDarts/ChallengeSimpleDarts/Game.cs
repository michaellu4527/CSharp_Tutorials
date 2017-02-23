using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player();
            _player1.Name = player1Name;

            _player2 = new Player();
            _player2.Name = player2Name;

            _random = new Random();
        }

        public string Play1()
        {
            if (_player1.Score < 300 && _player2.Score < 300)
            {
                playRound(_player1);
            }
            return displayResults1();
        }

        public string Play2()
        {
            if (_player1.Score < 300 && _player2.Score < 300)
            {
                playRound(_player2);
            }
            return displayResults2();
        }

        private string displayResults1()
        {
            string result = String.Format("{0}: {1}<br />", 
                _player1.Name,
                _player1.Score);

            if (isWinner() == true)
            {
                return result += "<br />Winner: " + displayWinner() + "<br />";
            }
            else
            {
                return result;
            }
        }

        private bool isWinner()
        {
            if (_player1.Score < 300 && _player2.Score < 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string displayResults2()
        {     
            string result = String.Format("{0}: {1}<br />",
                _player2.Name,
                _player2.Score);

            if (isWinner() == true)
            {
                return result += "<br />Winner: " + displayWinner() + "<br />";
            }
            else
            {
                return result;
            }
        }

        private string displayWinner()
        {
            string winner;

            if (_player1.Score > _player2.Score)
            {
                winner = _player1.Name;
            }
            else
            {
                winner = _player2.Name;
            }
            return "<br />Winner: " + winner;
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();

                Score.ScoreDart(player, dart);
            }
        }
    }
}