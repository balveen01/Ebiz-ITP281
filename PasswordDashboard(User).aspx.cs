//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Text;



public partial class PasswordDashboard_User_ : System.Web.UI.Page
{
    static String decryptedpwd;
    String encrypwd;


    protected void Page_Load(object sender, EventArgs e)
    {
        string Password = tb_passwordold.Text;
        tb_passwordold.Attributes.Add("value", Password);
        string Password2 = tb_password.Text;
        tb_password.Attributes.Add("value", Password2);
        string password = tb_password2.Text;
        tb_password2.Attributes.Add("value", password);
    }

    protected void btn_change_Click(object sender, EventArgs e)
    {
        string username = null;
        username = (string)Session["Username"];
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandType = CommandType.Text;

        string checkpass = "SELECT password from [User] where user_id = '" + username + "'";
        //SqlConnection conn = new SqlConnection(con);
        SqlCommand cdd = new SqlCommand();

        SqlCommand query = new SqlCommand(checkpass, conn);
        SqlDataReader dr = query.ExecuteReader();
        if (dr.Read())
        {
            string password = dr["password"].ToString();

            decryptpwd(password);

            if (decryptedpwd == tb_passwordold.Text)
            {
                if (tb_password.Text == tb_password2.Text)
                {
                    conn.Close();
                    conn.Open();
                    encryption1();
                    cmd.CommandText = "Update [User] set password = '" + encrypwd + "' where user_id = '" + username + "'";

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    //Response.Write("<script type='text/javascript' language='javascript'> alert('Updated!')</script>");
                    //Response.Write("<script> alert('Updated!'); </script>");
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Updated!');window.location ='Dashboard(User).aspx';",
                        true);
                    //Response.Redirect("Dashboard(User).aspx");
                }
                else
                {
                    //lbl_result.Text = "New Password is not the same as Confirm New Password. Please try again";
                    Response.Write("<script> alert('New Password is not the same as Confirm New Password. Please try again'); </script>");
                }
            }
            else
            {
                //lbl_result.Text = "Old Password is incorrect. Please try again.";
                Response.Write("<script> alert('Old Password is incorrect. Please try again'); </script>");
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

    public void encryption1()
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[tb_password.Text.ToString().Length];
        encode = Encoding.UTF8.GetBytes(tb_password.Text);
        strmsg = Convert.ToBase64String(encode);
        encrypwd = strmsg;
    }


    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard(User).aspx");
    }

    protected void cb_seeold_CheckedChanged(object sender, EventArgs e)
    {
        if (cb_seeold.Checked)
        {
            tb_passwordold.TextMode = TextBoxMode.SingleLine;
        }
        else
        {
            tb_passwordold.TextMode = TextBoxMode.Password;
        }
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