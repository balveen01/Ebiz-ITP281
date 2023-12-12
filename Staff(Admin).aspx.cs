//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staff_Admin_ : System.Web.UI.Page
{
    Staff aStaff = new Staff();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void bind()
    {
        List<Staff> stafflist = new List<Staff>();
        stafflist = aStaff.getStaffAll();
        gv_staff.DataSource = stafflist;
        gv_staff.DataBind();
    }



    protected void gv_staff_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        int result = 0;
        Staff staff = new Staff();
        string username = gv_staff.DataKeys[e.RowIndex].Value.ToString();
        result = staff.StaffDelete(username);

        if (result > 0)
        {
            ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Staff removed successfully!');window.location ='Staff(Admin).aspx';",
                  true);
            //Response.Write("<script>alert('User removed successfully');</script>");
        }
        else
        {
            ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Staff removal NOT successfully!');window.location ='Staff(Admin).aspx';",
                  true);
            //lbl_result.Text = "User removal NOT successfully";
            //Response.Write("<script>alert('User removal NOT successful');</script>");
        }
        Response.Redirect("Staff(Admin).aspx");
    }

    protected void gv_staff_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var id = (string)gv_staff.DataKeys[e.NewEditIndex].Value;

        Response.Redirect("UpdateStaff(Admin).aspx?id=" + id);
        //gv_staff.EditIndex = e.NewEditIndex;
        //bind();
    }

    protected void gv_staff_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_staff.EditIndex = -1;
        bind();
    }

    protected void gv_staff_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Staff staff = new Staff();
        GridViewRow row = (GridViewRow)gv_staff.Rows[e.RowIndex];
        string id = gv_staff.DataKeys[e.RowIndex].Value.ToString();
        string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
        string tname = ((TextBox)row.Cells[1].Controls[0]).Text;
        string tgender = ((TextBox)row.Cells[2].Controls[0]).Text;
        string tdesignation = ((TextBox)row.Cells[3].Controls[0]).Text;
        string tnric = ((TextBox)row.Cells[4].Controls[0]).Text;

        


        result = staff.StaffUpdate(tid, tname, tgender, tdesignation);
        if (result > 0)
        {
            Response.Redirect("Staff(Admin).aspx");
        }
        else
        {
            Response.Write("<script>alert('User update NOT successful');</script>");
        }
        gv_staff.EditIndex = -1;
        bind();
    }



    protected void btn_search_Click(object sender, EventArgs e)
    {
        this.gv_staff.Visible = true;
        List<Staff> staffsearchlist = new List<Staff>();
        string tid = tb_search.Text;
        staffsearchlist = aStaff.getstaffsearch(tid);
        if (staffsearchlist.Count == 0)
        {
            lbl_search.Text = "There is no user when with that name";
            this.gv_staff.Visible = false;

            if (String.IsNullOrEmpty(tb_search.Text))
            {
                this.gv_staff.Visible = true;
                lbl_search.Text = "";
                List<Staff> stafflist = new List<Staff>();
                stafflist = aStaff.getStaffAll();
                gv_staff.DataSource = stafflist;
                gv_staff.DataBind();
            }
        }

        else
        {
            this.gv_staff.Visible = true;
            lbl_search.Text = "";
            gv_staff.DataSource = staffsearchlist;
            gv_staff.DataBind();
        }
        
    }

    protected void btn_insert_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffInsert(Admin).aspx");
    }
}