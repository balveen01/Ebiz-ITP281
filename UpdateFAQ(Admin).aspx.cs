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
using System.Text;

public partial class UpdateFAQ_Admin_ : System.Web.UI.Page
{
    Faq afaq = new Faq();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl_questionid.Text = Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
            con.Open();
            string q = "Select question_id, topic, question, answer from [FAQ] where   question_id = '" + lbl_questionid.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                ddl_category.Text = dr["topic"].ToString();
                tb_answer.Text = dr["answer"].ToString();
                tb_question.Text = dr["question"].ToString();
            }
            con.Close();
        }
    }

    protected void btn_updat_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        con.Open();
        string q = "Select question_id, topic, question, answer from [FAQ] where   question_id = '" + lbl_questionid.Text + "'";

        SqlCommand query = new SqlCommand(q, con);
        SqlDataReader dr = query.ExecuteReader();

        if (dr.Read())
        {
            if (String.IsNullOrEmpty(tb_answer.Text))
            {
                tb_answer.Text = dr["answer"].ToString();
            }
            if (String.IsNullOrEmpty(tb_question.Text))
            {
                tb_question.Text = dr["question"].ToString();
            }
            if (ddl_category.SelectedIndex == 0)
            {
                ddl_category.Text = dr["topic"].ToString();
            }
        }
        int result = 0;
        Faq faq = new Faq();


        result = faq.FaqUpdate(ddl_category.Text, lbl_questionid.Text, tb_question.Text, tb_answer.Text);
        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Question Edited!');window.location ='FAQ(Admin).aspx';",
                   true);
            //Response.Redirect("FAQ(Admin).aspx");
        }
        else
        {
            //lbl_result.Text = "Question update NOT successful";
            Response.Write("<script>alert('User update NOT successful');</script>");
        }
    }
}