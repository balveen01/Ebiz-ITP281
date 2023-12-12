using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Homepage_User_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_username.Text = (string)Session["Username"];
    }
}