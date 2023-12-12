using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class DeliveryTracking_admin_ : System.Web.UI.Page
{
    Delivery aDelivery = new Delivery();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void bind()
    {
        List<Delivery> DeliveryList = new List<Delivery>();
        DeliveryList = aDelivery.getDeliveryAll();
        gvDelivery.DataSource = DeliveryList;
        gvDelivery.DataBind();
    }

    protected void btn_Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }



    protected void gvDelivery_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = gvDelivery.SelectedRow;
        string Delivery_Id = row.Cells[0].Text;
    }


    protected void gvDelivery_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var id = (string)gvDelivery.DataKeys[e.NewEditIndex].Value;
        Response.Redirect("UpdateDelivery.aspx?id="+id);
        //gvDelivery.EditIndex = e.NewEditIndex;
        //bind();
    }

    protected void gvDelivery_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvDelivery.EditIndex = -1;
        bind();
    }

    protected void gvDelivery_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Delivery delivery = new Delivery();
        GridViewRow row = (GridViewRow)gvDelivery.Rows[e.RowIndex];
        string id = gvDelivery.DataKeys[e.RowIndex].Value.ToString();
        string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
        string tdate = ((TextBox)row.Cells[1].Controls[0]).Text;
        string tstatus = ((TextBox)row.Cells[2].Controls[0]).Text;
        string taddress = ((TextBox)row.Cells[3].Controls[0]).Text;

        result = delivery.DeliveryUpdate(tid, tdate, tstatus, taddress);
        if (result > 0)
        {
            Response.Write("<script>alert('Delivery updated successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('Delivery NOT updated');</script>");
        }
        gvDelivery.EditIndex = -1; bind();
    }
}