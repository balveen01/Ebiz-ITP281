using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
public partial class Recommendation : System.Web.UI.Page
{
    Product aProd = new Product();
    Venue aVenue = new Venue();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) // If page isnt post back refresh the data
        {/*
            If this isnt here, when you press your button, the data from the page gets send into the server
            then it repeats over and over again, which means its refreshing until it crashes
            */
            bind();
        }

    }

    protected void bind() // Function to refresh the data
    {

        List<Product> prodList = new List<Product>();
        List<Venue> venueList = new List<Venue>();
        string prod_Name, prod_Desc, Prod_Image, prod_ID, prod_category, stringUP, stringTHEME, venue_Name, venue_Id, venue_Image, venue_Link, venue_Desc, venueType, stringVenue;
        decimal unit_Price, cbl_Theme;
        int stock_Level, venue_Cap;

        unit_Price = Convert.ToDecimal(Request.QueryString["Unit_Price"]);
        cbl_Theme = Convert.ToDecimal(Request.QueryString["theme"]);
        // cap1 = Request.QueryString["capacity"].ToString();
        // capacity = Request.QueryString["capacity"].ToString();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString);
        con.Open();

        if (unit_Price != 0)
        {
            stringUP = " Unit_Price < " + unit_Price.ToString();
        }
        else
        {
            stringUP = "";
        }

        if (cbl_Theme != 0)
        {
            if (stringUP != "")
            {
                stringTHEME = " AND theme_id = " + cbl_Theme.ToString();
            }
            else
            {
                stringTHEME = " theme_id = " + cbl_Theme.ToString();
            }
        }
        else
        {
            stringTHEME = "";
        }

        string q = "Select * from Prodss where " + stringUP + stringTHEME;
        SqlCommand query = new SqlCommand(q, con);
        SqlDataReader dr = query.ExecuteReader();

        while (dr.Read())
        {
            prod_ID = dr["Product_ID"].ToString();
            prod_Name = dr["Product_Name"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_category = dr["Product_Category"].ToString();
            Product a = new Product(prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_category);
            prodList.Add(a);
            /*
            DataList1.DataSourceID = null;
            DataList1.DataSource = SqlDataSource1;
            DataList1.DataBind();
            */
        }

        DataList1.DataSourceID = null;
        DataList1.DataSource = prodList;
        DataList1.DataBind();
        con.Close();
        dr.Close();
        dr.Dispose();


        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString);
        con1.Open();
        //venue
        venueType = Request.QueryString["capacity"].ToString();
        switch (venueType)
        {
            case "B30":
                stringVenue = " venue_cap < 30";
                break;
            case "B60":
                stringVenue = " venue_cap < 60";
                break;
            case "B90":
                stringVenue = " venue_cap < 90";
                break;
            case "M90":
                stringVenue = " venue_cap > 90";
                break;
            default:
                stringVenue = "";
                break;
        }

        string p = "Select * from Venue where " + stringVenue;
        SqlCommand query1 = new SqlCommand(p, con1);
        SqlDataReader pr = query1.ExecuteReader();

        while (pr.Read())
        {
            venue_Id = pr["venue_id"].ToString();
            venue_Name = pr["venue_name"].ToString();
            venue_Desc = pr["venue_desc"].ToString();
            venue_Link = pr["venue_link"].ToString();
            venue_Image = "~\\Images\\" + pr["venue_img"].ToString();
            venue_Cap = int.Parse(pr["venue_cap"].ToString());
            Venue v = new Venue(venue_Id, venue_Name, venue_Desc, venue_Link, venue_Cap, venue_Image);
            venueList.Add(v);
            /*
            DataList1.DataSourceID = null;
            DataList1.DataSource = SqlDataSource1;
            DataList1.DataBind();
            */
        }
        DataList2.DataSourceID = null;
        DataList2.DataSource = venueList;
        DataList2.DataBind();
        con.Close();
        pr.Close();
        pr.Dispose();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string ProdID = btn.Attributes["CustomParameter"].ToString();
        Response.Redirect("SProductDetails.aspx?ProdName=" + ProdID);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string venueId = btn.Attributes["CustomParameter"].ToString();
        Response.Redirect("VenueDetails.aspx?venueId=" + venueId);
    }

}