using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

/// <summary>
/// Summary description for Delivery
/// </summary>
public class Delivery
{

    string connStr = ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString;
    private string _Delivery_Id = null;
    private string _Delivery_Date = "";
    private string _Delivery_Status = "";
    private string _Delivery_Address = "";

    public Delivery()
    {

    }

    public Delivery(string Delivery_Id, string Delivery_Date, string Delivery_Status, string Delivery_Address)
    {
        _Delivery_Id = Delivery_Id;
        _Delivery_Date = Delivery_Date;
        _Delivery_Status = Delivery_Status;
        _Delivery_Address = Delivery_Address;
    }

    public Delivery(string Delivery_Date, string Delivery_Status, string Delivery_Address)
        : this(null, Delivery_Date, Delivery_Status, Delivery_Address)
    {

    }

    public Delivery(string Delivery_Id)
        : this(Delivery_Id, "", "", "")
    {

    }

    public string Delivery_Id
    {
        get { return _Delivery_Id; }
        set { _Delivery_Id = value; }
    }

    public string Delivery_Date
    {
        get { return _Delivery_Date; }
        set { _Delivery_Date = value; }
    }

    public string Delivery_Status
    {
        get { return _Delivery_Status; }
        set { _Delivery_Status = value; }
    }

    public string Delivery_Address
    {
        get { return _Delivery_Address; }
        set { _Delivery_Address = value; }
    }

    public Delivery getDelivery(string Delivery_Id)
    {
        Delivery DeliveryDetail = null;
        string Delivery_Date, Delivery_Status;
        string queryStr = "SELECT * FROM Delivery WHERE Delivery_Id = @Delivery_Id";
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Delivery_Id", Delivery_Id);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Check if there are any resultsets
        if (dr.Read())
        {
            Delivery_Date = dr["Delivery_Date"].ToString();
            Delivery_Status = dr["Delivery_Status"].ToString();
            Delivery_Address = dr["Delivery_Address"].ToString();
            DeliveryDetail = new Delivery(Delivery_Id, Delivery_Date, Delivery_Status, Delivery_Address);
        }
        else
        {
            DeliveryDetail = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return DeliveryDetail;
    }

    public List<Delivery> getDeliveryAll()
    {
        List<Delivery> DeliveryList = new List<Delivery>();

        string Delivery_Date, Delivery_Status;
        string queryStr = "SELECT * FROM Delivery";
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Delivery_Id = dr["Delivery_Id"].ToString();
            Delivery_Date = dr["Delivery_Date"].ToString();
            Delivery_Status = dr["Delivery_Status"].ToString();
            Delivery_Address = dr["Delivery_Address"].ToString();

            Delivery a = new Delivery(Delivery_Id, Delivery_Date, Delivery_Status, Delivery_Address);
            DeliveryList.Add(a);
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return DeliveryList;
    }

    public int DeliveryInsert()
    {
        //string msg = null;
        int result = 0;
        string queryStr = "INSERT INTO Delivery(Delivery_Id,Delivery_Date, Delivery_Status,Delivery_Address)"
            + "values (@Delivery_Id,@Delivery_Date, @Delivery_Status, @Delivery_Address)";

        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Delivery_Id", Delivery_Id);
        cmd.Parameters.AddWithValue("@Delivery_Date", Delivery_Date);
        cmd.Parameters.AddWithValue("@Delivery_Status", Delivery_Status);
        cmd.Parameters.AddWithValue("@Delivery_Address", Delivery_Address);

        conn.Open();
        result += cmd.ExecuteNonQuery();
        conn.Close();

        return result;
    }

    public int DeliveryDelete(string Delivery_Id)
    {
        string queryStr = "DELETE  FROM Delivery WHERE Delivery_Id=@Delivery_Id";
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Delivery_Id", Delivery_Id);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }

    public int DeliveryUpdate(string pId, string pDate, string pStatus, string pAddress)
    {
        string queryStr = "UPDATE Delivery SET " +
             "Delivery_Status = @Delivery_Status " +
            " WHERE Delivery_Id = @Delivery_Id";

        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Delivery_Id", pId);
        cmd.Parameters.AddWithValue("@Delivery_Date", pDate);
        cmd.Parameters.AddWithValue("@Delivery_Status", pStatus);
        cmd.Parameters.AddWithValue("@Delivery_Address", pAddress);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }
    public string getLatLong(string Delivery_Address, string Zipcode)
    {
        string latlong = "", address = "";
        if (Delivery_Address != string.Empty)
        {
            address = "http://maps.googleapis.com/maps/api/geocode/xml?address=" + Delivery_Address + "&sensor=false";
        }
        else
        {
            address = "http://maps.googleapis.com/maps/api/geocode/xml?components=postal_code:" + Zipcode.Trim() + "&sensor=false";
        }
        var result = new System.Net.WebClient().DownloadString(address);
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(result);
        XmlNodeList parentNode = doc.GetElementsByTagName("location");
        var lat = "";
        var lng = "";
        foreach (XmlNode childrenNode in parentNode)
        {
            lat = childrenNode.SelectSingleNode("lat").InnerText;
            lng = childrenNode.SelectSingleNode("lng").InnerText;
        }
        latlong = Convert.ToString(lat) + "," + Convert.ToString(lng);
        return latlong;
    }
}