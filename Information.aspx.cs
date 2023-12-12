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

public partial class Information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tb_Name.Text = (string)Session["Username"];
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
            con.Open();
            string q = "Select user_id, email, address, phone_number from [User] where user_id = '" + tb_Name.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                tb_Email.Text = dr["email"].ToString();
                tb_Address.Text = dr["address"].ToString();
                tb_Contact.Text = dr["phone_number"].ToString();
            }
            con.Close();
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        if (rbl_cardtype.Text == "American Express")
        {
            if (tb_CardNum.Text.Substring(0, 2) == "34" || rbl_cardtype.Text.Substring(0, 2) == "37")
            {
                if (tb_CardNum.Text.Length == 15)
                {
                    int result = 0;

                    string userid = (string)Session["Username"];
                    string orderName = tb_Name.Text;
                    string orderAddress = tb_Address.Text;
                    string paymenttype = rbl_cardtype.Text;
                    string orderEmail = tb_Email.Text;
                    string orderCardName = tb_CardName.Text;
                    string orderContact = tb_Contact.Text;
                    string orderCardNum = tb_CardNum.Text;
                    string discountid = (string)Session["discountid"];
                    double subtotal = 45.67;
                    double deliveryfee = 34.78;
                    double grandtotal = 34.56;
                    string status = "Processing";


                    Orders ord = new Orders(DateTime.Now, userid, paymenttype, orderAddress, orderEmail, orderContact, orderCardNum, double.Parse(subtotal.ToString()), double.Parse(deliveryfee.ToString()), discountid, double.Parse(grandtotal.ToString()), status);

                    result = ord.OrderInsert();
                    if (result > 0)
                    {
                        sendorder("Your order will sent to you in 5-10 business days. Thank you for shopping with us!", tb_Email.Text);
                        Response.Redirect("Confirmation.aspx?CustName=" + userid);
                        //Session["email"] = tb_Email.Text;
                        //string information = null;





                        //Response.Write("<script language='javascript'>window.alert('Your order has been confirmed!');window.location='Confirmation.aspx?CustName='" + userid + ";</script>");
                        //  Response.Redirect("Confirm.aspx" + queryString);
                    }

                    else
                    {
                        Response.Write("<script language='javascript'>window.alert('Your order has not been confirmed!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Card number is wrong');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Card number is wrong');</script>");
            }
        }

        if (rbl_cardtype.Text == "Master Card")
        {
            if (tb_CardNum.Text.Substring(0, 2) == "51" || rbl_cardtype.Text.Substring(0, 2) == "52" || rbl_cardtype.Text.Substring(0, 2) == "53" || rbl_cardtype.Text.Substring(0, 2) == "54" || rbl_cardtype.Text.Substring(0, 2) == "55")
            {
                if (tb_CardNum.Text.Length == 16)
                {
                    int result = 0;

                    string userid = (string)Session["Username"];
                    string orderName = tb_Name.Text;
                    string orderAddress = tb_Address.Text;
                    string paymenttype = rbl_cardtype.Text;
                    string orderEmail = tb_Email.Text;
                    string orderCardName = tb_CardName.Text;
                    string orderContact = tb_Contact.Text;
                    string orderCardNum = tb_CardNum.Text;

                    string discountid = (string)Session["discountid"];
                    double subtotal = 45.67;
                    double deliveryfee = 34.78;
                    double grandtotal = 34.56;
                    string status = "Processing";

                    Orders ord = new Orders(DateTime.Now, userid, paymenttype, orderAddress, orderEmail, orderContact, orderCardNum, double.Parse(subtotal.ToString()), double.Parse(deliveryfee.ToString()), discountid, double.Parse(grandtotal.ToString()), status);

                    result = ord.OrderInsert();
                    if (result > 0)
                    {
                        sendorder("Your order will sent to you in 5-10 business days. Thank you for shopping with us!", tb_Email.Text);
                        Response.Redirect("Confirmation.aspx?CustName=" + userid);

                        //Response.Write("<script language='javascript'>window.alert('Your order has been confirmed!');window.location='Confirmation.aspx?CustName='" + userid + ";</script>");
                        //  Response.Redirect("Confirm.aspx" + queryString);
                    }

                    else
                    {
                        Response.Write("<script language='javascript'>window.alert('Your order has not been confirmed!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Card number is wrong');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Card number is wrong');</script>");
            }
        }
        if (rbl_cardtype.Text == "Visa")
        {
            if (tb_CardNum.Text.Substring(0, 1) == "4")
            {
                if (tb_CardNum.Text.Length == 16)
                {

                    int result = 0;
                    string userid = tb_Name.Text;
                    string orderAddress = tb_Address.Text;
                    string paymenttype = rbl_cardtype.Text;
                    string orderEmail = tb_Email.Text;
                    string orderCardName = tb_CardName.Text;
                    string orderContact = tb_Contact.Text;
                    string orderCardNum = tb_CardNum.Text;

                    string discountid = (string)Session["discountid"];
                    double subtotal = 45.67;
                    double deliveryfee = 34.78;
                    double grandtotal = 34.56;
                    string status = "Processing";

                    Orders ord = new Orders(DateTime.Now, userid, paymenttype, orderAddress, orderEmail, orderContact, orderCardNum, double.Parse(subtotal.ToString()), double.Parse(deliveryfee.ToString()), discountid, double.Parse(grandtotal.ToString()), status);

                    result = ord.OrderInsert();
                    if (result > 0)
                    {
                        sendorder("Your order will sent to you in 5-10 business days. Thank you for shopping with us!", tb_Email.Text);
                        Response.Redirect("Confirmation.aspx?CustName=" + userid);
                        //Response.Write("<script language='javascript'>window.alert('Your order has been confirmed!');window.location='Confirmation.aspx?CustName=" + userid + ";</script>");
                        //  Response.Redirect("Confirm.aspx" + queryString);
                    }

                    else
                    {
                        // Response.Write("<script>alert('Your order has not been confirmed!');</script>");
                        Response.Write("<script language='javascript'>window.alert('Your order has not been confirmed!');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Card number is wrong!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Card number is wrong');</script>");
            }

        }
    }

    private void sendorder(String Information, String email)
    {
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("partietycompany@gmail.com", "!123Party");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = "Order Confirmation (Partiety)";
        msg.Body = "Dear " + tb_Name.Text + "," + Information + "\n\n\nThanks & Regards\nPartiety";
        string toaddress = tb_Email.Text;
        msg.To.Add(toaddress);
        string fromaddress = "Partiety <partietycompany@gmail.com>";
        msg.From = new MailAddress(fromaddress);
        try
        {
            smtp.Send(msg);


        }
        catch
        {
            throw;
        }
    }

    protected void cb_others_CheckedChanged(object sender, EventArgs e)
    {
        if (cb_others.Checked)
        {
            tb_Name.Text = "";
            tb_Address.Text = "";
            rbl_cardtype.Text = "";
            tb_Email.Text = "";
            tb_Contact.Text = "";
        }
        else
        {
            tb_Name.Text = (string)Session["Username"];
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PartietyContext"].ConnectionString);
            con.Open();
            string q = "Select user_id, email, address, phone_number from [User] where user_id = '" + tb_Name.Text + "'";

            SqlCommand query = new SqlCommand(q, con);
            SqlDataReader dr = query.ExecuteReader();

            if (dr.Read())
            {
                tb_Email.Text = dr["email"].ToString();
                tb_Address.Text = dr["address"].ToString();
                tb_Contact.Text = dr["phone_number"].ToString();
            }
            con.Close();
        }
    }
}



