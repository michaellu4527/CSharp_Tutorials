using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Michael Lu";
            // In my case, the result would be:
            // robaT boB

            for (int i = name.Length-1; i>=0; i--)
            {
                resultLabel.Text += name[i];
            }

            // 2.  Reverse this sequence:
           //string names = "Michael,Arrrr,Yoda,Chewbacca";
           // // When you're finished it should look like this:
           // // Michael, Arrrr, Yoda, Chewbacca, 

           // // Creates array with each name separated
           // string[] individualNames = names.Split(',');
           // string result = "";

           // // Inserting commas between names
           // for (int i = individualNames.Length - 1; i >= 0; i--)
           // {
           //     result += individualNames[i] + ", ";
           // }

           // // Removing trailing comma at the end
           // // NOTE: Remove starts at an index and deletes to the RIGHT NOT left
           // result = result.Remove(result.Length-2, 1);
           // resultLabel.Text = result;



            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            //Creates array with each name separated
            //string[] individualNames = names.Split(',');
            //string result = "";

            //// Inserting commas between names
            //for (int i = 0; i < individualNames.Length; i++)
            //{
            //    // Find total length you want each line (14), subtract out the name, then divide by 2
            //    // for even split on each side
            //    int padLeft = (14 - individualNames[i].Length) / 2;

            //    // First argument is totalWidth, second argument is what you want to replace it with
            //    // The string looks something like this right now: ****Luke
            //    string temp = individualNames[i].PadLeft(individualNames[i].Length + padLeft, '*');

            //    // Pad the right with the rest of the '*'. Total length is 14.
            //    result += temp.PadRight(14, '*');

            //    result += "<br />";
            //}
            //resultLabel.Text = result;


            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);

            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');

            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            
            resultLabel.Text = puzzle;

        }
    }
}