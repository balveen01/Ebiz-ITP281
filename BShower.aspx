<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BShower.aspx.cs" Inherits="BShower" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style22{
            text-align: center;
            font-size: xx-large;
        }
               .btnfilter1 {
  background-color: white; 
  color: black; 
  border: 2px solid blanchedalmond;
  margin-top: 0px;
}

.btnfilter1:hover {
  background-color: blanchedalmond;
  color: white;
}
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <br />
    <br />
    <br />
    <p class="auto-style22">Shower</p>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Sort Product By:" Width="178px">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="179px">
                <asp:ListItem>Low to High Price</asp:ListItem>
                <asp:ListItem>High to Low Price</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
        <asp:Button ID="Button1" runat="server" Cssclass="btnfilter1" OnClick="Button1_Click" Text="Filter" />
        <br />
    <p>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="Bundle_ID" DataSourceID="sqldatasource2" RepeatColumns="3" CellPadding="33" RepeatDirection="Horizontal">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" Height="232px" ImageUrl='<%# Eval("Bundle_Image") %>' />
                <br />
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("Bundle_Name") %>'></asp:Label>
                <br />
                <asp:Label ID="Label5" runat="server" Text='<%# Eval("Unit_Price") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
    </p>

     <p>
        <asp:sqldatasource id="sqldatasource1" runat="server" connectionstring="<%$ ConnectionStrings:HealthDBContext %>" selectcommand="SELECT * FROM [BShowers] ORDER BY [Unit_Price]"></asp:sqldatasource>
         <asp:SqlDataSource ID="sqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [BShowers] ORDER BY [Unit_Price] DESC"></asp:SqlDataSource>
    </p>
  
</asp:Content>

