//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Staff
/// </summary>
public class Staff
{
    string _connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;

    private string _staff_id = null;
    private string _name = null;
    private string _gender = null;
    private string _designation = null;
    private string _nric = null;
    private string _password = null;
    
    public Staff()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Staff(string staff_id, string name, string gender, string designation, string nric, string password)
    {
        _staff_id = staff_id;
        _name = name;
        _gender = gender;
        _designation = designation;
        _nric = nric;
        _password = password;

    }

    public Staff(string name, string gender, string designation, string nric, string password)
        : this(null, name, gender, designation, nric, password)
    {
    }

    public Staff(string staff_id)
        : this(staff_id, "", "", "", "", "")
    {
    }

    public string staff_id
    {
        get { return _staff_id; }
        set { _staff_id = value; }
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string gender
    {
        get { return _gender; }
        set { _gender = value; }
    }

    public string designation
    {
        get { return _designation; }
        set { _designation = value; }
    }

    public string nric
    {
        get { return _nric; }
        set { _nric = value; }
    }

    public string password
    {
        get { return _password; }
        set { _password = value; }
    }

    public Staff getStaff(string staff_id)
    {
        Staff staffinfo = null;

        string name, gender, designation, nric, password;

        string queryStr = "SELECT * FROM [Staff] WHERE staff_id = @staff_id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@staff_id", staff_id);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            name = dr["name"].ToString();
            gender = dr["gender"].ToString();
            designation = dr["designation"].ToString();
            nric = dr["nric"].ToString();
            password = dr["password"].ToString();


            staffinfo = new Staff(staff_id, name, gender, designation, nric, password);
        }
        else
        {
            staffinfo = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return staffinfo;
    }

    public List<Staff> getStaffAll()
    {
        List<Staff> stafflist = new List<Staff>();

        string staff_id, name, gender, designation, nric, password;

        string queryStr = "SELECT * FROM [Staff] Order by staff_id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            staff_id = dr["staff_id"].ToString();
            name = dr["name"].ToString();
            gender = dr["gender"].ToString();
            designation = dr["designation"].ToString();
            nric = dr["nric"].ToString();
            password = dr["password"].ToString();
            Staff a = new Staff(staff_id, name, gender, designation, nric, password);
            stafflist.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return stafflist;
    }

    public int StaffDelete(string staff_id)
    {
        string querystr = "DELETE FROM [Staff] WHERE staff_id = @staff_id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(querystr, conn);
        cmd.Parameters.AddWithValue("@staff_id", staff_id);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }

    public int StaffUpdate(string pid, string pname, string pgender, string pdesignation)
    {
        string queryStr = "UPDATE [Staff] SET " + "name = @name, " + "gender = @gender, " + "designation = @designation, " + "staff_id = @staff_id " + "WHERE staff_id = @staff_id";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@staff_id", pid);
        cmd.Parameters.AddWithValue("@name", pname);
        cmd.Parameters.AddWithValue("@gender", pgender);
        cmd.Parameters.AddWithValue("@designation", pdesignation);
        

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }

    public List<Staff> getstaffsearch(string tid)
    {
        List<Staff> staffsearchlist = new List<Staff>();

        string staff_id, name, gender, designation, nric, password;

        string queryStr = "SELECT * FROM [Staff] where staff_id like '" + tid + "%'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            staff_id = dr["staff_id"].ToString();
            name = dr["name"].ToString();
            gender = dr["gender"].ToString();
            designation = dr["designation"].ToString();
            nric = dr["nric"].ToString();
            password = dr["password"].ToString();
            Staff a = new Staff(staff_id, name, gender, designation, nric, password);
            staffsearchlist.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return staffsearchlist;
    }


    public int StaffInsert()
    {
        //string msg = null;
        int result = 0;

        string queryStr = "INSERT INTO [Staff] (staff_id, name, gender, designation, nric, password) values (@staff_id, @name, @gender, @designation, @nric, @password)";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@staff_id", this.staff_id);
        cmd.Parameters.AddWithValue("@name", this.name);
        cmd.Parameters.AddWithValue("@gender", this.gender);
        cmd.Parameters.AddWithValue("@designation", this.designation);
        cmd.Parameters.AddWithValue("@nric", this.nric);
        cmd.Parameters.AddWithValue("@password", this.password);

        conn.Open();
        result += cmd.ExecuteNonQuery();
        conn.Close();

        return result;
    }
}