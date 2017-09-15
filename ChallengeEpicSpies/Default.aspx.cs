using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousEndCalendar.SelectedDate = DateTime.Now.Date;
                newStartCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                newEndCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            DateTime previousEnd = previousEndCalendar.SelectedDate;
            DateTime newStart = newStartCalendar.SelectedDate;
            DateTime newEnd = newEndCalendar.SelectedDate;
            TimeSpan breakTime = newStart.Subtract(previousEnd);
            TimeSpan projectTime = newEnd.Subtract(newStart);
            double ammount;
            string budget;

            //DETERMINES THE BUDGET
            if (projectTime.TotalDays < 22)
            {
                ammount = projectTime.TotalDays * 500;
                budget = ammount.ToString();
            }else
            {
                ammount = projectTime.TotalDays * 500 + 1000;
                budget = ammount.ToString();
            }

            //DETERMINES THE OUTPUT
            if (breakTime.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow two weeks between previous assignment and new assigment.";
            }
            else
            {
                //resultLabel.Text = budget;
                //double budget = double.Parse("78");
                string result = string.Format(
                    "Assignment of {0} to project: {1} is authorized. Budget total: {2:C}", 
                    codeNameTextBox.Text, assignmentTextBox.Text, budget);
                resultLabel.Text = result;
            }



        }
    }
}