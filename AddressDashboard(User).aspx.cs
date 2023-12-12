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

public partial class AddressDashboard_User_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_change_Click(object sender, EventArgs e)
    {
        string username = null;
        username = (string)Session["Username"];
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Update [User] set address = '" + tb_address.Text + "' where user_id = '" + username + "'";
        cmd.ExecuteNonQuery();
        conn.Close();
        //Response.Write("<script>alert('Updated!');</script>");
        ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "alert",
                        "alert('Updated!');window.location ='Dashboard(User).aspx';",
                        true);
        //Response.Redirect("Dashboard(User).aspx");

    }
    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Dashboard(User).aspx");
    }
}