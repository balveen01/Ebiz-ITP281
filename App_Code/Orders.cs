using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for Orders
/// </summary>
public class Orders
{

    string _connStr = ConfigurationManager.ConnectionStrings["HealthDBContext"].ConnectionString;
    //private string _orderdate = string.Empty;
    private DateTime _orderdate = Convert.ToDateTime(null);
    private string _userid = string.Empty;
    private string _paymenttype = string.Empty;
    private string _address = string.Empty;
    private string _email = string.Empty;
    private string _contact = string.Empty;
    private string _orderCardNum = string.Empty;
    private double _subtotal = 0;
    private double _deliveryfee = 0;
    private string _discountid = string.Empty;
    private double _grandtotal = 0;
    private string _deliverystatus = string.Empty;

    public Orders()
    {
    }

    public Orders(DateTime orderdate, string userid, string paymenttype, string address, string email, string contact
        , string orderCardNum, double subtotal, double deliveryfee, string discountid, double grandtotal, string deliverystatus)
    {
        _orderdate = orderdate;
        _userid = userid;
        _paymenttype = paymenttype;
        _address = address;
        _email = email;
        _contact = contact;
        _orderCardNum = orderCardNum;
        _subtotal = subtotal;
        _deliveryfee = deliveryfee;
        _discountid = discountid;
        _grandtotal = grandtotal;
        _deliverystatus = deliverystatus;


    }

    public DateTime orderdate
    {
        get { return _orderdate; }
        set { _orderdate = value; }
    }
    public string userid
    {
        get { return _userid; }
        set { _userid = value; }
    }
    public string paymenttype
    {
        get { return _paymenttype; }
        set { _paymenttype = value; }
    }
    public string address
    {
        get { return _address; }
        set { _address = value; }
    }
    public string email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string contact
    {
        get { return _contact; }
        set { _contact = value; }
    }
    public string orderCardNum
    {
        get { return _orderCardNum; }
        set { _orderCardNum = value; }
    }
    public double subtotal
    {
        get { return _subtotal; }
        set { _subtotal = value; }
    }

    public double deliveryfee
    {
        get { return _deliveryfee; }
        set { _deliveryfee = value; }
    }

    public string discountid
    {
        get { return _discountid; }
        set { _discountid = value; }
    }
    public double grandtotal
    {
        get { return _grandtotal; }
        set { _grandtotal = value; }
    }
    public string deliverystatus
    {
        get { return _deliverystatus; }
        set { _deliverystatus = value; }

    }
        public int OrderInsert()
    {
        string msg = null;
        int result = 0;
        string queryStr = "INSERT INTO [Order] (User_Id, Payment_Type, Delivery_Address, Email, Contact, Credit_Num,Sub_Total, Delivery_Fee, Discount_Id, Grand_Total, Delivery_Status)"
            + "values(@userid, @paymenttype,@address,@email, @contact, @orderCardNum,@subtotal,@deliveryfee,@discountid, @grandtotal, @deliverystatus)";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        //    cmd.Parameters.AddWithValue("@Order_ID", this.Order_ID);
        //cmd.Parameters.AddWithValue("@id", this.Order_ID);
        //cmd.Parameters.AddWithValue("@orderdate", this.orderdate);
        cmd.Parameters.AddWithValue("@userid", this.userid);
        cmd.Parameters.AddWithValue("@paymenttype", this.paymenttype);
        cmd.Parameters.AddWithValue("@address", this.address);
        cmd.Parameters.AddWithValue("@email", this.email);
        cmd.Parameters.AddWithValue("@contact", this.contact);
        cmd.Parameters.AddWithValue("@orderCardNum", this.orderCardNum);
        cmd.Parameters.AddWithValue("@subtotal", this.subtotal);
        cmd.Parameters.AddWithValue("@deliveryfee", this.deliveryfee);
        cmd.Parameters.AddWithValue("@discountid", this.discountid);
        cmd.Parameters.AddWithValue("@grandtotal", this.grandtotal);
        cmd.Parameters.AddWithValue("@deliverystatus", this.deliverystatus);
        conn.Open();
        result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
        conn.Close();
        return result;



    }





}
