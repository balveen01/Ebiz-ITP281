using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        
        string connStr  = ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString;
        string myquery = "INSERT INTO Feedback(FeedbackUsername, Ffeedback,Feedback_Rating)"
            + "values ('" + tb_Name.Text + "', '" + tb_Feedback.Text + "' , '" + ddl_Ratings.Text + "')";
        SqlConnection conn = new SqlConnection(connStr);
        conn.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = myquery;
        cmd1.Connection = conn;
        cmd1.ExecuteNonQuery();
        
        ScriptManager.RegisterStartupScript(this, this.GetType(),"alert", "alert('You have successfully submitted your feedback!');window.location ='FeedbackPage.aspx';", true);
    }


}