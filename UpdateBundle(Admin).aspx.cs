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

public partial class UpdateBundle_Admin_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl_id.Text = Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString);
            con.Open();
            string q = "Select Bundle_Name, Unit_Price from [Bundles] where Bundle_ID = '" + lbl_id.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                tb_name.Text = dr["Bundle_Name"].ToString();
                tb_price.Text = dr["Unit_Price"].ToString();
            }
            con.Close();
        }
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        int result = 0;
        Bundles bund = new Bundles();


        result = bund.BundleUpdate(lbl_id.Text, tb_name.Text, decimal.Parse(tb_price.Text));
        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Bundle Edited!');window.location ='BundleAdmin.aspx';",
                   true);
            //Response.Redirect("Staff(Admin).aspx");
        }
        else
        {
            //lbl_result.Text = "User update not successful";
            Response.Write("<script>alert('Bundle update NOT successful');</script>");
        }
    }
}