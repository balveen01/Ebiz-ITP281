<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="ProductInsert.aspx.cs" Inherits="info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style14 {
            width: 635px;
        }
        .auto-style15 {
            width: 514px;
        }

       .btniii {
  background-color: white; 
  color: black; 
  border: 2px solid chocolate ;
  margin-top: 0px;
}

.btniii:hover {
  background-color: chocolate;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <table class="auto-style2">
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">Product Name</td>
            <td class="auto-style14">
    <asp:TextBox ID="tb_ProductName" runat="server"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="rfv_productname" runat="server" ControlToValidate="tb_ProductName" ErrorMessage="Please enter the product name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Product Description</td>
            <td class="auto-style14">
    <asp:TextBox ID="tb_ProductDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="rfv_productdesc" runat="server" ControlToValidate="tb_ProductDesc" ErrorMessage="Please enter the product description" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Unit Price</td>
            <td class="auto-style14">
    <asp:TextBox ID="tb_UnitPrice" runat="server"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="rfv_unitprice" runat="server" ControlToValidate="tb_UnitPrice" ErrorMessage="Please enter the unitprice" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">StockLevel</td>
            <td class="auto-style14">
    <asp:TextBox ID="tb_StockLevel" runat="server" ></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="rfv_stocklevel" runat="server" ControlToValidate="tb_StockLevel" ErrorMessage="Please enter your name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">File Image</td>
            <td class="auto-style14">
    <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td>
            <asp:RequiredFieldValidator ID="rfv_image" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Please choose an image" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">Product Category</td>
            <td class="auto-style14">
    <asp:TextBox ID="tb_ProductCategory" runat="server" ></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="rfv_category" runat="server" ControlToValidate="tb_ProductCategory" ErrorMessage="Please choose product category" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style14">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style14">
    <asp:Button ID="btn_Insert" runat="server" Cssclass="btniii" Text="Insert" OnClick="btn_Insert_Click1" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
</asp:Content>

