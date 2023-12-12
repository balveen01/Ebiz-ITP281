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
public class Venue
{

    //private string _connStr = Properties.Settings.Default.DBConnStr;
    string _connStr = ConfigurationManager.ConnectionStrings["productdb"].ConnectionString;
    private string _venueId = null;
    private string _venueName = string.Empty;
    private string _venueDesc = ""; // this is another way to specify empty string
    private string _venueLink = "";
    private int _venueCap = 0;
    private string _venueImage = "";
  

    // Default constructor
    public Venue()
    {
    }

    // Constructor that take in all data required to build a Product object
    public Venue(string venueId, string venueName, string venueDesc, string venueLink,
                   int venueCap, string venueImage)
    {
        _venueId = venueId;
        _venueName = venueName;
        _venueDesc = venueDesc;
        _venueCap = venueCap;
        _venueImage = venueImage;
        _venueLink = venueLink;
       
    }

    // Constructor that take in all except product ID
    public Venue(string venueName, string venueDesc,
           int venueCap, string venueImage, string venueLink)
        : this(null, venueName, venueDesc, venueLink, venueCap, venueImage)
    {
    }

    // Constructor that take in only Product ID. The other attributes will be set to 0 or empty.
    public Venue(string venueId)
        : this(venueId, "", "", "",0, "")
    {
    }

    // Get/Set the attributes of the Product object.
    // Note the attribute name (e.g. Product_ID) is same as the actual database field name.
    // This is for ease of referencing.
    public string venue_id
    {
        get { return _venueId; }
        set { _venueId = value; }
    }
    public string venue_name
    {
        get { return _venueName; }
        set { _venueName = value; }
    }
    public string venue_desc
    {
        get { return _venueDesc; }
        set { _venueDesc = value; }
    }
    public int venue_cap
    {
        get { return _venueCap; }
        set { _venueCap = value; }
    }
    public string venue_img
    {
        get { return _venueImage; }
        set { _venueImage = value; }
    }
    public string venue_link
    {
        get { return _venueLink; }
        set { _venueLink = value; }
    }


    //Below as the Class methods for some DB operations. 
    //We will revisit these section in our next practical
    public int VenueInsert()
    {
        string msg = null;
        int result = 0;
        string queryStr = "INSERT INTO Venue(venue_id,venue_name, venue_desc, venue_cap, venue_img, venue_link)"
 + "values (@venue_id,@venue_name, @venue_desc, @venue_cap, @venue_img, @venue_link)";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@venue_id", this.venue_id);
        cmd.Parameters.AddWithValue("@venue_name", this.venue_name);
        cmd.Parameters.AddWithValue("@venue_desc", this.venue_desc);
        cmd.Parameters.AddWithValue("@venue_cap", this.venue_cap);
        cmd.Parameters.AddWithValue("@venue_img", this.venue_img);
        cmd.Parameters.AddWithValue("@venue_link", this.venue_link);
        conn.Open();
        result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
        conn.Close();
        return result;
    }

    public int VenueDelete(string id)
    {
        string queryStr = "DELETE FROM Veune WHERE venue_id=@id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end Delete

    public int VenueUpdate(string vId, string vName, string vLink, int vCap)
    {
        string queryStr = "UPDATE Venue SET" +
//" venue_id = @venueId, " +
" venue_name = @venueName, " +
" venue_cap = @venueCap " +
"venue_link = @venueLink" +
" WHERE venue_id = @venueId";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@venueId", vId);
        cmd.Parameters.AddWithValue("@venueName", vName);
        cmd.Parameters.AddWithValue("@venueLink", vLink);
        cmd.Parameters.AddWithValue("@venuecap", vCap);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end Update
    public Venue getVenue(string venueId)
    {
        Venue venueDetail = null;

        string venue_Name, venue_Desc, venue_Image, venue_Link;
        int venue_Cap;
        string queryStr = "SELECT * FROM Venue WHERE venue_id = @venueId";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@venueId", venueId);
        conn.Open();
        SqlDataReader pr = cmd.ExecuteReader();
        //Check if there are any resultsets
        if (pr.Read())
        {
            venue_Name = pr["venue_name"].ToString();
            venue_Desc = pr["venue_desc"].ToString();
            venue_Link = pr["venue_link"].ToString();
            venue_Image = pr["venue_img"].ToString();
            venue_Cap = int.Parse(pr["venue_cap"].ToString());
            venueDetail = new Venue (venueId, venue_Name, venue_Desc,venue_Link, venue_Cap, venue_Image);
        }
        else
        {
            venueDetail = null;
        }
        conn.Close();
        pr.Close();
        pr.Dispose();
        return venueDetail;
    }

    public List<Venue> getVenueAll()
    {
        List<Venue> venueList = new List<Venue>();
        string venue_Name, venue_Desc, venue_Image, venue_Id, venue_Link;
        int venue_Cap;
        string queryStr = "SELECT * FROM Venue Order By venue_name";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader pr = cmd.ExecuteReader();
        //Continue to read the resultsets row by row if not the end
        while (pr.Read())
        {
            venue_Id = pr["venue_id"].ToString();
            venue_Name = pr["venue_name"].ToString();
            venue_Desc = pr["venue_desc"].ToString();
            venue_Link = pr["venue_link"].ToString();
            venue_Image = pr["venue_img"].ToString();
            venue_Cap = int.Parse(pr["venue_cap"].ToString());
            Venue a = new Venue(venue_Id, venue_Name, venue_Desc,venue_Link, venue_Cap, venue_Image);
            venueList.Add(a);
        }
        conn.Close();
        pr.Close();
        pr.Dispose();
        return venueList;
    }

}//end of class

