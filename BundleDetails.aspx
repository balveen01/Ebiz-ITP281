<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BundleDetails.aspx.cs" Inherits="BundleDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 50px;
        }
        .auto-style11 {
            width: 93%
        }
         .btnn {
  background-color: white; 
  color: black; 
  border: 2px solid burlywood ;
  margin-top: 0px;
}

.btnn:hover {
  background-color: burlywood;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 

     
        <asp:DataList ID="DataList1" runat="server" DataKeyField="Bundle_ID" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <table class="auto-style11">
                    <tr>
                        <td class="auto-style10" rowspan="5">
                            <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("Bundle_Image") %>' Width="150px" />
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Bundle_Name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("Unit_Price") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Quantity<asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="ADD TO CART" OnClick="Button1_Click" Cssclass="btnn" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [Bundles] WHERE ([Bundle_ID] = @Bundle_ID)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Bundle_ID" QueryStringField="id" />
            </SelectParameters>
        </asp:SqlDataSource>

     
</asp:Content>

