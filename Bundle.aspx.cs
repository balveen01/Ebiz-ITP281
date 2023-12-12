using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class Bundle : System.Web.UI.Page
{
    Bundles a = new Bundles();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["BundleID"] != null)
        {
            DataList1.DataSourceID = null;
            DataList1.DataSource = SqlDataSource1;
            DataList1.DataBind();
            Response.Redirect("ProductDetails.aspx");
        }
    }

   



    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {


        Response.Redirect("ProductDetails.aspx");

    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ProductDetails")
        {
            Response.Redirect("ProductDetails.aspx?id=" + e.CommandArgument.ToString());
        }
    }





   
    protected void Button3_Command(object sender, CommandEventArgs e)
    {

        if (e.CommandName == "BundleDetails")
        {
            Response.Redirect("BundleDetails.aspx?id=" + e.CommandArgument.ToString());
        }
    }

   

  
    protected void ImageButton1_Command(object sender, CommandEventArgs e)
    {

        if (e.CommandName == "BundleDetails")
        {
            Response.Redirect("BundleDetails.aspx?id=" + e.CommandArgument.ToString());
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

        List<Bundles> filterlist = new List<Bundles>();
        filterlist = a.getBundletByFilter(category, price);
        DataList1.DataSourceID = null;
        DataList1.DataSource = filterlist;
        DataList1.DataBind();
  //      Response.Write(String.Format("SELECT * FROM PRODUCTS WHERE PRODUCT_CATEGORY IN {0} ORDER BY {1}", category, price)); // Test statement
       



        //// List Out All Selected Product Name //

        //foreach (ListItem item in chkCountries.Items)
        //{ // Run Through Each Item in Checkbox

        //    if (item.Selected)
        //    { // Check if the Item is Selected. If TRUE, 
        //        condition = condition + string.Format("'{0}',", item.Text); // IF TRUE, concatinate into a single line. Eg. 'Vitamin C',   + 'Vitamin E',   + ...
        //    }
        //}


        //// If One or More Item is Selected, Pass Condition into Method (getProductByCategory) 
        //// Where condition includes all of the Product Name Selected
        //if (chkCountries.SelectedItem != null && RadioButtonList1.SelectedItem.Text == "High to Low Price")
        //{


        //    // Extract Data
        //    List<Product> prodList = new List<Product>();
        //    DataList1.DataSourceID = null;
        //    DataList1.DataSource = aProd.getProductByUnitPricencD(condition);
        //    DataList1.DataBind();

        //}

        //// Nothing Is Selected, Display Everything
        //if (chkCountries.SelectedItem != null && RadioButtonList1.SelectedItem.Text == "Low to High Price")
        //{
        //    List<Product> prodList = new List<Product>();
        //    DataList1.DataSourceID = null;
        //    DataList1.DataSource = aProd.getProductByUnitPricencA(condition);
        //    DataList1.DataBind();
        //}
    }






    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        this.DataList1.Visible = true;
        List<Bundles> bundleList = new List<Bundles>();
        string name = tb_Search.Text;
        bundleList = a.searchBundle(name);
        if(bundleList.Count == 0)
        {
            lbl_search.Text = "No results";
            this.DataList1.Visible = false;

            if(string.IsNullOrEmpty(tb_Search.Text)) 
            {
                this.DataList1.Visible = true;
                lbl_search.Text = "";
                List<Bundles> prodlistsearch = new List<Bundles>();
                prodlistsearch = a.getAllBundle();
                DataList1.DataSourceID = null;
                DataList1.DataSource = prodlistsearch;
                DataList1.DataBind();
            }
        }
        else
        {
            this.DataList1.Visible = true;
            lbl_search.Text = "";
            DataList1.DataSourceID = null;
            DataList1.DataSource = bundleList;
            DataList1.DataBind();

        }
    }


    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
}












