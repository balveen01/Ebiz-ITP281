using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;

public partial class BundleDetails : System.Web.UI.Page
{
    Product prod = null;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string iProductID = prod.Product_ID.ToString();
        ShoppingCart.Instance.AddItem(iProductID, prod);






        //   string connStr = ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString;
        //  string myquery = "INSERT into ShoppingItem(user_id, prod_id, cart_qty) values('" + Session["Username"] + "' , '" +  + "'  '" + ddl_category.Text + "')";
        //  SqlConnection conn = new SqlConnection(connStr);
        //  conn.Open();
        //  SqlCommand cmd1 = new SqlCommand();
        //cmd1.CommandText = myquery;
        //cmd1.Connection = conn;
        //cmd1.ExecuteNonQuery();
        //lbl_response.Text = "Your question has been sent!";
        //Response.Redirect("FAQ(Admin).aspx");
        //Response.Write("<script>alert('Your question has been sent!')</script>");
        //ScriptManager.RegisterStartupScript
        //           (this, this.GetType(),
        //           "alert",
        //           "alert('Question has been added');window.location ='FAQ(Admin).aspx';",
        //           true);

    }
}