//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
public partial class FAQInsert_Admin_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_insert_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
        string myquery = "INSERT into FAQ(question, answer, topic) values('" + tb_question.Text + "' , '" + tb_answer.Text + "' , '" + ddl_category.Text + "')";
        SqlConnection conn = new SqlConnection(connStr);
        conn.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = myquery;
        cmd1.Connection = conn;
        cmd1.ExecuteNonQuery();
        //lbl_response.Text = "Your question has been sent!";
        //Response.Redirect("FAQ(Admin).aspx");
        //Response.Write("<script>alert('Your question has been sent!')</script>");
        ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Question has been added');window.location ='FAQ(Admin).aspx';",
                   true);
    }
}
