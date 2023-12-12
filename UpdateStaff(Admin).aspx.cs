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

public partial class UpdateStaff_Admin_ : System.Web.UI.Page
{
    Staff aStaff = new Staff();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl_staffid.Text = Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
            con.Open();
            string q = "Select staff_id, name, gender, designation, nric from [Staff] where staff_id = '" + lbl_staffid.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                tb_name.Text = dr["name"].ToString();
                ddl_gender.Text = dr["gender"].ToString();
                ddl_designation.Text = dr["designation"].ToString();
                lbl_nric.Text = dr["nric"].ToString();
            }
            con.Close();
        }
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string q = "Select staff_id, name, gender, designation, nric from [Staff] where nric = '" + lbl_nric.Text + "'";

        SqlCommand query = new SqlCommand(q, con);
        SqlDataReader dr = query.ExecuteReader();

        if (dr.Read())
        {
            if (String.IsNullOrEmpty(tb_name.Text))
            {
                tb_name.Text = dr["name"].ToString();
            }
            if (ddl_gender.SelectedIndex == 0)
            {
                ddl_gender.Text = dr["gender"].ToString();
            }
            if (ddl_designation.SelectedIndex == 0)
            {
                ddl_designation.Text = dr["designation"].ToString();
            }
        }
        int result = 0;
        Staff staff = new Staff();


        result = staff.StaffUpdate(lbl_staffid.Text, tb_name.Text, ddl_gender.Text, ddl_designation.Text);
        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Edited!');window.location ='Staff(Admin).aspx';",
                   true);
            //Response.Redirect("Staff(Admin).aspx");
        }
        else
        {
            //lbl_result.Text = "User update not successful";
            Response.Write("<script>alert('User update NOT successful');</script>");
        }
    }
}