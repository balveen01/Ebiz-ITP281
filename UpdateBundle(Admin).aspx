<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="UpdateBundle(Admin).aspx.cs" Inherits="UpdateBundle_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 527px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 style="text-align: center">Update Bundle</h1>
    <table class="w-100">
        <tr>
            <td class="auto-style9">ID</td>
            <td>
                <asp:Label ID="lbl_id" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Bundle Name</td>
            <td>
                <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Unit Price</td>
            <td>
                <asp:TextBox ID="tb_price" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" Text="Update" />

            </td>
        </tr>
    </table>
</asp:Content>

