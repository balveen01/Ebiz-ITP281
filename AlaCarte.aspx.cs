using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AlaCarte : System.Web.UI.Page
{
    Product aProd = new Product();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ProdID"] != null)
        {
            DataList1.DataSourceID = null;
            DataList1.DataSource = SqlDataSource1;
            DataList1.DataBind();
            Response.Redirect("ProductDetails.aspx");
        }
    }

    protected void btn_both_Click(object sender, EventArgs e)
    {
        string category = null;
        string price = null;
        foreach (ListItem item in chkCountries.Items) // For each item inside the list
        {
            if (item.Selected) // If the item is ticked by the user
            {
                if (category != null) // if the string is NOT null
                {
                    category += ", '" + item.Value + "'"; // Add a comma and add the value at the back
                }
                else
                {
                    category += "'" + item.Value + "'"; // Add the string only
                }
            }
        }
        if (category != null) // If string is not empty
        {
            category = String.Format("({0})", category); // Add () around the string
                                                         //     GetType = aProd.getProductByFilter(category, price);

        }

        if (RadioButtonList1.SelectedValue != "") // If selected radio button is not null
        {
            price = RadioButtonList1.SelectedValue; // Add the value into the query string
        }
        else
        {
            price = "UNIT_PRICE"; // If there is nothing inputted, default is set to ascending
        }

        List<Product> filterlist = new List<Product>();
        filterlist = aProd.getProductByFilter(category, price);
        DataList1.DataSourceID = null;
        DataList1.DataSource = filterlist;
        DataList1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        this.DataList1.Visible = true;
        List<Product> prodList = new List<Product>();
        string name = tb_Search.Text;
        prodList = aProd.searchProduct(name);
        if (prodList.Count == 0)
        {
            lbl_Search.Text = "No results";
            this.DataList1.Visible = false;

            if (string.IsNullOrEmpty(tb_Search.Text))
            {
                this.DataList1.Visible = true;
                lbl_Search.Text = "";
                List<Product> prodlistsearch = new List<Product>();
                prodlistsearch = aProd.getAllProduct();
                DataList1.DataSourceID = null;
                DataList1.DataSource = prodlistsearch;
                DataList1.DataBind();
            }
        }
        else
        {
            this.DataList1.Visible = true;
            lbl_Search.Text = "";
            DataList1.DataSourceID = null;
            DataList1.DataSource = prodList;
            DataList1.DataBind();

        }
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ProductDetails")
        {
            Response.Redirect("ProductDetails.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}