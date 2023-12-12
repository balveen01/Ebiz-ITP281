<%@ Page Title="" Language="C#" MasterPageFile="~/Site(admin).master" AutoEventWireup="true" CodeFile="ProductView.aspx.cs" Inherits="ProductView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class ="gv1">
        <asp:GridView ID="gvProduct" runat="server" Height="201px" Width="1084px" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowEditing="gvProduct_RowEditing" OnRowUpdating="gvProduct_RowUpdating" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" DataKeyNames="Product_ID">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Product_ID" HeaderText="Product ID" />
                <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
                <asp:BoundField DataField="Unit_Price" HeaderText="Unit Price" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor=" #ff8080" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor=" #FADBD8" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor=" #FADBD8" ForeColor="#333333" />
            <SelectedRowStyle BackColor=" #FADBD8" Font-Bold="True" ForeColor="Navy" />
        </asp:GridView>
    </div>
</asp:Content>

