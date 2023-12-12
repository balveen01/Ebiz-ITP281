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

public partial class SignUpVerfication_User_ : System.Web.UI.Page
{
    static string activicationcode;
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_emailver.Text = "The verification code has been sent to " + Request.QueryString["email"].ToString() + ". Kindly check you email address and enter the verfication code";
    }

    

    protected void btn_verify_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string myquery = "Select email_status, email_code from [User] where email = '" + Request.QueryString["email"] + "'";
        //SqlConnection conn = new SqlConnection(con);
        SqlCommand cmd = new SqlCommand();
        
        SqlCommand query = new SqlCommand(myquery, con);
        SqlDataReader dr = query.ExecuteReader();

        if (dr.Read())
        {
            string code = dr["email_code"].ToString();
            if (code == tb_code.Text)
            {
                changestatus();
                ScriptManager.RegisterStartupScript
                    (this, this.GetType(),
                    "alert",
                    "alert('Your Email Has Been Verified Successfully');window.location ='Login(User).aspx';",
                    true);
                //lbl_responsegood.Text = "Your Email Has Been Verified Successfully";
            }
            else
            {
                Response.Write("<script>alert('Your verification code is wrong');</script>");
                //lbl_responsebad.Text = "Your Verification Code is wrong";
            }
        }
        con.Close();

        //cmd.CommandText = myquery;
        //cmd.Connection = con;
        //SqlDataAdapter da = new SqlDataAdapter();
        //da.SelectCommand = cmd;
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //String activicationcode;
        //activicationcode = ds.Tables[0].Rows[0]["activicationcode"].ToString();
        //if (activicationcode == tb_code.Text)
            //{
                //changestatus();
                //lbl_response.Text = "Your Email Has Been Verified Successfully";
            //}
            //else
            //{
                //lbl_response.Text = "You Have entered Invalid Activation Code. Kindly Check Your Mail Inbox ";
            //}
        //}
    }

    private void changestatus()
    {
        String _connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
        String myquery = "Update [User] set email_status='Verified' where email = '" + Request.QueryString["email"] + "'";
        SqlConnection con = new SqlConnection(_connStr);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
    }

    protected void btn_change_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerificationEmailChange(User).aspx");
    }
}