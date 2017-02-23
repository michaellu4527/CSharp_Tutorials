using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;

            if (dart.IsTriple) {
                score = dart.Score * 3;
            }
            else if (dart.IsDouble) {
                score = dart.Score * 2;
            }
            else {
                score = dart.Score;
            }

            if (dart.IsTriple && dart.Score == 0)   // Inner bullseye (using the IsTriple property for bullseye as well)
            {
                score = 50;
            }
            else if (dart.Score == 0)   // Outer bullseye
            {
                score = 25;
            }

            player.Score += score;
        }

    }
}