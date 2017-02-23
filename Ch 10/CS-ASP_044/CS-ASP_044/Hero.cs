using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Class names are capitalized
// Public names are PascalCased
// Private names, function parameters, or local variables are camelCased
// If you need to use the same name for a different variable, use an underscore (_)

namespace CS_ASP_044
{
    public class Hero
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _hitPoints;
        public int HitPoints
        {
            get { return _hitPoints; }
            set { _hitPoints = value; }
        }

        public Hero(string name, int hitPoints)
        {
            _name = name;
            _hitPoints = hitPoints;
        }

    }
}