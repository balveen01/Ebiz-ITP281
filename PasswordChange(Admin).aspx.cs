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

public partial class PasswordChange_Admin_ : System.Web.UI.Page
{
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

        string checkpass = "SELECT password from [Staff] where staff_id = '" + username + "'";
        //SqlConnection conn = new SqlConnection(con);
        SqlCommand cdd = new SqlCommand();

        SqlCommand query = new SqlCommand(checkpass, conn);
        SqlDataReader dr = query.ExecuteReader();
        if (dr.Read())
        {
            string password = dr["password"].ToString();

            if (password == tb_passwordold.Text)
            {
                if (tb_password.Text == tb_password2.Text)
                {
                    conn.Close();
                    conn.Open();
                    cmd.CommandText = "Update [Staff] set password = '" + tb_password.Text + "' where staff_id = '" + username + "'";

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Updated!');window.location ='Logout(Admin).aspx';",
                   true);
                    //Response.Write("<script>alert('Updated!');</script>");
                    //Response.Redirect("Logout(Admin).aspx");
                }
                else
                {
                    //lbl_result.Text = "New Password is not the same as Confrim New Password. Please try again";
                    Response.Write("<script> alert('New Password is not the same as Confirm New Password. Please try again'); </script>");
                }
            }
            else
            {
                //lbl_result.Text = "Old Password is incorrect. Please try again";
                Response.Write("<script> alert('Old Password is incorrect. Please try again'); </script>");
            }

            
        }
    }

    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Logout(Admin).aspx");
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