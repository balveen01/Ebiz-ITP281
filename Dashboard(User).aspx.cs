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
using System.Text;

public partial class Dashboard_User_ : System.Web.UI.Page
{
    static String decryptedpwd;
    protected void Page_Load(object sender, EventArgs e)
    {

        lbl_username.Text = (string)Session["Username"];
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string q = "Select email, password, address, phone_number, month, gender from [User] where user_id = '" + lbl_username.Text + "'";
        
        SqlCommand query = new SqlCommand(q, con);
        SqlDataReader dr = query.ExecuteReader();

        string password = null;

        if (dr.Read())
        {
            lbl_email.Text = dr["email"].ToString();
            password= dr["password"].ToString();
            decryptpwd(password);

            foreach (char ch in decryptedpwd.ToCharArray())
            {
                lbl_password.Text += "*";
            }
            lbl_address.Text = dr["address"].ToString();
            lbl_phoneno.Text = dr["phone_number"].ToString();
            lbl_month.Text = dr["month"].ToString();
            lbl_gender.Text = dr["gender"].ToString();
        }
        con.Close();
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

    protected void btn_logout_Click(object sender, EventArgs e)
    {
        Session.Remove("Username");
        Session.RemoveAll();
        Response.Redirect("Login(User).aspx");
    }

    protected void img_email_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("EmailDashboard(User).aspx");
    }

    protected void img_address_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("AddressDashboard(User).aspx");
    }

    protected void img_password_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("PasswordDashboard(User).aspx");
    }

    protected void img_phoneno_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("PhoneDashboard(User).aspx");
    }

    protected void btn_delivery_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeliveryTracking.aspx");
    }
}