<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="UpdateAlacarte(Admin).aspx.cs" Inherits="UpdateAlacarte_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            height: 27px;
        }
        .auto-style10 {
            width: 571px;
        }
        .auto-style11 {
            height: 27px;
            width: 571px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="text-align: center">Update Ala Carte Products</h1>

    <table class="w-100">
        <tr>
            <td class="auto-style10">ID</td>
            <td>
                <asp:Label ID="lbl_id" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Product Name</td>
            <td>
                <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">Unit Price</td>
            <td class="auto-style9">
                <asp:TextBox ID="tb_price" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

