using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }

        private Random _random;
        
        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            Score = _random.Next(0, 21);    // Generates random number from 0 to 20

            int multiplier = _random.Next(1, 101);
            if (multiplier > 95) IsDouble = true;
            else if (multiplier > 90 && multiplier <= 95) IsTriple = true;

        }
    }
}