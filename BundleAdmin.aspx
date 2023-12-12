<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="BundleAdmin.aspx.cs" Inherits="BundleAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
        <asp:GridView ID="gv_Bundle" runat="server" AutoGenerateColumns="False" BorderColor="#FFC9C9" Width="777px" OnRowDeleting="gv_Bundle_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" DataKeyNames="Bundle_ID">
            <AlternatingRowStyle BackColor="#FFC9C9" />
            <Columns>
                <asp:BoundField DataField="Bundle_ID" HeaderText="ID" />
                <asp:BoundField DataField="Bundle_Name" HeaderText="Name" />
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
        <asp:Button ID="btn_InsertBundle" runat="server" Text="Insert Bundle" OnClick="btn_InsertBundle_Click" />
        <br />
   <br />
</asp:Content>

