//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for Faq
/// </summary>
public class Faq
{
    string _connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;

    private string _question_id = null;
    private string _question = null;
    private string _answer = null;
    private string _topic = null;

    public Faq()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Faq(string question_id, string question, string answer, string topic)
    {
        _question_id = question_id;
        _question = question;
        _answer = answer;
        _topic = topic;
    }

    public Faq(string question, string answer, string topic)
        : this(null, question, answer, topic)
    {
    }

    public Faq(string question_id)
        : this(question_id, "", "", "")
    {
    }

    public string question_id
    {
        get { return _question_id; }
        set { _question_id = value; }
    }

    public string question
    {
        get { return _question; }
        set { _question = value; }
    }

    public string answer
    {
        get { return _answer; }
        set { _answer = value; }
    }

    public string topic
    {
        get { return _topic; }
        set { _topic = value; }
    }

    public Faq getFaq(string question_id)
    {
        Faq faq = null;

        string question, answer, topic;

        string queryStr = "SELECT * FROM [FAQ] WHERE question_id = @question_id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@question_id", question_id);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            question = dr["question"].ToString();
            answer = dr["answer"].ToString();
            topic = dr["topic"].ToString();

            faq = new Faq(question_id, question, answer, topic);
        }
        else
        {
            faq = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return faq;
    }

    public List<Faq> getFaqAll()
    {
        List<Faq> faqlist = new List<Faq>();

        string question_id, question, answer, topic;

        string queryStr = "SELECT * FROM [FAQ] Order by question_id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            question_id = dr["question_id"].ToString();
            question = dr["question"].ToString();
            answer = dr["answer"].ToString();
            topic = dr["topic"].ToString();

            Faq a = new Faq(question_id, question, answer, topic);
            faqlist.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return faqlist;
    }



    public int FaqDelete(string question_id)
    {
        string querystr = "DELETE FROM [FAQ] WHERE question_id = @question_id";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(querystr, conn);
        cmd.Parameters.AddWithValue("@question_id", question_id);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }

    public int FaqUpdate(string ptopic, string pquestion_id, string pquestion, string panswer)
    {
        string queryStr = "UPDATE [FAQ] SET " + "topic = @topic, " + "question = @question, " + "answer = @answer " + "WHERE question_id = @question_id";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@topic", ptopic);
        cmd.Parameters.AddWithValue("@question_id", pquestion_id);
        cmd.Parameters.AddWithValue("@question", pquestion);
        cmd.Parameters.AddWithValue("@answer", panswer);
        

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }

    public List<Faq> getFaqSearch(string tid)
    {
        List<Faq> faqsearchlist = new List<Faq>();

        string question_id, question, answer, topic;

        string queryStr = "SELECT * FROM [FAQ] where topic = '" + tid + "'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            question_id = dr["question_id"].ToString();
            question = dr["question"].ToString();
            answer = dr["answer"].ToString();
            topic = dr["topic"].ToString();

            Faq a = new Faq(question_id, question, answer, topic);
            faqsearchlist.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return faqsearchlist;
    }

}