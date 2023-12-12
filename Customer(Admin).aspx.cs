//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Admin_ : System.Web.UI.Page
{
    Customer aUser = new Customer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void bind()
    {
        List<Customer> customerlist = new List<Customer>();
        customerlist = aUser.getCustomerAll();
        gv_Customer.DataSource = customerlist;
        gv_Customer.DataBind();
    }



    protected void gv_Customer_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int result = 0;
        Customer user = new Customer();
        string username = gv_Customer.DataKeys[e.RowIndex].Value.ToString();
        result = user.CustomerDelete(username);

        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('User has been deleted successfully!');window.location ='Customer(Admin).aspx';",
                  true);
        }
        else
        {
            //lbl_result.Text = "User removal NOT successfully";
            ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('User removal NOT successful!');window.location ='Customer(Admin).aspx';",
                  true);
        }
    }

    protected void gv_Customer_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var id = (string)gv_Customer.DataKeys[e.NewEditIndex].Value;

        Response.Redirect("UpdateCustomer(Admin).aspx?id=" + id);

        //gv_Customer.EditIndex = e.NewEditIndex;
        //bind();
    }

    protected void gv_Customer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_Customer.EditIndex = -1;
        bind();
    }

    protected void gv_Customer_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Customer user = new Customer();
        GridViewRow row = (GridViewRow)gv_Customer.Rows[e.RowIndex];
        string id = gv_Customer.DataKeys[e.RowIndex].Value.ToString();
        string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
        string temail = ((TextBox)row.Cells[1].Controls[0]).Text;
        string taddress = ((TextBox)row.Cells[2].Controls[0]).Text;
        string tphoneno = ((TextBox)row.Cells[3].Controls[0]).Text;
        string tmonth = ((TextBox)row.Cells[4].Controls[0]).Text;
        string tgender = ((TextBox)row.Cells[5].Controls[0]).Text;
        string tverification = ((TextBox)row.Cells[6].Controls[0]).Text;

        result = user.CustomerUpdate(tid, temail, taddress, tphoneno,tmonth, tgender, tverification);
        if (result > 0)
        {
            Response.Redirect("Customer(Admin).aspx");
        }
        else
        {
            Response.Write("<script>alert('User update NOT successful');</script>");
        }
        gv_Customer.EditIndex = -1;
        bind();
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        this.gv_Customer.Visible = true;
        List<Customer> customersearchlist = new List<Customer>();
        string tid = tb_search.Text;
        customersearchlist = aUser.getCustomerSearch(tid);
        if (customersearchlist.Count == 0)
        {
            lbl_search.Text = "There is no user when with that name";
            this.gv_Customer.Visible = false;

            if (String.IsNullOrEmpty(tb_search.Text))
            {
                this.gv_Customer.Visible = true;
                lbl_search.Text = "";
                List<Customer> customerlist = new List<Customer>();
                customerlist = aUser.getCustomerAll();
                gv_Customer.DataSource = customerlist;
                gv_Customer.DataBind();
            }
        }
        else
        {
            this.gv_Customer.Visible = true;
            lbl_search.Text = ""; 
            gv_Customer.DataSource = customersearchlist;
            gv_Customer.DataBind();
        }
    }
}