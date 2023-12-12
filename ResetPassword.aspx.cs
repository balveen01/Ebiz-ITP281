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


public partial class ResetPassword : System.Web.UI.Page
{
    String encrypwd;

    protected void Page_Load(object sender, EventArgs e)
    {
        string Password = tb_password.Text;
        tb_password.Attributes.Add("value", Password);
        string Password2 = tb_password2.Text;
        tb_password2.Attributes.Add("value", Password2);


        //string token = null;
        string token = Request.QueryString["token"].ToString();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string myquery = "Select token, user_id, startdatetime from [FgtPassword] where token = '" + token + "'";
        SqlCommand cmd = new SqlCommand();
        SqlCommand query = new SqlCommand(myquery, con);
        SqlDataReader dr = query.ExecuteReader();


        if (dr.Read())
        {
            var startdate = Convert.ToDateTime(dr["startdatetime"]);
            if (DateTime.Now > startdate.Date.AddDays(1))
            {
                Response.Redirect("ResetPasswordExpire.aspx");
            }
            else
            {
                lbl_username.Text = dr["user_id"].ToString();
            }
        }
    }


    protected void btn_resetpassword_Click(object sender, EventArgs e)
    {
        if (tb_password.Text == tb_password2.Text)
        {
            String _connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
            encryption1();
            String myquery = "Update [User] set password = '" + encrypwd + "' where user_id = '" + lbl_username.Text + "'";
            SqlConnection con = new SqlConnection(_connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            //lbl_result.Text = "Updated!";
            //Response.Write("<script> alert('Updated!')</script>");
            ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Updated!');window.location ='Login(User).aspx';",
                   true);

        }
        else
        {
            //lbl_result.Text = "New Password is not the same as Confirm New Password. Please try again";
            Response.Write("<script> alert('New Password is not the same as Confirm New Password. Please try again'); </script>");
            
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