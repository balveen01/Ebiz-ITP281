
<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="UpdateCustomer(Admin).aspx.cs" Inherits="UpdateCustomer_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 522px;
        }

        .auto-style3 {
            width: 560px;
        }
        .auto-style9 {
            width: 522px;
            height: 27px;
        }
        .auto-style10 {
            width: 560px;
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Update Customer Particulars</p>-->
    <h1 style="text-align: center;">Update Customer Particulars</h1>
    <br />
    <div style="padding-bottom: 5%; padding-left:27%;">
        <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style9">User ID</td>
                <td class="auto-style10">
                    <asp:Label ID="lbl_userid" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email Address</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tb_address" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Mobile Number</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tb_phoneno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Birthday Month</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddl_month" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddl_gender" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email Verification</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddl_verification" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>Verified</asp:ListItem>
                        <asp:ListItem>Unverified</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" Text="Update" style="margin-left:28%;"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

