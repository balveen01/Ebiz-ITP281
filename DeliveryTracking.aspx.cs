using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Net;
using System.Text;


public partial class DeliveryTracking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }



    protected void btn_TrackOrder_Click(object sender, EventArgs e)
    {
        /**
        string connStr = ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString);
        con.Open();
        string find = "Select Delivery_Address from [Delivery] where Delivery_Id = '" + tb_Order.Text + "'";
        SqlCommand cmd = new SqlCommand();

        SqlCommand query = new SqlCommand(find, con);
        SqlDataReader dr = query.ExecuteReader();
       string address = null;

        if (dr.Read())
        {
            address = dr["Delivery_Address"].ToString();
        }

        Adress adrs = new Adress();
        adrs.Address = address;
        adrs.GeoCode();

        string myquery = "Update[Delivery] set Latitude = '" + adrs.Latitude + "', Longitude = '" + adrs.Longitude + "' where Delivery_Id = '" + tb_Order.Text + "'";
        SqlConnection conn = new SqlConnection(connStr);
        conn.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = myquery;
        cmd1.Connection = conn;
        cmd1.ExecuteNonQuery();**/
        /**
            string connStr = ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString;
            string myquery = "INSERT INTO Delivery(Delivery_Id, Delivery_Date, Delivey_Status, Delivery_Address)"
                + "values ('" + tb_Order.Text + "', ')";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = myquery;
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You have successfully submitted your feedback!');window.location ='DeliveryTracking(admin).aspx';", true);**/







        Response.Redirect("DeliveryMap.aspx");
            

    }
}
