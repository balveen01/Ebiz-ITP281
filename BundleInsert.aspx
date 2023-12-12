<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="BundleInsert.aspx.cs" Inherits="BundleInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">
         .btnin {
  background-color: white; 
  color: black; 
  border: 2px solid cornflowerblue ;
  margin-top: 0px;
}

.btnin:hover {
  background-color: cornflowerblue;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Bundle Name</td>
            <td>
                <asp:TextBox ID="tb_Name" runat="server" CssClass="form-check-label"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_name" runat="server" ControlToValidate="tb_Name" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Bundle Description</td>
            <td>
                <asp:TextBox ID="tb_Desc" runat="server" CssClass="form-check-label" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_desc" runat="server" ControlToValidate="tb_Desc" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Unit Price</td>
            <td>
                <asp:TextBox ID="tb_UnitPrice" runat="server" CssClass="form-check-label"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_unitprice" runat="server" ControlToValidate="tb_UnitPrice" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Stock Level</td>
            <td>
                <asp:TextBox ID="tb_StockLevel" runat="server" CssClass="form-check-label"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_stocklevel" runat="server" ControlToValidate="tb_StockLevel" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>FIle Image</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_image" runat="server" ControlToValidate="FileUpload1" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Bundle_Category</td>
            <td>
                <asp:TextBox ID="tb_Category" runat="server" CssClass="form-check-label"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_category" runat="server" ControlToValidate="tb_Category" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btn_Insert" CssClass="btnin" runat="server" OnClick="btn_Insert_Click" Text="Insert" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

