
<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="UpdateStaff(Admin).aspx.cs" Inherits="UpdateStaff_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 370px;
        }

        .auto-style3 {
            width: 370px;
            height: 31px;
        }

        .auto-style5 {
            width: 385px;
        }

        .auto-style6 {
            height: 31px;
            width: 385px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Update Staff Particulars</p>-->
    <h1 style="text-align: center">Update Staff Particulars</h1>
    <br />
    <div style="padding-bottom: 5%; padding-left:27%;">
        <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
        <br />

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Staff ID</td>
                <td class="auto-style5">
                    <asp:Label ID="lbl_staffid" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Name</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddl_gender" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Designation</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddl_designation" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>Manager</asp:ListItem>
                        <asp:ListItem>Supervisor</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">NRIC</td>
                <td class="auto-style6">
                    <asp:Label ID="lbl_nric" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" style="margin-left:28%;"/>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

