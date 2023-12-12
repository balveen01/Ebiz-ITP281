using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BShower : System.Web.UI.Page
{
    AProduct aProd = new AProduct();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            DataList1.DataSourceID = null;
            DataList1.DataSource = sqldatasource1;
            DataList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataList1.DataSourceID = null;
        if (RadioButtonList1.SelectedItem.Text == "Low to High Price")
        {

            DataList1.DataSource = sqldatasource1;
            DataList1.DataBind();
        }
        else
        {

            DataList1.DataSource = sqlDataSource2;
            DataList1.DataBind();
        }
    }
}
