//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Text;

public partial class Logout_Admin_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_username.Text = (string)Session["Username"];
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string q = "Select staff_id, name, gender, designation, nric, password from [Staff] where staff_id = '" + lbl_username.Text + "'";

        SqlCommand query = new SqlCommand(q, con);
        SqlDataReader dr = query.ExecuteReader();

        string password = null;
        if (dr.Read())
        {
            lbl_name.Text = dr["name"].ToString();
            lbl_gender.Text = dr["gender"].ToString();
            lbl_designation.Text = dr["designation"].ToString();
            lbl_nric.Text = dr["nric"].ToString();

            password = dr["password"].ToString();
            

            foreach (char ch in password.ToCharArray())
            {
                lbl_password.Text += "*";
            }
            
            
            
        }
        con.Close();

    }

    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("InnerPage(Admin).aspx");
    }

    protected void btn_logout_Click(object sender, EventArgs e)
    {
        Session.Remove("Username");
        Session.RemoveAll();
        Response.Redirect("Login(User).aspx");
    }


    protected void img_password_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("PasswordChange(Admin).aspx");
    }

   
}