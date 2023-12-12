using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class UpdateDelivery : System.Web.UI.Page
{
    Delivery adelivery = new Delivery();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl_Did.Text = Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString);
            con.Open();
            string q = "Select * from [Delivery] where Delivery_Id = '" + lbl_Did.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {

                tb_Dstatus.Text = dr["Delivery_Status"].ToString();
                lbl_Daddress.Text = dr["Delivery_Address"].ToString();
                lbl_Ddate.Text = dr["Delivery_Date"].ToString();
            }
            con.Close();
        }
    }

    protected void btn_Update_Click(object sender, EventArgs e)
    {
        int result = 0;
        Delivery delivery = new Delivery();
        result = delivery.DeliveryUpdate(lbl_Did.Text, lbl_Ddate.Text, tb_Dstatus.Text, lbl_Daddress.Text);
        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                (this, this.GetType(),
                "alert",
                "alert('Delivery edited'); window.location = 'DeliveryTracking(admin).aspx';",
                true);
                
        }
        else
        {
            Response.Write("<script>alert('Delivery update NOT successful');</script> ");
        }
    }
}