using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BWedding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            DataList1.DataSourceID = null;
            DataList1.DataSource = SqlDataSource1;
            DataList1.DataBind();
        }
    }

    protected void Btn_filter_Click(object sender, EventArgs e)
    {
        DataList1.DataSourceID = null;
        if (RaioButtonList2.SelectedItem.Text == "Low to High Price")
        {

            DataList1.DataSource = SqlDataSource1;
            DataList1.DataBind();
        }
        else
        {

            DataList1.DataSource = SqlDataSource2;
            DataList1.DataBind();
        }
    }
}