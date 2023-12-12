//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public partial class SignUp : System.Web.UI.Page
{
    static string activicationcode;
    String encrypwd;
    protected void Page_Load(object sender, EventArgs e)
    {
        string Password = tb_password.Text;
        tb_password.Attributes.Add("value", Password);
        string Password2 = tb_password2.Text;
        tb_password2.Attributes.Add("value", Password2);
    }

    protected void btn_signup_Click(object sender, EventArgs e)
    {


        int result = 0;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();
        string checkuser = "SELECT count(*) from [User] where user_id = '" + tb_username.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

        string checkstaff = "SELECT count(*) from [Staff] where staff_id = '" + tb_username.Text + "'";
        SqlCommand comm = new SqlCommand(checkstaff, conn);
        int temps = Convert.ToInt32(comm.ExecuteScalar().ToString());

        if (temp == 1 || temps == 1)
        {
            lbl_repsonse.Text = "Username is taken.Please choose another username";
            lbl_username.Text = "*";
            //Response.Write("<script>alert('Username is taken. Please choose another username');</script>");
        }
        //if (temps == 1)
        //{
            //lbl_repsonse.Text = "Username is taken.Please choose another username";
            //lbl_username.Text = "*";
            //Response.Write("<script>alert('Username is taken. Please choose another username');</script>");
        //}
        else
        {
            if (tb_password.Text == tb_password2.Text)
            {
                Random random = new Random();

                activicationcode = random.Next(1001, 9999).ToString();
                sendcode();
                encryption1();
                Customer user = new Customer(tb_username.Text, tb_email.Text, tb_address.Text, encrypwd, tb_phoneno.Text, ddl_month.Text, rb_gender.Text, "Unverified", activicationcode);
                result = user.CustomerInsert();
                if (result > 0)
                {                    
                    Response.Redirect("SignUpVerification(User).aspx?email=" + tb_email.Text);
                }
                else
                {
                    //Response.Write("<script>alert('SignUp NOT Successful');</script>");
                    lbl_repsonse.Text = "SignUp NOT successful";
                    //Response.Write("<script>alert('SignUp NOT successful');</script>");
                }
            }
            else
            {
                //Response.Write("<script>alert(Password isnt the same. Please try again.);</script>");
                lbl_repsonse.Text = "Password isnt the same. Please try again.";
                lbl_password1.Text = "*";
                lbl_password2.Text = "*";
                //Response.Write("<script>alert(Password isn't the same. Please try again);</script>");
                //Response.Write("<script>alert('Password isn't the same. Please try again.');</script>");
            }
        }
    }

    private void sendcode()
    {
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("partietycompany@gmail.com", "!123Party");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = "Activication Code to Verify Email Address";
        msg.Body = "Dear " + tb_username.Text + ", Your activication Code is  " + activicationcode + "\n\n\nThanks & Regards\nPartiety";
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

    public void encryption1()
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[tb_password.Text.ToString().Length];
        encode = Encoding.UTF8.GetBytes(tb_password.Text);
        strmsg = Convert.ToBase64String(encode);
        encrypwd = strmsg;
    }

    protected void cb_see_CheckedChanged(object sender, EventArgs e)
    {
        if (cb_see.Checked)
        {
            tb_password.TextMode = TextBoxMode.SingleLine;
        }
        else
        {
            tb_password.TextMode = TextBoxMode.Password;
        }
    }

    protected void cb_see2_CheckedChanged(object sender, EventArgs e)
    {
        if (cb_see2.Checked)
        {
            tb_password2.TextMode = TextBoxMode.SingleLine;
        }
        else
        {
            tb_password2.TextMode = TextBoxMode.Password;
        }
    }
}