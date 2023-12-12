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

public partial class UpdateAlacarte_Admin_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tb_name.Text = Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString);
            con.Open();
            string q = "Select Product_ID, Product_Name, Unit_Price from [Products] where Product_Name = '" + tb_name.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                lbl_id.Text = dr["Product_ID"].ToString();
                tb_price.Text = dr["Unit_Price"].ToString();
            }
            con.Close();
        }
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        int result = 0;
        Product prod = new Product();


        result = prod.ProductUpdate(lbl_id.Text, tb_name.Text, decimal.Parse(tb_price.Text));
        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Product Edited!');window.location ='AlacarteAdmin.aspx';",
                   true);
            //Response.Redirect("Staff(Admin).aspx");
        }
        else
        {
            //lbl_result.Text = "User update not successful";
            Response.Write("<script>alert('Product update NOT successful');</script>");
        }
    }
}