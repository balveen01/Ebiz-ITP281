using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for Feedbacks
/// </summary>
public class Feedbacks
{

    string connStr = ConfigurationManager.ConnectionStrings["Partiety2Context"].ConnectionString;
    private string _Feedback_Id = null;
    private string _feedback = "";
    private string _FeedbackUsername = "";
    private string  _Feedback_Rating = "";

    public Feedbacks()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Feedbacks(string FeedbackID, string FeedbackUsername, string Ffeedback, string Feedback_Rating)
    {
        _Feedback_Id = FeedbackID;
        _FeedbackUsername = FeedbackUsername;
        _feedback = Ffeedback;
        _Feedback_Rating = Feedback_Rating;
    }

    public Feedbacks( string FeedbackUsername, string Ffeedback, string Feedback_Rating)
        :this(null, FeedbackUsername, Ffeedback, Feedback_Rating)
    {

    }

    public Feedbacks(string Feedback_Id)
        :this(Feedback_Id,"","","")
    {

    }

    public string FeedbackID
    {
        get { return _Feedback_Id; }
        set { _Feedback_Id = value; }
    }

    public string FeedbackUsername
    {
        get { return _FeedbackUsername; }
        set { _FeedbackUsername = value; }
    }

    public string Ffeedback
    {
        get { return _feedback; }
        set { _feedback = value; }
    }

   
    public string Feedback_Rating
    {
        get { return _Feedback_Rating; }
        set { _Feedback_Rating = value; }
    }

    public Feedbacks getFeedback(string Feedback_Id)
    {
        Feedbacks FeedbackDetail = null;
        string FeedbackUsername, Ffeedback,  Feedback_Rating;
        string queryStr = "SELECT * FROM Feedback WHERE Feedback_Id = @Feedback_Id";
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Feedback_Id", Feedback_Id);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        //Check if there are any resultsets
        if (dr.Read())
        {
            FeedbackUsername = dr["FeedbackUsername"].ToString();
            Ffeedback = dr["Ffeedback"].ToString();
            Feedback_Rating = dr["Feedback_Rating"].ToString();
            FeedbackDetail = new Feedbacks(Feedback_Id, FeedbackUsername, Feedback_Rating);
        }
        else
        {
            FeedbackDetail = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return FeedbackDetail;
    }

    public List<Feedbacks> getFeedbackAll()
    {
        List<Feedbacks> FeedbackList = new List<Feedbacks>();

        string FeedbackUsername, Feedback_Rating;

        string queryStr = "SELECT * FROM Feedback";
        //cmd.Parameters.AddWithValue("@Feedback_Id",FeedbackID);
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            FeedbackUsername = dr["FeedbackUsername"].ToString();
            Ffeedback = dr["Ffeedback"].ToString();
            Feedback_Rating =dr["Feedback_Rating"].ToString();

            Feedbacks a = new Feedbacks(FeedbackUsername, Ffeedback, Feedback_Rating);
            FeedbackList.Add(a);
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return FeedbackList;
    }

    public int FeedbackInsert()
    {
        //string msg = null;
        int result = 0;
        string queryStr = "INSERT INTO Feedback(Feedback_Id,FeedbackUsername, Ffeedback,Feedback_Rating)"
            + "values (@Feedback_Id,@FeedbackUsername, @Ffeedback, @Feedback_Rating)";

        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Feedback_Id", _Feedback_Id);
        cmd.Parameters.AddWithValue("@FeedbackUsername", FeedbackUsername);
        cmd.Parameters.AddWithValue("@Ffeedback", Ffeedback);
        cmd.Parameters.AddWithValue("@Feedback_Rating", _Feedback_Rating);

        conn.Open();
        result += cmd.ExecuteNonQuery();
        conn.Close();

        return result;
    }

    public List<Feedbacks> getFeedbackSearch(string fid)
    {
        List<Feedbacks> FeedbackSearchList = new List<Feedbacks>();

        string FeedbackUsername, Feedback_Rating;

        string queryStr = "SELECT * FROM Feedback WHERE Feedback_Rating = '"+ fid + "'";
        //cmd.Parameters.AddWithValue("@Feedback_Id",FeedbackID);
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            FeedbackUsername = dr["FeedbackUsername"].ToString();
            Ffeedback = dr["Ffeedback"].ToString();
            Feedback_Rating = dr["Feedback_Rating"].ToString();

            Feedbacks a = new Feedbacks(FeedbackUsername, Ffeedback, Feedback_Rating);
            FeedbackSearchList.Add(a);
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return FeedbackSearchList;
    }
}