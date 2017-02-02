using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                firstCalendar.SelectedDate = DateTime.Now.Date;
                secondCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                thirdCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }            
        }

        public void assignSpyButton_Click(object sender, EventArgs e)
        {
            double totalAmount = 0;

            // Making sure there is never a "negative" duration
            if (secondCalendar.SelectedDate > thirdCalendar.SelectedDate)
            {
                // Returns total number of days of mission
                TimeSpan totalDuration = secondCalendar.SelectedDate.Subtract(thirdCalendar.SelectedDate);
                // Spies cost $500 per day
                totalAmount = totalDuration.TotalDays * 500.0;
                if (totalDuration.TotalDays > 21)
                {
                    totalAmount += 1000.0;
                }
            }
            else
            {
                // Finding total duration of mission
                TimeSpan totalDuration = thirdCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate);
                totalAmount = totalDuration.TotalDays * 500.0;

                // Add to budget if mission extends past 1 week. 
                if (totalDuration.TotalDays > 21)
                {
                    totalAmount = totalDuration.TotalDays + 1000.0;
                }
            }

            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                // Making sure there is a 2 week gap between assignments.
                TimeSpan timeOff = firstCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate);
                // Print error message if not satisfied
                if (timeOff.TotalDays <= 14)
                {
                    resultLabel.Text = "ERROR: Must allow at least 2 weeks between previous and new assignment!";
                }
                // Diplay the budget
                else
                {
                    resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", spyCodeTextBox.Text, assignmentNameTextBox.Text, totalAmount);
                }
            }         
        }
    }
}