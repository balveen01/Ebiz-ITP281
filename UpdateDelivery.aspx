<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="UpdateDelivery.aspx.cs" Inherits="UpdateDelivery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p>
        Delivery ID :<asp:Label ID="lbl_Did" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Delivery Date:<asp:Label ID="lbl_Ddate" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Delivery Status:<asp:TextBox ID="tb_Dstatus" runat="server"></asp:TextBox>
    </p>
    <p>
        Delivery Address: <asp:Label ID="lbl_Daddress" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:Button ID="btn_Update" runat="server" OnClick="btn_Update_Click" Text="Update" />
</asp:Content>

