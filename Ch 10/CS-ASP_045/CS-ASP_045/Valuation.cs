using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_045
{
    public static class Valuation
    {
        // You canNOT have instance members (this) in static classes
        // Essentially NEVER mix instance members with static members
        /*
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */

        public static int PerformCalculation(int one, int two)
        {
            //return one + two;
            return handleSomePartOfTheCalculation(one, two);
        }

        // Must mark helper methods that are being used as static as well
        private static int handleSomePartOfTheCalculation(int one, int two)
        {
            return one + two;
        }


    }
}