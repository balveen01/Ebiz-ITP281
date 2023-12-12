using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class info : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   



    protected void btn_Insert_Click1(object sender, EventArgs e)
    {
        int result = 0;
        string image = "";
        if (FileUpload1.HasFile == true)
        {
            image = "Images\\" + FileUpload1.FileName;
        }
        //  Product prod = new Product(tb_ProductID.Text, tb_ProductName.Text, tb_ProductDesc.Text, decimal.Parse(tb_UnitPrice.Text), FileUpload1.FileName, int.Parse(tb_StockLevel.Text));
        Product prod = new Product(tb_ProductName.Text, tb_ProductDesc.Text,
        decimal.Parse(tb_UnitPrice.Text), image, int.Parse(tb_StockLevel.Text), tb_ProductCategory.Text);
        result = prod.ProductInsert();
        if (result > 0)
        {
            string saveimg = Server.MapPath(" ") + "\\" + image;
            //lbl_Result.Text = saveimg.ToString();
            FileUpload1.SaveAs(saveimg);
                 Response.Write("<script language='javascript'>window.alert('Insert Successful');window.location='AlacarteAdmin.aspx';</script>");
           // Response.Write("<sript>alert('Insert successful');</script>");
        }

        else
        {
            Response.Write("<sript>alert('Insert not successful');</script>");
        }
    }


}