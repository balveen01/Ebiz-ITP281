using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecommendationQuestion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        string budget, capacity;

        // budget 
        if (rbl_Budget.SelectedItem != null )
        {
            budget = rbl_Budget.SelectedItem.Value;
        }
        else {
            lbl_budgeterror.Text = ("Please select an option on budget");
            return;
        }

        //number of ppl
        if (rbl_Ppl.SelectedItem != null)
        {
            capacity = rbl_Ppl.SelectedItem.Value;
        }
        else {
            lbl_pplerror.Text = ("Please select an option on number of people");
            return;
        }

        //theme


        string selectedValue = "";

        foreach (ListItem item in cbl_Theme.Items)
        {
            if (item.Selected)
            {
                selectedValue += item.Text;
              
            }

            /*          else
                      {
                          string message = "alert('" + "Please select an option on Theme." + "');";
                          ClientScript.RegisterStartupScript(this.GetType(), "Error_message", message, true);
                          return;
                      }*/
        }


        Response.Redirect("Recommendation.aspx?Unit_Price=" + budget + "&capacity=" + capacity + "&theme=" + cbl_Theme.Text);
    }
}