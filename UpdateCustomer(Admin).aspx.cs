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

public partial class UpdateCustomer_Admin_ : System.Web.UI.Page
{
    Customer aUser = new Customer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl_userid.Text = Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
            con.Open();
            string q = "Select user_id, email, address, phone_number, month, gender, email_status from [User] where user_id = '" + lbl_userid.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                tb_email.Text = dr["email"].ToString();
                tb_address.Text = dr["address"].ToString();
                tb_phoneno.Text = dr["phone_number"].ToString();
                ddl_month.Text = dr["month"].ToString();
                ddl_gender.Text = dr["gender"].ToString();
                ddl_verification.Text = dr["email_status"].ToString();
            }
            con.Close();
        }
    }



    protected void btn_update_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string q = "Select user_id, email, address, phone_number, month, gender, email_status from [User] where user_id = '" + lbl_userid.Text + "'";

        SqlCommand query = new SqlCommand(q, con);
        SqlDataReader dr = query.ExecuteReader();

        if (dr.Read())
        {
            if (String.IsNullOrEmpty(tb_email.Text))
            {
                tb_email.Text = dr["email"].ToString();
            }
            if (String.IsNullOrEmpty(tb_address.Text))
            {
                tb_address.Text = dr["address"].ToString();
            }
            if (String.IsNullOrEmpty(tb_phoneno.Text))
            {
                tb_phoneno.Text = dr["phone_number"].ToString();
            }
            if (ddl_gender.SelectedIndex == 0)
            {
                ddl_gender.Text = dr["gender"].ToString();
            }
            if (ddl_month.SelectedIndex == 0)
            {
                ddl_month.Text = dr["month"].ToString();
            }
            if (ddl_verification.SelectedIndex == 0)
            {
                ddl_verification.Text = dr["email_status"].ToString();
            }
        }
        int result = 0;
        Customer user = new Customer();


        result = user.CustomerUpdate(lbl_userid.Text, tb_email.Text, tb_address.Text, tb_phoneno.Text, ddl_month.Text, ddl_gender.Text, ddl_verification.Text);
        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Customer Edited');window.location ='Customer(Admin).aspx';",
                   true);
            //Response.Redirect("Customer(Admin).aspx");
        }
        else
        {
            //lbl_result.Text = "User update NOT successful";
            Response.Write("<script>alert('User update NOT successful');</script>");
        }
    }
}