//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;

public partial class FAQContact_User_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_emailus_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string find = "Select question, topic from [FAQ] where topic = '" + ddl_category.Text + "'";
        SqlCommand cmd = new SqlCommand();

        SqlCommand query = new SqlCommand(find, con);
        SqlDataReader dr = query.ExecuteReader();

        if (dr.Read())
        {
            string question = dr["question"].ToString();
            if (question == tb_question.Text)
            {
                Response.Write("<script>alert('The questions has been asked before. Please take a look at the FAQ page.');</script>");
                //lbl_result.Text = "This question has been asked before. Please take a look at the FAQ page.";
            }
            else
            {
                string myquery = "INSERT into FAQ(question, topic) values('" + tb_question.Text + "' , '" + ddl_category.Text + "')";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = myquery;
                cmd1.Connection = conn;
                cmd1.ExecuteNonQuery();
                //lbl_result.Text = "Your question has been sent!";
                //Response.Write("<script>alert('Your question has been sent!')</script>");
                ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Your question has been sent!');window.location ='FAQ(User).aspx';",
                  true);
            }
        }
        con.Close();
        
    }




}