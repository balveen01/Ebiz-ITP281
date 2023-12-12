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

public partial class ContactUs_User_ : System.Web.UI.Page
{
    static String email;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Username"] != null)
            {
                tb_username.Text = (string)Session["Username"];
            }
            else
            {
                tb_username.Text = "";
            }
        }
    }

    private void sendmessage()
    {
        //string username = null;
        //username = (string)Session["Username"];
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("partietycompany@gmail.com", "!123Party");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = tb_subject.Text;
        msg.Body = "Username: " + tb_username.Text + "\n Email Address: " + email + "\n Query: " + tb_info.Text;
        string toaddress = "Partiety <partietycompany@gmail.com>";
        msg.To.Add(toaddress);
        string fromaddress = email;
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



    private void sendusermail()
    {
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("partietycompany@gmail.com", "!123Party");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = "[Recieved Request] - " + tb_subject.Text;
        msg.Body = "Dear " + tb_username.Text + ", \n We've received your support request. To update your case at any time, simply reply to this email. \n We know it takes time to plan a party, so we make every effort to reply quickly. However, due to high contact volume, we may need 2 or more days to respond. \n Need help fast? Your question might already have an answer. Take a look at the FAQ page " + "\n\n\nThanks & Regards\nPartiety";
        string toaddress = email;
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


    protected void btn_submit_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();
        string checkuser = "SELECT count(*) from [User] where user_id = '" + tb_username.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int userno = Convert.ToInt32(com.ExecuteScalar().ToString());

        conn.Close();

        if (userno == 1)
        {
            conn.Open();

            string checkpass = "SELECT email from [User] where user_id = '" + tb_username.Text + "'";
            SqlCommand cmd = new SqlCommand();
            SqlCommand query = new SqlCommand(checkpass, conn);
            SqlDataReader dr = query.ExecuteReader();
            if (dr.Read())
            {
                email = dr["email"].ToString();

                string _conn = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                string query1 = "INSERT INTO [ContactUs] (user_id, subject, email, comment) values ('" + tb_username.Text + "', '" + tb_subject.Text + "' , '" + email + "', '" + tb_info.Text + "')";
                SqlConnection con = new SqlConnection(_conn);
                con.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = query1;
                cmd2.Connection = con;
                cmd2.ExecuteNonQuery();

                sendmessage();
                sendusermail();
                ScriptManager.RegisterStartupScript
                          (this, this.GetType(),
                          "alert",
                          "alert('Your Message has been sent! Please check your email for further notice!');window.location ='ContactUs(User).aspx';",
                          true);
                //lbl_result.Text = "Your message has been sent";

            }
        }
        else
        {
            //lbl_result.Text = "Username is incorrect. Please try again";
            Response.Write("<script>alert('Username is does not exsist. Please enter a valid username'); </script>");
        }
        conn.Close();
    }
}