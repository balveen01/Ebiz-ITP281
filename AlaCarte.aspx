<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AlaCarte.aspx.cs" Inherits="AlaCarte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            height: 1087px;
        }
        .btn2view {
  background-color: white; 
  color: black; 
  border: 2px solid cadetblue;
  margin-top: 0px;
}

.btn2view:hover {
  background-color: cadetblue;
  color: white;
}
        .btnsearch {
  background-color: white; 
  color: black; 
  border: 2px solid aqua;
  margin-top: 0px;
}

.btnsearch:hover {
  background-color: aqua;
  color: white;
}
.btnboth {
  background-color: white; 
  color: black; 
  border: 2px solid aliceblue;
  margin-top: 0px;
}

.btnboth:hover {
  background-color: aliceblue;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <asp:Button ID="Button1" runat="server" Cssclass="btnsearch" Text="Search" align="right" OnClick="Button1_Click" />
        <asp:TextBox ID="tb_Search" runat="server" align="right"></asp:TextBox>
        <asp:Label ID="lbl_Search" runat="server"></asp:Label>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Sub_Category" Width="196px">
            <asp:CheckBoxList ID="chkCountries" runat="server">
                <asp:ListItem>Kids</asp:ListItem>
                <asp:ListItem>Teens</asp:ListItem>
                <asp:ListItem>Young Adults</asp:ListItem>
                <asp:ListItem>Adults</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Panel ID="Panel2" runat="server" GroupingText="Sort Product by:" Width="196px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="UNIT_PRICE">Low to High Price</asp:ListItem>
                    <asp:ListItem Value="UNIT_PRICE DESC">High to Low Price</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
            <asp:Button ID="btn_both" Cssclass="btnboth" runat="server" Text="Filter" OnClick="btn_both_Click" />
        </asp:Panel>
        <br />
     
         <asp:DataList ID="DataList1" runat="server" DataKeyField="Product_ID" DataSourceID="SqlDataSource1" RepeatColumns="3" Width="1292px" OnItemCommand="DataList1_ItemCommand" RepeatDirection="Horizontal">
             <ItemTemplate>
                 <br />
                 <table class="w-100">
                     <tr>
                         <td>
                             <asp:ImageButton ID="ImageButton1" runat="server" Height="210px" ImageUrl='<%# Eval("Product_Image") %>' Width="192px" CommandArgument='<%# Eval("Product_ID") %>' CommandName="ProductDetails"  />
                         </td>
                     </tr>
                     <tr>
                         <td>&nbsp;</td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="Label4" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
                         </td>
                     </tr>
                 </table>
                 <asp:Label ID="Label5" runat="server" Text='<%# Eval("Unit_Price") %>'></asp:Label>
                 <br />
                 <asp:Button ID="Button2" Cssclass="btn2view" runat="server" Text="View" CommandName="ProductDetails" CommandArgument='<%# Eval("Product_ID") %>'  />
                 <br />
             </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
    
   
</asp:Content>

