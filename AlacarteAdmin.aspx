<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="AlacarteAdmin.aspx.cs" Inherits="Admin" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <style type="text/css"> 

.btninsertpro {
  background-color: white; 
  color: black; 
  border: 2px solid antiquewhite ;
  margin-top: 0px;
}

.btninsertpro:hover {
  background-color: antiquewhite;
  color: white;
}
    </style> 
    <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_Name" OnRowCancelingEdit="gvProduct_RowCancellingEdit" OnRowDeleting="gvProduct_RowDeleting" OnRowEditing="gvProduct_RowEditing" OnRowUpdating="gvProduct_RowUpdating" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" Width="777px" BorderColor="#FFC9C9" CellPadding="15">
        <AlternatingRowStyle BackColor="#FADBD8" />
    <Columns>
        <asp:BoundField DataField="Product_ID" HeaderText="ID" />
        <asp:BoundField DataField="Product_Name" HeaderText="Name" />
        <asp:BoundField DataField="Unit_Price" HeaderText="Unit Price" />
        <asp:TemplateField ShowHeader="False">
            <EditItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this record?');"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    <br />
    <asp:Button ID="Insert_Product" CssClass="btninsertpro" runat="server" Text="Insert Product" OnClick="Insert_Product_Click" />
    <br />
    <br />
</asp:Content>

