using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_026
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            //for(int i=0; i<10; i++)
            //{
            //    result += "<br />" + i.ToString();  // Prints out the value of i
            //}

            string[] names = new string[] { "Wolverine", "Cyclops", "Professor X", "Phoenix" };

            Array.Sort(names);
            Array.Reverse(names);

            //for (int i = 0; i < names.Length; i++)
            //{
            //    result += "<br />" + names[i];
            //}

            // Looping through the names array to find the index with Professor X
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Professor X")
                {
                    result = String.Format("{0} is at the index {1} in the list.", names[i], i);
                    break;  // We found him at this point, no need to continue...
                }
            }

            resultLabel.Text = result;
        }
    }
}

