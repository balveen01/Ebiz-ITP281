<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            margin-right: 0px;
        }
               .btnvv {
  background-color: white; 
  color: black; 
  border: 2px solid lightpink ;
  margin-top: 0px;
}

.btnvv:hover {
  background-color: lightpink;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="Product_ID" DataSourceID="SqlDataSource1" CssClass="auto-style9">
            <ItemTemplate>
                <br />
                <table class="auto-style2">
                    <tr>
                        <td rowspan="5">
                            <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("Product_Image") %>' Width="150px" />
                        </td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Unit_Price") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Quantity&nbsp;
                            <asp:TextBox ID="TextBox1" runat="server" Width="58px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Cssclass="btnvv" Text="ADD TO CART" Font-Size="small" />
                        </td>
                    </tr>
                </table>
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [Products] WHERE ([Product_ID] = @Product_ID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Product_ID" QueryStringField="id" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    </p>
</asp:Content>

