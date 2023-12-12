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
using System.Text;

public partial class Login : System.Web.UI.Page
{
    static String decryptedpwd;
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        string Password = tb_password.Text;
        tb_password.Attributes.Add("value", Password);
    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();
        string checkuser = "SELECT count(*) from [User] where user_id = '" + tb_username.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        int userno = Convert.ToInt32(com.ExecuteScalar().ToString());

        string checkstaff = "SELECT count(*) from Staff where staff_id = '" + tb_username.Text + "'";
        SqlCommand comm = new SqlCommand(checkstaff, conn);
        int staffno = Convert.ToInt32(comm.ExecuteScalar().ToString());
        conn.Close();

        if (staffno == 1)
        {
            conn.Open();
            string checkPass = "SELECT password, nric from Staff where staff_id = '" + tb_username.Text + "'";
            SqlCommand passcomm = new SqlCommand(checkPass, conn);
            SqlDataReader dr = passcomm.ExecuteReader();
            if (dr.Read())
            {
                string password = dr["password"].ToString();
                string nric = dr["nric"].ToString();





                //string password = passcomm.ExecuteScalar().ToString().Replace(" ", "");
                //string nric = passcomm.ExecuteScalar().ToString().Replace(" ", "");
                if (password == tb_password.Text)
                {
                    if (tb_password.Text == nric)
                    {
                        Session["Username"] = tb_username.Text;
                        Response.Redirect("ChangePassword(Admin).aspx");
                    }
                    Session["Username"] = tb_username.Text;
                    Response.Redirect("Innerpage(Admin).aspx");
                }
                else
                {
                    //lbl_result.Text = "Password is incorrect. Please try again";
                    Response.Write("<script> alert('Password is incorrect. Please try again'); </script>");
                }
            }
        }
        else if (userno == 1)
        {
            conn.Open();
            //string checkpass = "SELECT password from [User] where user_id = '" + tb_username.Text + "'";
            //SqlCommand passComm = new SqlCommand(checkpass, conn);
            //string password = passComm.ExecuteScalar().ToString().Replace(" ", "");



            string checkpass = "SELECT password from [User] where user_id = '" + tb_username.Text + "'";
            //SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand();

            SqlCommand query = new SqlCommand(checkpass, conn);
            SqlDataReader dr = query.ExecuteReader();
            if (dr.Read())
            {
                string password = dr["password"].ToString();

                decryptpwd(password);

                if (decryptedpwd == tb_password.Text)
                {
                    Session["Username"] = tb_username.Text;
                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    //lbl_result.Text = "Password is incorrect. Please try again";
                    Response.Write("<script> alert('Password is incorrect. Please try again'); </script>");

                }
            }
        }
        else
        {
            //lbl_result.Text = "Username is incorrect. Please try again";
            Response.Write("<script>alert('Username is incorrect. Please try again'); </script>");
        }
        conn.Close();
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


    protected void btn_createAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
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
}