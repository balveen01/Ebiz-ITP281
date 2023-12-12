//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;

public partial class EmailDashboard_User_ : System.Web.UI.Page
{
    static string activicationcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btn_change_Click(object sender, EventArgs e)
    {
        string username = null;
        username = (string)Session["Username"];
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Update [User] set email = '" + tb_email.Text + "' where user_id = '" + username + "'";
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script>alert('Updated!');</script>");

        Random random = new Random();

        activicationcode = random.Next(1001, 9999).ToString();
        sendcode();

        conn.Open();
        SqlCommand cd = conn.CreateCommand();
        cd.CommandType = CommandType.Text;
        cd.CommandText = "Update [User] set email_code = '" + activicationcode + "' where user_id = '" + username + "'";
        cd.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("ValidateNewEmail(User).aspx?email=" + tb_email.Text);
    }

    private void sendcode()
    {
        string username = null;
        username = (string)Session["Username"];
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("partietycompany@gmail.com", "!123Party");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = "Activication Code to Verify Email Address";
        msg.Body = "Dear " + username + ", Your activication Code is  " + activicationcode + "\n\n\nThanks & Regards\nPartiety";
        string toaddress = tb_email.Text;
        msg.To.Add(toaddress);
        string fromaddress = "Partiety <partietycompany@gmail.com>";
        msg.From = new MailAddress(fromaddress);
        try
        {
            smtp.Send(msg);


        }
        catch
        {
            throw;
        }
    }

    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard(User).aspx");
    }
}