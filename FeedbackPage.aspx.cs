using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;




public partial class FeedbackPage : System.Web.UI.Page
{

    Feedbacks aFeedback = new Feedbacks();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }

    }
    protected void bind()
    {
        List<Feedbacks> FeedbackList = new List<Feedbacks>();
        FeedbackList = aFeedback.getFeedbackAll();
        gv_Feedback.DataSource = FeedbackList;
        gv_Feedback.DataBind();
    }


    protected void gv_Feedback_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = gv_Feedback.SelectedRow;
        string Feedback_Id = row.Cells[0].Text;

    }

    protected void btn_Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }




    protected void btn_Search_Click(object sender, EventArgs e)
    {
        List<Feedbacks> FeedbackSearchList = new List<Feedbacks>();
        string fid = ddl_SearchRating.Text;
        FeedbackSearchList = aFeedback.getFeedbackSearch(fid);
        if (FeedbackSearchList.Count == 0)
        {
            lbl_Search.Text = "There is no Feedback with such Rating.";
            this.gv_Feedback.Visible = false;

            if (ddl_SearchRating.Text == "Please Select")
            {
                this.gv_Feedback.Visible = true;
                lbl_Search.Text = "";
                List<Feedbacks> FeedbackList = new List<Feedbacks>();
                FeedbackList = aFeedback.getFeedbackAll();
                gv_Feedback.DataSource = FeedbackList;
                gv_Feedback.DataBind();
            }
        }

        else
        {
            this.gv_Feedback.Visible = true;
            lbl_Search.Text = "";
            gv_Feedback.DataSource = FeedbackSearchList;
            gv_Feedback.DataBind();
        }

    }
}
