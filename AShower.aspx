<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AShower.aspx.cs" Inherits="AShower" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <style type="text/css">

.btnboth1 {
  background-color: white; 
  color: black; 
  border: 2px solid  aquamarine ;
  margin-top: 0px;
}

.btnboth1:hover {
  background-color: aquamarine;
  color: white;
}
        .btn1search {
  background-color: white; 
  color: black; 
  border: 2px solid chartreuse ;
  margin-top: 0px;
}

.btn1search:hover {
  background-color: chartreuse;
  color: white;
}
</style>
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
        
  
  
        
  
        <br />
        <asp:Button ID="Button1" runat="server" Cssclass="btn1search" Text="Search" align="right" OnClick="Button1_Click" />
        <asp:TextBox ID="tb_Search" runat="server" align="right"></asp:TextBox>
        <asp:Label ID="lbl_Search" runat="server"></asp:Label><br /><br />
        <asp:Panel ID="Panel1" runat="server" GroupingText="Sub Category" Width="196px">
            <asp:CheckBoxList ID="chkCountries" runat="server">
                <asp:ListItem>Baby</asp:ListItem>
                <asp:ListItem>Bridal</asp:ListItem>
            </asp:CheckBoxList>
            <br /><br />
            <asp:Panel ID="Panel2" runat="server" GroupingText="Sort Product by Price:" Width="196px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="UNIT_PRICE">Low to High</asp:ListItem>
                    <asp:ListItem Value="UNIT_PRICE DESC">High to Low</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel><br />
            <br />
            <asp:Button ID="btn_both" runat="server" Cssclass="btnboth1" Text="Filter" OnClick="btn_both_Click" Height="28px" Width="109px" />
            <br /><br />
        </asp:Panel>
        <br />
        <br />
     
         <asp:DataList ID="DataList1" runat="server" DataKeyField="Product_ID" DataSourceID="SqlDataSource1" RepeatColumns="3" Width="1292px" OnItemCommand="DataList1_ItemCommand" RepeatDirection="Horizontal">
             <ItemTemplate>
                 <table class="w-100">
                     <tr>
                         <td>
                             <asp:Image ID="Image1" runat="server" Height="152px" ImageUrl='<%# Eval("Product_Image") %>' Width="215px" />
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
                     <tr>
                         <td>
                             <asp:Label ID="Label5" runat="server" Text='<%# Eval("Unit_Price") %>'></asp:Label>
                         </td>
                     </tr>
                 </table>
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
             </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [AShower]"></asp:SqlDataSource>
        <br />
        <br />
   
        
   
</asp:Content>
