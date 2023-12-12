//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Text;

public partial class StaffInsert_Admin_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_insert_Click(object sender, EventArgs e)
    {
        int result = 0;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
        conn.Open();

        string checkstaff = "SELECT count(*) from [Staff] where staff_id = '" + tb_staffid.Text + "'";
        SqlCommand comm = new SqlCommand(checkstaff, conn);
        int temps = Convert.ToInt32(comm.ExecuteScalar().ToString());

        if (temps == 1)
        {
            //lbl_response.Text = "Username is taken.Please choose another username";
            Response.Write("<script>alert('Staff ID is taken. Please choose another staff ID');</script>");
        }
        else
        {
            //string subString1 = tb_nric.Text.Substring(0, 3);
            if (tb_nric.Text.Substring(0, 1).ToUpper() == "T")
            {
                int nric1 = int.Parse(tb_nric.Text.Substring(1, 1));
                int nric2 = int.Parse(tb_nric.Text.Substring(2, 1));
                int nric3 = int.Parse(tb_nric.Text.Substring(3, 1));
                int nric4 = int.Parse(tb_nric.Text.Substring(4, 1));
                int nric5 = int.Parse(tb_nric.Text.Substring(5, 1));
                int nric6 = int.Parse(tb_nric.Text.Substring(6, 1));
                int nric7 = int.Parse(tb_nric.Text.Substring(7, 1));

                int no1 = nric1 * 2;
                int no2 = nric2 * 7;
                int no3 = nric3 * 6;
                int no4 = nric4 * 5;
                int no5 = nric5 * 4;
                int no6 = nric6 * 3;
                int no7 = nric7 * 2;

                int sum = (no1 + no2 + no3 + no4 + no5 + no6 + no7) + 4;
                sum = 11 - (sum % 11);

                if (sum == 1 && tb_nric.Text.Substring(8, 1).ToUpper() == "A")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 11 && tb_nric.Text.Substring(8, 1).ToUpper() == "J")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 2 && tb_nric.Text.Substring(8, 1).ToUpper() == "B")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 3 && tb_nric.Text.Substring(8, 1).ToUpper() == "C")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 4 && tb_nric.Text.Substring(8, 1).ToUpper() == "D")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 5 && tb_nric.Text.Substring(8, 1).ToUpper() == "E")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 6 && tb_nric.Text.Substring(8, 1).ToUpper() == "F")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                  true);
                }
                else if (sum == 7 && tb_nric.Text.Substring(8, 1).ToUpper() == "G")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 8 && tb_nric.Text.Substring(8, 1).ToUpper() == "H")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 9 && tb_nric.Text.Substring(8, 1).ToUpper() == "I")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 10 && tb_nric.Text.Substring(8, 1).ToUpper() == "Z")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else
                {
                    //lbl_response.Text = "NRIC is invalid";
                    Response.Write("<script>alert('NRIC is Invalid');</script>");
                }

            }
            else if (tb_nric.Text.Substring(0, 1).ToUpper() == "S")
            {
                int nric1 = int.Parse(tb_nric.Text.Substring(1, 1));
                int nric2 = int.Parse(tb_nric.Text.Substring(2, 1));
                int nric3 = int.Parse(tb_nric.Text.Substring(3, 1));
                int nric4 = int.Parse(tb_nric.Text.Substring(4, 1));
                int nric5 = int.Parse(tb_nric.Text.Substring(5, 1));
                int nric6 = int.Parse(tb_nric.Text.Substring(6, 1));
                int nric7 = int.Parse(tb_nric.Text.Substring(7, 1));

                int no1 = nric1 * 2;
                int no2 = nric2 * 7;
                int no3 = nric3 * 6;
                int no4 = nric4 * 5;
                int no5 = nric5 * 4;
                int no6 = nric6 * 3;
                int no7 = nric7 * 2;

                int sum = no1 + no2 + no3 + no4 + no5 + no6 + no7;

                sum = sum % 11;

                if (sum == 1 && tb_nric.Text.Substring(8, 1).ToUpper() == "Z")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                  true);
                }
                else if (sum == 0 && tb_nric.Text.Substring(8, 1).ToUpper() == "J")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                  true);
                }
                else if (sum == 2 && tb_nric.Text.Substring(8, 1).ToUpper() == "I")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                  (this, this.GetType(),
                  "alert",
                  "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                  true);
                }
                else if (sum == 3 && tb_nric.Text.Substring(8, 1).ToUpper() == "H")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 4 && tb_nric.Text.Substring(8, 1).ToUpper() == "G")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 5 && tb_nric.Text.Substring(8, 1).ToUpper() == "F")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 6 && tb_nric.Text.Substring(8, 1).ToUpper() == "E")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 7 && tb_nric.Text.Substring(8, 1).ToUpper() == "D")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 8 && tb_nric.Text.Substring(8, 1).ToUpper() == "C")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 9 && tb_nric.Text.Substring(8, 1) == "B")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 10 && tb_nric.Text.Substring(8, 1).ToUpper() == "A")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else if (sum == 11 && tb_nric.Text.Substring(8, 1).ToUpper() == "J")
                {
                    string connStr = ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString;
                    string addstaff = "INSERT into Staff(staff_id, name, gender, designation, nric, password) values('" + tb_staffid.Text + "' , '" + tb_name.Text + "', '" + ddl_gender.Text + "', '" + ddl_designation.Text + "', '" + tb_nric.Text + "', '" + tb_nric.Text + "')";
                    SqlConnection con = new SqlConnection(connStr);
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = addstaff;
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    ScriptManager.RegisterStartupScript
                   (this, this.GetType(),
                   "alert",
                   "alert('Staff Added!');window.location ='Staff(Admin).aspx';",
                   true);
                    //Response.Redirect("Staff(Admin).aspx");
                }
                else
                {
                    //lbl_response.Text = "NRIC is invalid";
                    Response.Write("<script>alert('NRIC is Invalid');</script>");
                }
            }
            else
            {
                //lbl_response.Text = "NRIC is invalid";
                Response.Write("<script>alert('NRIC is Invalid');</script>");
            }
        }
    }
}

