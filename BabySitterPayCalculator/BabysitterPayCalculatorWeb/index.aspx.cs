using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BabysitterPayCalculator;

namespace BabysitterPayCalculatorWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Babysitter Calculator = new Babysitter(12, 8, 16);

        protected void Page_Load(object sender, EventArgs e)
        {
            HideResults();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var startHour = int.Parse(StartTimeList.SelectedValue);
            var endHour = int.Parse(EndTimeList.SelectedValue);
            var bedHour = int.Parse(BedTimeList.SelectedValue);

            if(startHour >= endHour)
            {
                DisplayMsg("Start time must be before end time!");
            }
            else
            {
                var pay = Calculator.Calculate(startHour, endHour - startHour, bedHour);
                DisplayMsg($"${pay}");
            }
        }

        private void DisplayMsg(string message)
        {
            results.InnerHtml = message;
            ShowResults();
        }

        private void HideResults()
        {
            results.Visible = false;
        }

        private void ShowResults()
        {
            results.Visible = true;
        }

    }
}