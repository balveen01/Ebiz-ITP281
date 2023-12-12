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
using System.Text;

public partial class FgtPassword_User_ : System.Web.UI.Page
{
    static string token;
    static String decryptedpwd;
    String encrypwd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_fgtpassword_Click(object sender, EventArgs e)
    {
        String password;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();

        String myquery = "Select * from [User] where email='" + tb_fgtemail.Text + "'";
        SqlCommand cmd = new SqlCommand();
        SqlCommand query = new SqlCommand(myquery, conn);
        SqlDataReader dr = query.ExecuteReader();

        //cmd.CommandText = myquery;
        //cmd.Connection = conn;
        //SqlDataAdapter da = new SqlDataAdapter();
        //da.SelectCommand = cmd;
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        if (dr.Read())
        {
            Random random = new Random();
            token = random.Next(1001, 9999).ToString();
            encryption1();

            string username = null;
            username = dr["user_id"].ToString();
            string email = null;
            email = dr["email"].ToString();
            if (email == tb_fgtemail.Text)
            {
                DateTime startdate = DateTime.Now;

                string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                string addtoken = "INSERT into FgtPassword(token, user_id, startdatetime) values('" + encrypwd + "' , '" + username + "', '" + startdate + "')";
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = addtoken;
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();

                string link = null;

                link = "http://localhost:2843/ResetPassword.aspx?email=" + tb_fgtemail.Text + "&token=" + encrypwd;
                //password = ds.Tables[0].Rows[0]["password"].ToString();
                //decryptpwd(password);

                sendpassword(link, tb_fgtemail.Text);
                ScriptManager.RegisterStartupScript
                       (this, this.GetType(),
                       "alert",
                       "alert('A link has been sent to your email to reset you password.');window.location ='Login(User).aspx';",
                       true);
                //lbl_info.Text = "Your Password Has Been Sent to Registered Email Address. Check Your Mail Inbox";
            }

        }
        else
        {
            Response.Write("<script>alert('Your Email is not registered');</script>");
            //lbl_info.Text = "Your Username is Not Valid or Email Not Registered";

        }

        conn.Close();
    }
    private void sendpassword(String link, String email)
    {
        String password;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();

        String myquery = "Select * from [User] where email='" + tb_fgtemail.Text + "'";
        SqlCommand cmd = new SqlCommand();
        SqlCommand query = new SqlCommand(myquery, conn);
        SqlDataReader dr = query.ExecuteReader();

        if (dr.Read())
        {
            string username = null;
            username = dr["user_id"].ToString();

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("partietycompany@gmail.com", "!123Party");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Forgot Password ( Partiety )";
            msg.Body = "Dear " + username + ", Please reset your Password  using this link: \n\n\n" + link + "\n\n\nThanks & Regards\nPartiety";
            string toaddress = tb_fgtemail.Text;
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
    }

    private void decryptpwd(String encrytpwd)
    {
        string decryptpwd = string.Empty;
        UTF8Encoding encodepwd = new UTF8Encoding();
        Decoder Decode = encodepwd.GetDecoder();
        byte[] todecode_byte = Convert.FromBase64String(encrytpwd);
        int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
        char[] decoded_char = new char[charCount];
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
        decryptpwd = new String(decoded_char);
        decryptedpwd = decryptpwd;

    }

    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login(User).aspx");
    }

    public void encryption1()
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[token.ToString().Length];
        encode = Encoding.UTF8.GetBytes(token);
        strmsg = Convert.ToBase64String(encode);
        encrypwd = strmsg;
    }
}