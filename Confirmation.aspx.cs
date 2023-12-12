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


public partial class Confirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lbl_CustName.Text = Request.QueryString["CustName"].ToString();

        ///SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        //con.Open();
        //string myquery = "Select Email from [User] where User_Id = '" + lbl_CustName.Text + "'";
        //SqlCommand cmd = new SqlCommand();
        //SqlCommand query = new SqlCommand(myquery, con);
        //SqlDataReader dr = query.ExecuteReader();
        //string email = null;
        //if (dr.Read())
        //{
        //lbl_email.Text = dr["Email"].ToString();
        //}

    }



    //protected void btn_Email_Click(object sender, EventArgs e)
    //{
    //    //String Confirmation;
    //    String mycon = "Data Source=(LocalDB)MSSQLLocalDB;  Integrated Security=True";
    //    String myquery = "Select * from Confirmation where Email='" + lbl_email.Text +  "'";
    //    //String myquery = "Select User_Email from Users where User_Email='" + lbl_email.Text +  "'";

    //    SqlConnection con = new SqlConnection(mycon);
    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = myquery;
    //    cmd.Connection = con;
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    da.SelectCommand = cmd;
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);
    //}



    protected void btn_Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }



    protected void btn_Delivery_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeliveryTracking.aspx");
    }
}