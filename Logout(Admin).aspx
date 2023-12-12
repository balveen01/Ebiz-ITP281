<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="Logout(Admin).aspx.cs" Inherits="Logout_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        table {
            border-collapse: collapse;
            height: 300px;
            margin-left: 150px;
            margin-right: 150px;
            border-right: 1px solid black;
            border-left: 1px solid black;
        }

        .whole {
            padding-bottom: 5%;
            padding-left: 7%;
            padding-top: 6%;
        }

        td {
            border-top: 1px solid black;
            border-bottom: 1px solid black;
            height: 75px;
        }

        table .header {
            width: 400px;
            font-size: 22px;
            font-weight: bold;
        }

        table .items {
            width: 900px;
            font-size: 19px;
            padding-left: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 80px; line-height: 0px; padding-left: 145px;">Personal Info<asp:Button ID="btn_logout" runat="server" Text="Logout" OnClick="btn_logout_Click" stlye="float:right;"/></p> -->
    <h1 style="text-align: center;">Personal Info</h1>
    <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="btn_logout_Click" Style="float: right; margin-right: 63px;" />
    <div class="whole">
        <table>
            <tr>
                <td class="header">Username</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_username"></asp:Label></td>
                <td></td>

            </tr>

            <tr>
                <td class="header">Name</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_name"></asp:Label></td>
                <td></td>

            </tr>

            <tr>
                <td class="header">NRIC</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_nric"></asp:Label></td>
                <td></td>

            </tr>
            <tr>
                <td class="header">Gender</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_gender"></asp:Label></td>
                <td></td>
            </tr>
            <tr>
                <td class="header">Password</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_password"></asp:Label></td>
                <td>
                    <asp:ImageButton ID="img_password" runat="server" ImageUrl="~/pics/arrow.jpg" Width="74px" Height="76px" OnClick="img_password_Click" /></td>
            </tr>
            <tr>
                <td class="header">Designation</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_designation"></asp:Label></td>
                <td></td>
        </table>
    </div>
    <br />







</asp:Content>

