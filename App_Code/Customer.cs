//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    string _connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;

    private string _username = null;
    private string _email = null;
    private string _address = null;
    private string _password = null;
    private string _phonenumber = null;
    private string _month = null;
    private string _gender = null;
    private string _email_status = null;
    private string _email_code = null;



    public Customer()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Customer(string username, string email, string address, string password, string phonenumber, string month, string gender, string email_status, string email_code)
    {
        _username = username;
        _email = email;
        _address = address;
        _password = password;
        _phonenumber = phonenumber;
        _month = month;
        _gender = gender;
        _email_status = email_status;
        _email_code = email_code;
    }

    public Customer(string email, string address, string password, string phonenumber, string month, string gender, string email_status, string email_code)
        : this(null, email, address, password, phonenumber, month, gender, email_status, email_code)
    {
    }

    public Customer(string username)
        : this(username, "", "", "", "", "", "", "")
    {
    }

    public string user_id
    {
        get { return _username; }
        set { _username = value; }
    }

    public string email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string password
    {
        get { return _password; }
        set { _password = value; }
    }

    public string phone_number
    {
        get { return _phonenumber; }
        set { _phonenumber = value; }
    }

    public string month
    {
        get { return _month; }
        set { _month = value; }
    }

    public string gender
    {
        get { return _gender; }
        set { _gender = value; }
    }

    public string email_status
    {
        get { return _email_status; }
        set { _email_status = value; }
    }

    public string email_code
    {
        get { return _email_code; }
        set { _email_code = value; }
    }

    public Customer getCustomer(string username)
    {
        Customer customerinfo = null;

        string email, address, password, phonenumber, month, gender, email_status, email_code;

        string queryStr = "SELECT * FROM [User] WHERE user_id = @username";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@username", username);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            email = dr["email"].ToString();
            address = dr["address"].ToString();
            password = dr["password"].ToString();
            phonenumber = dr["phone_number"].ToString();
            month = dr["month"].ToString();
            gender = dr["gender"].ToString();
            email_status = dr["email_status"].ToString();
            email_code = dr["email_code"].ToString();

            customerinfo = new Customer(username, email, address, password, phonenumber, month, gender, email_status, email_code);
        }
        else
        {
            customerinfo = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return customerinfo;
    }

    public List<Customer> getCustomerAll()
    {
        List<Customer> customerlist = new List<Customer>();

        string username, email, address, password, phonenumber, month, gender, email_status, email_code;

        string queryStr = "SELECT * FROM [User] Order by user_id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            username = dr["user_id"].ToString();
            email = dr["email"].ToString();
            address = dr["address"].ToString();
            password = dr["password"].ToString();
            phonenumber = dr["phone_number"].ToString();
            month = dr["month"].ToString();
            gender = dr["gender"].ToString();
            email_status = dr["email_status"].ToString();
            email_code = dr["email_code"].ToString();
            Customer a = new Customer(username, email, address, password, phonenumber, month, gender, email_status, email_code);
            customerlist.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return customerlist;
    }

    public int CustomerInsert()
    {
        //string msg = null;
        int result = 0;

        string queryStr = "INSERT INTO [User] (user_id, email, address, password, phone_number, month, gender, email_status, email_code) values (@user_id,@email, @address, @password, @phone_number, @month, @gender, @email_status, @email_code)";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@user_id", this.user_id);
        cmd.Parameters.AddWithValue("@email", this.email);
        cmd.Parameters.AddWithValue("@address", this.address);
        cmd.Parameters.AddWithValue("@password", this.password);
        cmd.Parameters.AddWithValue("@phone_number", this.phone_number);
        cmd.Parameters.AddWithValue("@month", this.month);
        cmd.Parameters.AddWithValue("@gender", this.gender);
        cmd.Parameters.AddWithValue("@email_status", this.email_status);
        cmd.Parameters.AddWithValue("@email_code", this.email_code);

        conn.Open();
        result += cmd.ExecuteNonQuery();
        conn.Close();

        return result;
    }

    public int CustomerDelete(string username)
    {
        string querystr = "DELETE FROM [User] WHERE user_id = @username";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(querystr, conn);
        cmd.Parameters.AddWithValue("@username", username);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }

    public int CustomerUpdate(string pid, string pemail, string paddress, string pphoneno, string pmonth, string pgender, string pverification)
    {
        string queryStr = "UPDATE [User] SET " + "email = @email, " + "address = @address, " + "phone_number = @phone_number, " + "month = @month, " + "gender = @gender, " + "email_status = @email_status " + "WHERE user_id = @user_id";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@user_id", pid);
        cmd.Parameters.AddWithValue("@email", pemail);
        cmd.Parameters.AddWithValue("@address", paddress);
        cmd.Parameters.AddWithValue("@phone_number", pphoneno);
        cmd.Parameters.AddWithValue("@month", pmonth);
        cmd.Parameters.AddWithValue("@gender", pgender);
        cmd.Parameters.AddWithValue("@email_status", pverification);

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }

    public List<Customer> getCustomerSearch(string tid)
    {
        List<Customer> customersearchlist = new List<Customer>();

        string username, email, address, password, phonenumber, month, gender, email_status, email_code;

        string queryStr = "SELECT * FROM [User] where user_id like '" + tid + "%'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            username = dr["user_id"].ToString();
            email = dr["email"].ToString();
            address = dr["address"].ToString();
            password = dr["password"].ToString();
            phonenumber = dr["phone_number"].ToString();
            month = dr["month"].ToString();
            gender = dr["gender"].ToString();
            email_status = dr["email_status"].ToString();
            email_code = dr["email_code"].ToString();
            Customer a = new Customer(username, email, address, password, phonenumber, month, gender, email_status, email_code);
            customersearchlist.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return customersearchlist;
    }
}