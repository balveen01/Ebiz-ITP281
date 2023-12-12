using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Bundle
/// </summary>
public class Bundles
{

    string _connStr = ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString;
    private string _bundleID = null;
    private string _bundleName = string.Empty;
    private string _bundleDesc = string.Empty;
    private decimal _unitPrice = 0;
    private int _stockLevel = 0;
    private string _bundleImage = string.Empty;
    private string _bundleCategory = string.Empty;




    public Bundles()
    {
    }



    public Bundles(string bundleID, string bundleName, string bundleDesc, decimal unitPrice, int stockLevel, string bundleImage, string bundleCategory)
    {
        _bundleID = bundleID;
        _bundleName = bundleName;
        _bundleDesc = bundleDesc;
        _unitPrice = unitPrice;
        _stockLevel = stockLevel;
        _bundleImage = bundleImage;
        _bundleCategory = bundleCategory;

    }

    public Bundles(string bundleName, string bundleDesc,
         decimal unitPrice, int stockLevel, string bundleImage, string bundleCategory)
        : this(null, bundleName, bundleDesc, unitPrice, stockLevel, bundleImage, bundleCategory)
    {
    }


      public Bundles(string BundleID)
        : this(BundleID, "", "", 0, 0, "", "")

     {
     }

    public string Bundle_ID
    {
        get { return _bundleID; }
        set { _bundleID = value; }
    }

    public string Bundle_Name
    {
        get { return _bundleName; }
        set { _bundleName = value; }
    }

    public string Bundle_Desc
    {
        get { return _bundleDesc; }
        set { _bundleDesc = value; }
    }

    public decimal Unit_Price
    {
        get { return _unitPrice; }
        set { _unitPrice = value; }
    }

    public int Stock_Level
    {
        get { return _stockLevel; }
        set { _stockLevel = value; }
    }

    public string Bundle_Image
    {
        get { return _bundleImage; }
        set { _bundleImage = value; }
    }

    public string Bundle_Category
    {
        get { return _bundleCategory; }
        set { _bundleCategory = value; }
    }


    public int BundlesInsert()
    {
        string msg = null;
        int result = 0;
        string queryStr = "INSERT INTO Bundles(Bundle_Name, Bundle_Desc, Unit_Price, Stock_Level,Bundle_Image, Bundle_Category)"
 + "values ( @Bundle_Name, @Bundle_Desc, @Unit_Price,@Stock_Level, @Bundle_Image, @Bundle_Category)";
        //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price, @Product_Image,@Stock_Level,@Product_Category)";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        //      cmd.Parameters.AddWithValue("@Product_ID", this.Product_ID);
        cmd.Parameters.AddWithValue("@Bundle_Name", this.Bundle_Name);
        cmd.Parameters.AddWithValue("@Bundle_Desc", this.Bundle_Desc);
        cmd.Parameters.AddWithValue("@Unit_Price", this.Unit_Price);
        cmd.Parameters.AddWithValue("@Stock_Level", this.Stock_Level);
        cmd.Parameters.AddWithValue("@Bundle_Image", this.Bundle_Image);
        cmd.Parameters.AddWithValue("@Bundle_Category", this.Bundle_Category);
        conn.Open();
        result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
        conn.Close();
        return result;
    }//end Insert


    public int BundleDelete(string id)
    {
        string queryStr = "DELETE FROM Bundles WHERE Bundle_ID=@id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end Delete

    public int BundleUpdate(string bId, string bName, decimal bUnitPrice)
    {
        string queryStr = "UPDATE Bundles SET" +
//" Product_ID = @productID, " +
" Bundle_Name = @bundleName, " +
" Unit_Price = @unitPrice " +
" WHERE Bundle_ID = @bundleID";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@bundleID", bId);
        cmd.Parameters.AddWithValue("@bundleName", bName);
        cmd.Parameters.AddWithValue("@unitPrice", bUnitPrice);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end Update


    public Bundles getBundle(string bundleID)
    {
        Bundles bundleDetail = null;
        string bundle_Name, bundle_Desc, bundle_Image, bundle_Category;
        decimal unit_Price;
        int stock_Level;
        string queryStr = "SELECT * FROM Bundles WHERE Bundle_ID = @BundleID";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@BundleID", bundleID);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        //Check if there are any resultsets
        if (dr.Read())
        {
            bundle_Name = dr["Bundle_Name"].ToString();
            bundle_Desc = dr["Bundle_Desc"].ToString();
            bundle_Image = dr["Bundle_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            bundle_Category = dr["Bundle_Category"].ToString();
            bundleDetail = new Bundles(bundleID, bundle_Name, bundle_Desc, unit_Price, stock_Level, bundle_Image, bundle_Category);
        }
        else
        {
            bundleDetail = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return bundleDetail;
    }

    public List<Bundles> getAllBundle()
    {
        List<Bundles> bundleList = new List<Bundles>();
        string bundle_Name, bundle_Desc, bundle_Image, bundle_ID, bundle_Category;
        decimal unit_Price;
        int stock_Level;
        string queryStr = "SELECT * FROM Bundles";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            bundle_ID = dr["Bundle_ID"].ToString();
            bundle_Name = dr["Bundle_Name"].ToString();
            bundle_Desc = dr["Bundle_Desc"].ToString();
            bundle_Image = dr["Bundle_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            bundle_Category = dr["Bundle_Category"].ToString();
            Bundles a = new Bundles(bundle_ID, bundle_Name, bundle_Desc, unit_Price, stock_Level, bundle_Image, bundle_Category);
            bundleList.Add(a);


        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return bundleList;

    }

    public List<Bundles> getBundletByFilter(string paraCategory, string paraPrice) // Changed function name to Filter and added new parameter
    {
        List<Bundles> bundleList = new List<Bundles>(); // Create List Containing One or Many Product]

        string queryStr = "";

        if (paraCategory != null && paraPrice == null) // If category not null and the price sorting is null TF
        {
            queryStr = String.Format("SELECT * FROM BUNDLES WHERE BUNDLE_CATEGORY IN {0} ORDER BY BUNDLE_NAME", paraCategory);
        }
        else if (paraCategory == null && paraPrice != null) // If category is null and the price sorting is not null FT

        {
            queryStr = String.Format("SELECT * FROM BUNDLES ORDER BY {0}", paraPrice);
        }
        else if (paraCategory != null && paraPrice != null) // If both filter exists TT
        {
            queryStr = String.Format("SELECT * FROM BUNDLES WHERE BUNDLE_CATEGORY IN {0} ORDER BY {1}", paraCategory, paraPrice);
        }
        else if (paraCategory == null && paraPrice == null) // FF
        {
            queryStr = "SELECT * FROM BUNDLES ORDER BY BUNDLE_NAME";
        }

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            string bundle_ID = dr["Bundle_ID"].ToString();
            string bundle_Desc = dr["Bundle_Desc"].ToString();
            string bundle_Name = dr["Bundle_Name"].ToString();
            string bundle_Image = dr["Bundle_Image"].ToString();
            decimal unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            int stock_Level = int.Parse(dr["Stock_Level"].ToString());
            string bundle_Category = dr["Bundle_Category"].ToString();
            Bundles a = new Bundles(bundle_ID, bundle_Name, bundle_Desc, unit_Price, stock_Level, bundle_Image, bundle_Category);
            bundleList.Add(a);
        }
        conn.Close();
        dr.Close();
        // dr.Dispose();

        return bundleList;
    }

    public List<Bundles> searchBundle(string name)
    {

        List<Bundles> bundleList = new List<Bundles>(); // Create List Containing One or Many Product

        // Variables in Product Class
        string bundle_Desc, bundle_Image, bundle_ID, bundle_Category, bundle_Name;
        decimal unit_Price;
        int stock_Level;



        string queryStr = String.Format("Select * from Bundles where Bundle_Name like '" + name + "%'");

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            bundle_ID = dr["Bundle_ID"].ToString();
            bundle_Desc = dr["Bundle_Desc"].ToString();
            bundle_Name = dr["Bundle_Name"].ToString();
            bundle_Image = dr["Bundle_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            bundle_Category = dr["Bundle_Category"].ToString();
            Bundles a = new Bundles(bundle_ID, bundle_Name, bundle_Desc, unit_Price, stock_Level, bundle_Image, bundle_Category);
            bundleList.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return bundleList;
    }
}