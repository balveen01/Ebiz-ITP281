using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BundleAdmin : System.Web.UI.Page
{
    Bundles aBundle = new Bundles();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void bind()
    {
        List<Bundles> bundleList = new List<Bundles>();
        bundleList = aBundle.getAllBundle();
        gv_Bundle.DataSource = bundleList;
        gv_Bundle.DataBind();
    }

   

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var id = (string)gv_Bundle.DataKeys[e.NewEditIndex].Value;

        Response.Redirect("UpdateBundle(Admin).aspx?id=" + id);

        //gv_Bundle.EditIndex = e.NewEditIndex;
        //bind();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_Bundle.EditIndex = -1;
        bind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Bundles bun = new Bundles();
        GridViewRow row = (GridViewRow)gv_Bundle.Rows[e.RowIndex];
  //      string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
        string tname = ((TextBox)row.Cells[1].Controls[0]).Text;
        string tprice = ((TextBox)row.Cells[2].Controls[0]).Text;

        result = bun.BundleUpdate(tid, tname, decimal.Parse(tprice));
        if (result > 0)
        {
            //Response.Redirect("AlacarteAdmins.aspx");
            Response.Write("<script>alert('Product updated successfully');</script>");
        }

        else
        {
            Response.Write("<script>alert('Product NOT updated');</script>");
        }
        gv_Bundle.EditIndex = -1;
        bind();
    }

    protected void btn_InsertBundle_Click(object sender, EventArgs e)
    {
        Response.Redirect("BundleInsert.aspx");
    }

    protected void gv_Bundle_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        int result = 0;
        Bundles bun = new Bundles();
        string categoryID = gv_Bundle.DataKeys[e.RowIndex].Value.ToString(); ;
        result = bun.BundleDelete(categoryID);
        if (result > 0)
        {
            Response.Write("<script>alert('Product Remove successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('Product Removal NOT successfully');</script>");
        }
        Response.Redirect("BundleAdmin.aspx");
    }
}