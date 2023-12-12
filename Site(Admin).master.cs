//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Site_Admin_ : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void About_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }

    protected void Staff_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staff.aspx");
    }

    protected void SR_Click(object sender, EventArgs e)
    {
        Response.Redirect("SR.aspx");
    }

    protected void faq_Click(object sender, EventArgs e)
    {
        Response.Redirect("Faq.aspx");
    }

    protected void feedback_Click(object sender, EventArgs e)
    {
        Response.Redirect("Feedback.aspx");
    }

    protected void review_Click(object sender, EventArgs e)
    {
        Response.Redirect("Review.aspx");
    }

    protected void fb_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://www.facebook.com/Partiety/?modal=admin_todo_tour");
    }

    protected void email_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect(string.Format("mailto:partietycompany@gmail.com"));
    }

    protected void twitter_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://twitter.com/Partiety1");
    }

    protected void insta_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://www.instagram.com/_partiety/");
    }

    protected void contact_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("tel:+6587494785");
    }

    protected void img_login_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Logout(Admin).aspx");
    }
}
