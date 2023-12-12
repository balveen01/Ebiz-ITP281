//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class FAQ_Admin_ : System.Web.UI.Page
{
    Faq afaq = new Faq();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void bind()
    {
        List<Faq> faqlist = new List<Faq>();
        faqlist = afaq.getFaqAll();
        gv_faq.DataSource = faqlist;
        gv_faq.DataBind();
    }


    protected void gv_faq_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int result = 0;
        Faq faq = new Faq();
        string question_id = gv_faq.DataKeys[e.RowIndex].Value.ToString();
        result = faq.FaqDelete(question_id);

        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Question removed successfully!');window.location ='FAQ(Admin).aspx';",
                  true);

            //Response.Write("<script>alert('Question removed successfully');</script>");
        }
        else
        {
            ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Question removal NOT successfully!');window.location ='FAQ(Admin).aspx';",
                  true);
            //lbl_result.Text = "Question removal NOT succesful";
            //Response.Write("<script>alert('Question removal NOT successful');</script>");
        }
        //Response.Redirect("FAQ(Admin).aspx");
    }

    protected void gv_faq_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var id = (string)gv_faq.DataKeys[e.NewEditIndex].Value;

        Response.Redirect("UpdateFAQ(Admin).aspx?id=" + id);

        //gv_faq.EditIndex = e.NewEditIndex;
        //bind();
    }

    protected void gv_faq_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_faq.EditIndex = -1;
        bind();
    }

    protected void gv_faq_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Faq user = new Faq();
        GridViewRow row = (GridViewRow)gv_faq.Rows[e.RowIndex];
        string id = gv_faq.DataKeys[e.RowIndex].Value.ToString();
        string ttopic = ((TextBox)row.Cells[0].Controls[0]).Text;
        string tquestion_id = ((TextBox)row.Cells[1].Controls[0]).Text;
        string tquestion = ((TextBox)row.Cells[2].Controls[0]).Text;
        string tanswer = ((TextBox)row.Cells[3].Controls[0]).Text;


        result = user.FaqUpdate(ttopic, tquestion_id, tquestion, tanswer);
        if (result > 0)
        {
            Response.Redirect("FAQ(Admin).aspx");
        }
        else
        {
            Response.Write("<script>alert('FAQ update NOT successful');</script>");
        }
        gv_faq.EditIndex = -1;
        bind();
    }






    protected void btn_search_Click(object sender, EventArgs e)
    {
        List<Faq> faqsearchlist = new List<Faq>();
        string tid = ddl_search.Text;
        faqsearchlist = afaq.getFaqSearch(tid);
        if (faqsearchlist.Count == 0)
        {
            lbl_search.Text = "There is no such category";
            this.gv_faq.Visible = false;
            if (ddl_search.Text == "-- Select -- ")
            {
                this.gv_faq.Visible = true;
                lbl_search.Text = "";
                List<Faq> faqlist = new List<Faq>();
                faqlist = afaq.getFaqAll();
                gv_faq.DataSource = faqlist;
                gv_faq.DataBind();
            }
        }
        else
        {
            this.gv_faq.Visible = true;
            lbl_search.Text = "";
            gv_faq.DataSource = faqsearchlist;
            gv_faq.DataBind();
        }
    }


    protected void btn_insert_Click(object sender, EventArgs e)
    {
        Response.Redirect("FAQInsert(Admin).aspx");
    }
}