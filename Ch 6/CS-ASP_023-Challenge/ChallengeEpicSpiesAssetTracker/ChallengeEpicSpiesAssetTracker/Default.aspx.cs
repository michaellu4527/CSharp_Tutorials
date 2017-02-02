using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] subterfuge = new int[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Subterfuge", subterfuge);
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            // We need Sum, Average, return last index
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] subterfuge = (int[])ViewState["Subterfuge"];

            // Resizing array by 1 every time a user clicks on button
            int newLength = assets.Length + 1;
            Array.Resize(ref assets, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref subterfuge, newLength);

            // Obtaining number of last index
            int lastIndex = assets.GetUpperBound(0);

            // Storing value that user enters into text boxes into array
            assets[lastIndex] = assetNameTextBox.Text;
            elections[lastIndex] = int.Parse(electionsRiggedTextBox.Text);
            subterfuge[lastIndex] = int.Parse(subterfugeTextBox.Text);

            // Need to add everything back to viewstate
            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Subterfuge"] = subterfuge;

            // Outputting to results label
            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />Last Asset you Added: {2}", 
                elections.Sum(), 
                subterfuge.Average(),
                assets[lastIndex]);
        }
    }
}