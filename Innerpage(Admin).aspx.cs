//Done by Balveen Kaur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Homepage_Admin_ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_staffid.Text = (string)Session["Username"];
    }
}