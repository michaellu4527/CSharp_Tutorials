using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_049
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            // Using object initializers

            //Dictionary<string, Car> cars = new Dictionary<string, Car>();
            //cars.Add("V1", new Car { Make = "BMW", Model = "528i", Year = 2010, Color = "Black" });
            //cars.Add("V2", new Car { Make = "Porsche", Model = "Carrera GT", Year = 2017, Color = "Black" });
            //cars.Add("V3", new Car { Make = "Audi", Model = "R8", Year = 2018, Color = "Red" });


            // Using collection initializers
            // Use commas to separate dictionary items
            Dictionary<string, Car> cars = new Dictionary<string, Car>() {
                { "V1", new Car { Make = "BMW", Model = "528i", Year = 2010, Color = "Black" } },
                { "V2", new Car { Make = "Porsche", Model = "Carrera GT", Year = 2017, Color = "Black" } },
                { "V3", new Car { Make = "Audi", Model = "R8", Year = 2018, Color = "Red" } }
            };

            // Removing an item from a dictionary
            if (cars.Remove("V1"))
            {
                result += "Successfully removed V1<br />";
            }

            for (int i = 0; i < cars.Count; i++)
            {
                result += "<h2>" + cars.ElementAt(i).Key + "</h2>"
                    + cars.ElementAt(i).Value.FormatDetailsForDisplay();
            }



            Car v2;

            if (cars.TryGetValue("V2", out v2))
                result += v2.FormatDetailsForDisplay();

            resultLabel.Text = result;
        }
    }
}