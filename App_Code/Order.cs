using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{

    //private string _connStr = Properties.Settings.Default.DBConnStr;

    // system configuration connectionStringSettings_connStr
    string _connStr = ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString;


    private string Order_Id = null;
    private string Order_Date = "";
    private string User_Id = ""; // this is another way to specify empty string
    private string Payment_Type = "";
    private string Delivery_Address = "";
    private string Credit_Num = "";
    private string Sub_Total = "";
    private string Delivery_Fee = "";
    private string Discount_Id = "";
    private string Grand_Total = "";

    // Default constructor
    public Order()
    {

    }

    // Constructor that take in all data required to build a Product object
    public Order(string OrderID, string OrderDate, string UserID,
                   string PaymentType, string DeliveryAddress, string CreditNum,
                   string SubTotal, string DeliveryFee, string DiscountID, string GrandTotal)
    {
        Order_Id = OrderID;
        Order_Date = OrderDate;
        User_Id = UserID;
        Payment_Type = PaymentType;
        Delivery_Address = DeliveryAddress;
        Credit_Num = CreditNum;
        Sub_Total = SubTotal;
        Delivery_Fee = DeliveryFee;
        Discount_Id = DiscountID;
        Grand_Total = GrandTotal;
    }

    // Constructor that take in all except Order ID
    public Order(string OrderDate, string UserID,
                   string PaymentType, string DeliveryAddress, string CreditNum,
                   string SubTotal, string DeliveryFee, string DiscountID, string GrandTotal)
        : this(null, OrderDate, UserID, PaymentType, DeliveryAddress, CreditNum, SubTotal,
               DeliveryFee, DiscountID, GrandTotal)
    {
    }

    // Constructor that take in only Order ID. The other attributes will be set to 0 or empty.
    public Order(string Order_Id)
        : this(Order_Id, "", "", "", "", "", "", "", "", "")
    {
    }

    // Get/Set the attributes of the Staff object.
    // Note the attribute name (e.g. Staff_ID) is same as the actual database field name.
    // This is for ease of referencing.
    public string OrderID
    {
        get { return Order_Id; }
        set { Order_Id = value; }
    }
    public string OrderDate
    {
        get { return Order_Date; }
        set { Order_Date = value; }
    }
    public string UserID
    {
        get { return User_Id; }
        set { User_Id = value; }
    }
    public string PaymentType
    {
        get { return Payment_Type; }
        set { Payment_Type = value; }
    }
    public string DeliveryAddress
    {
        get { return Delivery_Address; }
        set { Delivery_Address = value; }
    }
    public string CreditNum
    {
        get { return Credit_Num; }
        set { Credit_Num = value; }
    }
    public string SubTotal
    {
        get { return Sub_Total; }
        set { Sub_Total = value; }
    }
    public string DeliveryFee
    {
        get { return Delivery_Fee; }
        set { Delivery_Fee = value; }
    }
    public string DiscountID
    {
        get { return Discount_Id; }
        set { Discount_Id = value; }
    }
    public string GrandTotal
    {
        get { return Grand_Total; }
        set { Grand_Total = value; }
    }



    //Below as the Class methods for some DB operations. 
    //We will revisit these section in our next practical

    public Order getOrder(string Order_Id)
    {
        Order OrderDetail = null;
        string OrderDate, UserID, PaymentType, DeliveryAddress, CreditNum, SubTotal,
               DeliveryFee, DiscountID, GrandTotal;

        string queryStr = "SELECT * FROM Order WHERE Order_Id = @Order_Id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Order_Id", Order_Id);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Check if there are any resultsets
        if (dr.Read())
        {
            OrderDate = dr["OrderDate"].ToString();
            UserID = dr["UserID"].ToString();
            PaymentType = dr["PaymentType"].ToString();
            DeliveryAddress = dr["DeliveryAddress"].ToString();
            CreditNum = dr["CreditNum"].ToString();
            SubTotal = dr["SubTotal"].ToString();
            DeliveryFee = dr["DeliveryFee"].ToString();
            DiscountID = dr["DiscountID"].ToString();
            GrandTotal = dr["GrandTotal"].ToString();
            OrderDetail = new Order(Order_Id, OrderDate, UserID, PaymentType, DeliveryAddress,
                CreditNum, SubTotal, DeliveryFee, DiscountID, GrandTotal);
        }
        else
        {
            OrderDetail = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return OrderDetail;
    }

    public List<Order> getOrderAll()
    {
        List<Order> OrderDetail = new List<Order>();

        string Order_Id, OrderDate, UserID, PaymentType, DeliveryAddress, CreditNum, SubTotal,
               DeliveryFee, DiscountID, GrandTotal;

        string queryStr = "SELECT * FROM Order Order By Order_Id";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Order_Id = dr["Order_Id"].ToString();
            OrderDate = dr["OrderDate"].ToString();
            UserID = dr["UserID"].ToString();
            PaymentType = dr["PaymentType"].ToString();
            DeliveryAddress = dr["DeliveryAddress"].ToString();
            CreditNum = dr["CreditNum"].ToString();
            SubTotal = dr["SubTotal"].ToString();
            DeliveryFee = dr["DeliveryFee"].ToString();
            DiscountID = dr["DiscountID"].ToString();
            GrandTotal = dr["GrandTotal"].ToString();

            Order a = new Order(Order_Id, OrderDate, UserID, PaymentType, DeliveryAddress, CreditNum,
                      SubTotal, DeliveryFee, DiscountID, GrandTotal);
            OrderDetail.Add(a);
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return OrderDetail;
    }


    public int OrderUpdate(string Order_Id, string OrderDate, string UserID, string PaymentType, string DeliveryAddress,
                string CreditNum, string SubTotal, string DeliveryFee, string DiscountID, string GrandTotal)
    {
        string queryStr = "UPDATE Order SET" +
            //" Order_Id = @OrderID, " +        
            " OrderDate = @OrderDate, " +
            " UserID = @UserID " +
            " PaymentType = @PaymentType " +
            " DeliveryAddress = @DeliveryAddress " +
            " CreditNum = @CreditNum " +
            " SubTotal = @SubTotal " +
            " DeliveryFee = @DeliveryFee " +
            " DiscountID = @DiscountID " +
            " GrandTotal = @GrandTotal " +
            " WHERE Order_Id = @OrderID";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@OrderID", Order_Id);
        cmd.Parameters.AddWithValue("@OrderDate", OrderDate);
        cmd.Parameters.AddWithValue("@UserID", UserID);
        cmd.Parameters.AddWithValue("@PaymentType", PaymentType);
        cmd.Parameters.AddWithValue("@DeliveryAddress", DeliveryAddress);
        cmd.Parameters.AddWithValue("@CreditNum", CreditNum);
        cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
        cmd.Parameters.AddWithValue("@DeliveryFee", DeliveryFee);
        cmd.Parameters.AddWithValue("@DiscountID", DiscountID);
        cmd.Parameters.AddWithValue("@GrandTotal", GrandTotal);

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }//end Update 

    public int OrderDelete(string ID)
    {
        string queryStr = "DELETE FROM Order WHERE Order_Id=@ID";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@ID", ID);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;

    }//end Delete 


}
