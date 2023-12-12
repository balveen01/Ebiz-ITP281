<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="ChangePassword(Admin).aspx.cs" Inherits="ChangePassword_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 640px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="copyright">
        Change your password</h1>
    <br />
    <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Old Password</td>
            <td>
                <asp:TextBox ID="tb_passwordold" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CheckBox ID="cb_seeold" runat="server"  AutoPostBack="true" style="position:relative; right:22px;" OnCheckedChanged="cb_seeold_CheckedChanged"/>
                <br />
                    <asp:RequiredFieldValidator ID="rfv_password" runat="server" ControlToValidate="tb_passwordold" ErrorMessage="Please enter your old password" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_passwordold" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">New Password</td>
            <td>
                <asp:TextBox ID="tb_password1" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CheckBox ID="cb_see" runat="server"  AutoPostBack="true" style="position:relative; right:22px;" OnCheckedChanged="cb_see_CheckedChanged"/>
                <br />
                    <asp:RequiredFieldValidator ID="rfv_password0" runat="server" ControlToValidate="tb_password1" ErrorMessage="Please enter your new password" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tb_password1" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Confirm New Password</td>
            <td>
                <asp:TextBox ID="tb_password2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CheckBox ID="cb_see2" runat="server"  AutoPostBack="true" style="position:relative; right:22px;" OnCheckedChanged="cb_see2_CheckedChanged"/>
                <br />
                    <asp:RequiredFieldValidator ID="rfv_password1" runat="server" ControlToValidate="tb_password2" ErrorMessage="Please confirm your new password" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="tb_password2" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btn_change" runat="server" Text="Change Password" OnClick="btn_change_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

