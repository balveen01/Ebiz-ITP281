//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FAQ_User_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
        string queryStr = "SELECT question, answer, topic from FAQ WHERE answer IS NOT NULL order by topic";
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();

        cmd.CommandType = System.Data.CommandType.Text;
        cmd.Connection = conn;

        string temp = "";
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            temp += "<p style= 'font-size:30px; font-weight:bold; text-decoration:underline; padding-left:200px; padding-right:120px;'>";
            temp += reader["topic"];
            temp += "</p>";
            temp += "<p style='font-size: 25px; font-weight:bold; padding-left:200px; padding-right:120px;'> Q: ";
            temp += reader["question"].ToString();
            temp += "</p>";
            temp += "<p style = 'font-size: 20px;padding-left:200px;padding-right:120px;'> A: ";
            temp += reader["answer"].ToString();
            temp += "</p>";
            temp += "<br/>";

        }

        conn.Close();
        lbl_qna.Text = temp;

    }

    protected void btn_emailus_Click(object sender, EventArgs e)
    {
        Response.Redirect("FAQContact(User).aspx");
    }


    protected void btn_search_Click(object sender, EventArgs e)
    {
        lbl_topic.Text = "";
        if (ddl_search.Text == "-- Select -- ")
        {
            string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
            string queryStr = "SELECT question, answer, topic from FAQ WHERE answer IS NOT NULL order by topic";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            conn.Open();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string temp = "";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                temp += "<p style= 'font-size:30px; font-weight:bold; text-decoration:underline; padding-left:200px; padding-right:120px;'>";
                temp += reader["topic"];
                temp += "</p>";
                temp += "<p style='font-size: 25px; font-weight:bold; padding-left:200px; padding-right:120px;'> Q: ";
                temp += reader["question"].ToString();
                temp += "</p>";
                temp += "<p style = 'font-size: 20px;padding-left:200px;padding-right:120px;'> A: ";
                temp += reader["answer"].ToString();
                temp += "</p>";
                temp += "<br/>";

            }

            conn.Close();
            lbl_qna.Text = temp;
        }
        else
        {
            string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
            string querystr = null;
            querystr = "SELECT question, answer, topic from FAQ WHERE topic = '" + ddl_search.Text + "' and answer IS NOT NULL";
            string topic = null;
            topic = ddl_search.Text;

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(querystr, conn);
            conn.Open();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string temp = "";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbl_topic.Text = topic;
                temp += "<p style='font-size: 25px; font-weight:bold; padding-left:200px; padding-right:120px;'> Q: ";
                temp += reader["question"].ToString();
                temp += "</p>";
                temp += "<p style = 'font-size: 20px;padding-left:200px;padding-right:120px;'> A: ";
                temp += reader["answer"].ToString();
                temp += "</p>";
                temp += "<br/>";

            }

            conn.Close();
            lbl_qna.Text = temp;
        }
    }
}