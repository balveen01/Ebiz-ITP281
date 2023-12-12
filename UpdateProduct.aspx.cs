using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class UpdateProduct : System.Web.UI.Page
{
    Product pDetails = new Product();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl_id.Text = Request.QueryString["id"].ToString();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AlaCarte"].ConnectionString);
            conn.Open();
            string q = "select Product_Name, Unit_Price from [Products] where Product_ID= '" + lbl_id.Text + " ' ";
            SqlCommand query = new SqlCommand(q, conn);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                //lbl_id.Text = dr["Product_ID"].ToString();
                lbl_name.Text = dr["Product_Name"].ToString();
                tb_price.Text = dr["Unit_Price"].ToString();
            }
            conn.Close();
        }
    }

    protected void btn_update_Click(object sender, EventArgs e)
    {
        int result = 0;
        Product update = new Product();
        result = update.ProductUpdate(lbl_id.Text, lbl_name.Text, decimal.Parse(tb_price.Text)) ;

        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                (this, this.GetType(),
                "alert",
                "alert('Product edited'); window.location = 'ProductView.aspx';", true);
        }
        else
        {
            Response.Write("<script>alert('Product update NOT successful');</script>");
        }
    }
}