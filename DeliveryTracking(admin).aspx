<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="DeliveryTracking(admin).aspx.cs" Inherits="DeliveryTracking_admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            border-collapse: collapse;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="gvDelivery" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvDelivery_RowCancelingEdit" OnRowEditing="gvDelivery_RowEditing" OnRowUpdating="gvDelivery_RowUpdating" OnSelectedIndexChanged="gvDelivery_SelectedIndexChanged" CssClass="grid" Height="214px" Width="925px" DataKeyNames="Delivery_Id">
        <Columns>
            <asp:BoundField DataField="Delivery_Id" HeaderText="Delivery ID" />
            <asp:BoundField DataField="Delivery_Date" HeaderText="Delivery Date" />
            <asp:BoundField DataField="Delivery_Status" HeaderText="Delivery Status" />
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btn_Home" runat="server" OnClick="btn_Home_Click" Text="Back To Home" />
</asp:Content>

