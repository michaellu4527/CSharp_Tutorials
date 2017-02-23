using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_046
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            Car car1 = new Car("Ferrari", "460 Spyder", 2017, "Crimson Red");
            Car car2 = new Car("Mercedes", "CLK GTR", 2017, "Silver");
            Car car3 = new Car("Lamborghini", "Avantado", 2017, "Black");

            List<Car> cars = new List<Car>();

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            List<Car> silverCars = cars.FindAll(p => p.Color == "Silver");

            for (int i = 0; i < silverCars.Count; i++)
            {
                result += silverCars.ElementAt(i).FormatDetailsForDisplay();
            }

            resultLabel.Text = result;
        }
    }
}