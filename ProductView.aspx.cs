using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductView : System.Web.UI.Page
{
    AProduct aProd = new AProduct();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void bind()
    {
        List<AProduct> prodList = new List<AProduct>();
        prodList = aProd.getAllProduct101();
        gvProduct.DataSource = prodList;
        gvProduct.DataBind();
    }

    protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = gvProduct.SelectedRow;

        string prodID = row.Cells[0].Text;

        Response.Redirect("ProductDetails.aspx?ProdID=" + prodID);
    }

    protected void gvProduct_RowEditing(object sender, GridViewEditEventArgs e)
    {
        var id = (string)gvProduct.DataKeys[e.NewEditIndex].Value;

        Response.Redirect("UpdateProduct.aspx?id="+ id);

        //gvProduct.EditIndex = e.NewEditIndex;
        //bind();
    }

    protected void gvProduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Product prod = new Product();
        GridViewRow row = (GridViewRow)gvProduct.Rows[e.RowIndex];
        string id = gvProduct.DataKeys[e.RowIndex].Value.ToString();
        string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
        string tname = ((TextBox)row.Cells[1].Controls[0]).Text;
        string tprice = ((TextBox)row.Cells[2].Controls[0]).Text;

        result = prod.ProductUpdate(tid, tname, decimal.Parse(tprice));

        if (result > 0)
        {
            Response.Write("<script>alert('Product updated successfully');</script>");
        }

        else
        {
            Response.Write("<script>alert('Product NOT updated successfully');</script>");
        }

        gvProduct.EditIndex = -1;
        bind();
    }
}