using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{

    //private string _connStr = Properties.Settings.Default.DBConnStr;
    string _connStr = ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString;
    private string _prodID = null;
    private string _prodName = string.Empty;
    private string _prodDesc = ""; // this is another way to specify empty string
    private decimal _unitPrice = 0;
    private string _prodImage = "";
    private int _stockLevel = 0;
    private string _prodCategory = string.Empty;

    // Default constructor
    public Product()
    {
    }

    // Constructor that take in all data required to build a Product object
    public Product(string prodID, string prodName, string prodDesc,
                   decimal unitPrice, string prodImage, int stockLevel, string prodCategory)
    {
        _prodID = prodID;
        _prodName = prodName;
        _prodDesc = prodDesc;
        _unitPrice = unitPrice;
        _prodImage = prodImage;
        _stockLevel = stockLevel;
        _prodCategory = prodCategory;
    }

    // Constructor that take in all except product ID
    public Product(string prodName, string prodDesc,
           decimal unitPrice, string prodImage, int stockLevel, string prodCategory)
        : this(null, prodName, prodDesc, unitPrice, prodImage, stockLevel, prodCategory)
    {
    }

    // Constructor that take in only Product ID. The other attributes will be set to 0 or empty.
    public Product(string prodID)
        : this(prodID, "", "", 0, "", 0, "")
    {
    }

    // Get/Set the attributes of the Product object.
    // Note the attribute name (e.g. Product_ID) is same as the actual database field name.
    // This is for ease of referencing.
    public string Product_ID
    {
        get { return _prodID; }
        set { _prodID = value; }
    }
    public string Product_Name
    {
        get { return _prodName; }
        set { _prodName = value; }
    }
    public string Product_Desc
    {
        get { return _prodDesc; }
        set { _prodDesc = value; }
    }
    public decimal Unit_Price
    {
        get { return _unitPrice; }
        set { _unitPrice = value; }
    }
    public string Product_Image
    {
        get { return _prodImage; }
        set { _prodImage = value; }
    }
    public int Stock_Level
    {
        get { return _stockLevel; }
        set { _stockLevel = value; }
    }
    public string Product_Category
    {
        get { return _prodCategory; }
        set { _prodCategory = value; }
    }




    //Below as the Class methods for some DB operations. 
    //We will revisit these section in our next practical.
    public int ProductInsert()
    {
        string msg = null;
        int result = 0;
        string queryStr = "INSERT INTO Products(Product_Name, Product_Desc, Unit_Price, Product_Image,Stock_Level, Product_Category)"
 + "values ( @Product_Name, @Product_Desc, @Unit_Price, @Product_Image,@Stock_Level, @Product_Category)";
        //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price, @Product_Image,@Stock_Level,@Product_Category)";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        //      cmd.Parameters.AddWithValue("@Product_ID", this.Product_ID);
        cmd.Parameters.AddWithValue("@Product_Name", this.Product_Name);
        cmd.Parameters.AddWithValue("@Product_Desc", this.Product_Desc);
        cmd.Parameters.AddWithValue("@Unit_Price", this.Unit_Price);
        cmd.Parameters.AddWithValue("@Product_Image", this.Product_Image);
        cmd.Parameters.AddWithValue("@Stock_Level", this.Stock_Level);
        cmd.Parameters.AddWithValue("@Product_Category", this.Product_Category);
        conn.Open();
        result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
        conn.Close();
        return result;
    }//end Insert



    //public Product getProduct(decimal prodID)
    //{

    //}

    //public List<Product> getProductAll()
    //{

    //}

    //public int ProductInsert()
    //{

    //}//end Insert

    public int ProductDelete(string name)
    {
        string queryStr = "DELETE FROM Products WHERE Product_Name=@name";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@name", name);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end Delete

    public int ProductUpdate(string pId, string pName, decimal pUnitPrice)
    {
        string queryStr = "UPDATE Products SET" +
//" Product_ID = @productID, " +
" Product_name = @Product_Name, " +
" Unit_Price = @unitPrice " +

" WHERE Product_ID = @productID";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@productID", pId);
        cmd.Parameters.AddWithValue("@Product_Name", pName);
        cmd.Parameters.AddWithValue("@unitPrice", pUnitPrice);


        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end Update
    public Product getProduct(string ProdName)
    {
        Product prodDetail = null;
        string prod_id, prod_Name, prod_Desc, Prod_Image, prod_Category;
        decimal unit_Price;
        int stock_Level;
        string queryStr = "SELECT * FROM Products WHERE Product_Name = @ProdName";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@ProdName", ProdName);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        //Check if there are any resultsets
        if (dr.Read())
        {
            prod_id = dr["Product_ID"].ToString();
            //prod_Name = dr["Product_Name"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_Category = dr["Product_Category"].ToString();
            prodDetail = new Product(prod_id, ProdName, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
        }
        else
        {
            prodDetail = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodDetail;
    }

    public List<Product> getAllProduct()
    {
        List<Product> prodList = new List<Product>();
        string prod_Name, prod_Desc, Prod_Image, prod_ID, prod_Category;
        decimal unit_Price;
        int stock_Level;
        string queryStr = "SELECT * FROM Products ";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            prod_ID = dr["Product_ID"].ToString();
            prod_Name = dr["Product_Name"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_Category = dr["Product_Category"].ToString();
            Product a = new Product(prod_ID, prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
            prodList.Add(a);


        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodList;

    }


    // Method To Extract Product by Product Category
    public List<Product> getProductByCategory(string prod_Category)
    {

        List<Product> prodList = new List<Product>(); // Create List Containing One or Many Product

        // Variables in Product Class
        string prod_Desc, Prod_Image, prod_ID, Prod_Name;
        decimal unit_Price;
        int stock_Level;

        // prod_Name equates to the condition being pass to the getProductByName Method. 
        // condition always end with ',' (Comma). Thus, need to remove the last character which is comma
        prod_Category = prod_Category.Substring(0, prod_Category.Length - 1);


        string queryStr = string.Format("SELECT * FROM Products WHERE Product_Category IN ({0})", prod_Category);
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            prod_ID = dr["Product_ID"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Name = dr["Product_Name"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_Category = dr["Product_Category"].ToString();
            Product a = new Product(prod_ID, Prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
            prodList.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodList;
    }


    public List<Product> getProductByUnitPriceD()
    {
        List<Product> prodList = new List<Product>();
        string prod_Name, prod_Desc, Prod_Image, prod_ID, prod_Category;
        decimal unit_Price;
        int stock_Level;
        string queryStr = " SELECT* FROM Products Order By Unit_Price Desc";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            prod_ID = dr["Product_ID"].ToString();
            prod_Name = dr["Product_Name"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_Category = dr["Product_Category"].ToString();
            Product a = new Product(prod_ID, prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
            prodList.Add(a);


        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodList;

    }


    public List<Product> getProductByFilter(string paraCategory, string paraPrice) // Changed function name to Filter and added new parameter
    {
        List<Product> prodList = new List<Product>(); // Create List Containing One or Many Product]

        string queryStr = "";

        if (paraCategory != null && paraPrice == null) // If category not null and the price sorting is null TF
        {
            queryStr = String.Format("SELECT * FROM PRODUCTS WHERE PRODUCT_CATEGORY IN {0} ORDER BY PRODUCT_NAME", paraCategory);
        }
        else if (paraCategory == null && paraPrice != null) // If category is null and the price sorting is not null FT

        {
            queryStr = String.Format("SELECT * FROM PRODUCTS ORDER BY {0}", paraPrice);
        }
        else if (paraCategory != null && paraPrice != null) // If both filter exists TT
        {
            queryStr = String.Format("SELECT * FROM PRODUCTS WHERE PRODUCT_CATEGORY IN {0} ORDER BY {1}", paraCategory, paraPrice);
        }
        else if (paraCategory == null && paraPrice == null) // FF
        {
            queryStr = "SELECT * FROM PRODUCTS ORDER BY PRODUCT_NAME";
        }

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            string prod_ID = dr["Product_ID"].ToString();
            string prod_Desc = dr["Product_Desc"].ToString();
            string Prod_Name = dr["Product_Name"].ToString();
            string Prod_Image = dr["Product_Image"].ToString();
            decimal unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            int stock_Level = int.Parse(dr["Stock_Level"].ToString());
            string prod_Category = dr["Product_Category"].ToString();
            Product a = new Product(prod_ID, Prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
            prodList.Add(a);
        }
        conn.Close();
        dr.Close();
        // dr.Dispose();

        return prodList;

        // List<Product> prodList = new List<Product>(); // Create List Containing One or Many Product

        // // Variables in Product Class
        // string prod_Desc, Prod_Image, prod_ID, Prod_Name;
        // decimal unit_Price;
        // int stock_Level;

        // // prod_Name equates to the condition being pass to the getProductByName Method. 
        // // condition always end with ',' (Comma). Thus, need to remove the last character which is comma
        // prod_Category = prod_Category.Substring(0, prod_Category.Length - 1);


        //// string queryStr = string.Format("SELECT * FROM Products WHERE Product_Category "+ prod_Category+ " ORDER BY Unit_Price Desc");
        // string queryStr = string.Format("SELECT * FROM Products WHERE Product_Category IN ({0})", prod_Category, "ORDER BY Unit_Price");
        // //string queryStr = "SELECT * FROM Products WHERE Product_Category = @prod_Category Order by Unit_Price Desc";

        // SqlConnection conn = new SqlConnection(_connStr);
        // SqlCommand cmd = new SqlCommand(queryStr, conn);
        // cmd.Parameters.AddWithValue("@prod_Category", prod_Category);

        // conn.Open();
        // SqlDataReader dr = cmd.ExecuteReader();

        // //Continue to read the resultsets row by row if not the end
        // while (dr.Read())
        // {
        //     prod_ID = dr["Product_ID"].ToString();
        //     prod_Desc = dr["Product_Desc"].ToString();
        //     Prod_Name = dr["Product_Name"].ToString();
        //     Prod_Image = dr["Product_Image"].ToString();
        //     unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
        //     stock_Level = int.Parse(dr["Stock_Level"].ToString());
        //     prod_Category = dr["Product_Category"].ToString();
        //     Product a = new Product(prod_ID, Prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
        //     prodList.Add(a);
        // }
        // conn.Close();
        // dr.Close();
        // dr.Dispose();
        // return prodList;

    }






    public List<Product> getProductByUnitPricencD(string prod_Category)
    {
        List<Product> prodList = new List<Product>();
        string prod_Name, prod_Desc, Prod_Image, prod_ID;
        decimal unit_Price;
        int stock_Level;
        prod_Category = prod_Category.Substring(0, prod_Category.Length - 1);
        //string queryStr = string.Format("SELECT * FROM Products WHERE Product_Category IN ({0})", prod_category, "Ordery By Unit_Price Desc");
        //string queryStr = " SELECT* FROM Products where Product_Category IN ({0})" + prod_category + "Order By Unit_Price Desc";
        // string queryStr = "SELECT * FROM Products where Product_Category " + prod_Category+  " ORDER BY Unit_Price Desc";
        string queryStr = string.Format("SELECT * FROM Products WHERE Product_Category IN ({0})", prod_Category, "ORDER BY Unit_Price");


        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            prod_ID = dr["Product_ID"].ToString();
            prod_Name = dr["Product_Name"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_Category = dr["Product_Category"].ToString();
            Product a = new Product(prod_ID, prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
            prodList.Add(a);


        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodList;

    }




    public List<Product> getProductByUnitPricencA(string prod_Category)
    {
        List<Product> prodList = new List<Product>();
        string prod_Name, prod_Desc, Prod_Image, prod_ID;
        decimal unit_Price;
        int stock_Level;
        prod_Category = prod_Category.Substring(0, prod_Category.Length - 1);
        //    string queryStr = "SELECT * FROM Products where Product_Category  = '" + prod_Category + "' ORDER BY Unit_Price";

        string queryStr = string.Format("SELECT * FROM Products WHERE Product_Category IN ({0})", prod_Category, "ORDER BY Unit_Price [DESC]");

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            prod_ID = dr["Product_ID"].ToString();
            prod_Name = dr["Product_Name"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_Category = dr["Product_Category"].ToString();
            Product a = new Product(prod_ID, prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
            prodList.Add(a);


        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodList;

    }

    public List<Product> searchProduct(string name)
    {

        List<Product> prodList = new List<Product>(); // Create List Containing One or Many Product

        // Variables in Product Class
        string prod_Desc, Prod_Image, prod_ID, prod_Category, Prod_Name;
        decimal unit_Price;
        int stock_Level;



        string queryStr = String.Format("Select * from Products where Product_Name like '" + name + "%'");
        // string queryStr = string.Format("SELECT * FROM Products WHERE Product_Category IN ({0})", prod_Category);
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            prod_ID = dr["Product_ID"].ToString();
            prod_Desc = dr["Product_Desc"].ToString();
            Prod_Name = dr["Product_Name"].ToString();
            Prod_Image = dr["Product_Image"].ToString();
            unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
            stock_Level = int.Parse(dr["Stock_Level"].ToString());
            prod_Category = dr["Product_Category"].ToString();
            Product a = new Product(prod_ID, Prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
            prodList.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodList;


    }

    /// <summary>
    /// 
    /// </summary>
    // <param name="Prouduct_Name"></param>
    /// <returns></returns>
    //  public List<Product> searchProduct(string Prouduct_Name) // Changed function name to Filter and added new parameter
    //  {
    //      List<Product> prodList = new List<Product>(); // Create List Containing One or Many Product]

    //      string queryStr = "";

    //     if (Product_Name == "hellokitty" || Product_Name == "h") // If category not null and the price sorting is null TF
    //      {
    //           queryStr = String.Format("Select * from Products where Product_Name like {0}%", Product_Name);
    //       }
    //       else if (Product_Name == "vintage" || Product_Name == "v") // If category is null and the price sorting is not null FT
    //
    //       {
    ////        }
    //       else if (Product_Name == "batman" && Product_Name == "b") // If category is null and the price sorting is not null FT
    ///
    //       {
    //            queryStr = String.Format("SELECT * FROM PRODUCTSWHERE PRODUCT_NAME IN {0} LIKE 'B%' ", Product_Name);
    //       }
    //       else if (Product_Name == "ballet" && Product_Name == "b") // If category is null and the price sorting is not null FT
    //
    //       {
    //          queryStr = String.Format("SELECT * FROM PRODUCTSWHERE PRODUCT_NAME IN {0} LIKE 'B%' ", Product_Name);
    //     }

    //       SqlConnection conn = new SqlConnection(_connStr);
    //       SqlCommand cmd = new SqlCommand(queryStr, conn);
    //       conn.Open();
    //       SqlDataReader dr = cmd.ExecuteReader();

    //Continue to read the resultsets row by row if not the end
    //     while (dr.Read())
    //       {
    //           string prod_ID = dr["Product_ID"].ToString();
    //           string prod_Desc = dr["Product_Desc"].ToString();
    //           string Prod_Name = dr["Product_Name"].ToString();
    //          string Prod_Image = dr["Product_Image"].ToString();
    //          decimal unit_Price = decimal.Parse(dr["Unit_Price"].ToString());
    //         int stock_Level = int.Parse(dr["Stock_Level"].ToString());
    //          string prod_Category = dr["Product_Category"].ToString();
    //           Product a = new Product(prod_ID, Prod_Name, prod_Desc, unit_Price, Prod_Image, stock_Level, prod_Category);
    //          prodList.Add(a);
    //      }
    //      conn.Close();
    //      dr.Close();
    // dr.Dispose();
    //
    //       return prodList;


}//end of class


