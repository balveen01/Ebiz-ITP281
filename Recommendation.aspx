<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Recommendation.aspx.cs" Inherits="Recommendation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

.btnview1 {
  background-color: white; 
  color: black; 
  border: 2px solid salmon;
  margin-top: 0px;
}

.btnview1:hover {
  background-color: salmon;
  color: white;
}
.btnview2 {
  background-color: white; 
  color: black; 
  border: 2px solid lightcoral;
}

.btnview2:hover {
  background-color: lightcoral;
  color: white;
}

</style>

    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    Recommended Venue<br />
    <asp:DataList ID="DataList2" runat="server" DataKeyField="venue_id" DataSourceID="SqlDataSource2" RepeatColumns="3" CellPadding="33">
        <ItemTemplate>
            <table class="w-100">
                <tr>
                    <td class="auto-style10">
                        <asp:Image ID="Image1" runat="server" Height="180px" Width="200px" ImageUrl='<%# Eval("venue_img") %>' />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("venue_id") %>'></asp:Label>
            <br />
            <asp:Label ID="lbl_name" runat="server" Text='<%# Eval("venue_name") %>'></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" CssClass="btnview2" width="100px" runat="server" OnClick="Button2_Click" CustomParameter='<%# Eval("Venue_id") %>' Text="View" />
            <br />
        </ItemTemplate>
    </asp:DataList>

    <br />
    Products<br />
    <asp:DataList ID="DataList1" runat="server" DataKeyField="Product_ID" DataSourceID="SqlDataSource1" RepeatColumns="3" CellPadding="33">
        <ItemTemplate>
            <table class="w-100">
                <tr>
                    <td class="auto-style10">
                        <asp:Image ID="Image1" runat="server" Height="180px" Width="200px" ImageUrl='<%# Eval("Product_Image") %>' />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Product_ID") %>'></asp:Label>
            <br />
            <asp:Label ID="lbl_name" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" CssClass="btnview1" Width="100px" runat="server" OnClick="Button1_Click" Text="View" CustomParameter='<%# Eval("Product_Name") %>'/>
            <br />
        </ItemTemplate>
    </asp:DataList>

    
</asp:Content>

