using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_043
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Car myCar = new Car();  // Default constructor method 
            Car myCar = new Car("Ferrari", "Enzo", 2017, "Blue");   // Using overloaded constructor
            resultLabel.Text = myCar.FormatDetailsForDisplay();

            DateTime d = new DateTime();
        }
    }
}