using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GlobalExceptionHandling
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }
        void Application_Error(object sender, EventArgs e)
        {
            // Ask what just happened?
            Exception ex = Server.GetLastError();

            var innerException = ex.InnerException;

            if (innerException.GetType() == typeof(ArgumentOutOfRangeException))
            {
                Server.Transfer("Error.aspx");
            }

            Response.Write("<h2>Something bad happened....</h2>");
            Response.Write("<p>" + innerException.Message + "</p>");

            // YOU MUST DO THIS if you want to hide the yellow page of death, any existing exceptions after this point
            // will send the end user the exception page
            Server.ClearError();
        }
    }
}