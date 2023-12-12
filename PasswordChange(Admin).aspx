<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="PasswordChange(Admin).aspx.cs" Inherits="PasswordChange_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Change Password</p>-->
    <h1 style="text-align: center;">Change Password</h1>
    <br />
    <asp:Label ID="lbl_result" runat="server" ForeColor="Red" Style="padding-left: 40px; font-size: 30px;"></asp:Label>
    <br />
    <div style="padding-bottom: 5%;">
        <p style="font-size: 20px; line-height: 0px;">Old Password:</p>
        <asp:TextBox ID="tb_passwordold" runat="server" Height="30px" Width="345px" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="cb_seeold" runat="server" AutoPostBack="true" Style="position: relative; right: 22px;" OnCheckedChanged="cb_seeold_CheckedChanged" />
        <br />
        <asp:RequiredFieldValidator ID="rfv_passwordold" runat="server" ControlToValidate="tb_passwordold" ErrorMessage="Please enter your old password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />

        <p style="font-size: 20px; line-height: 0px;">New Password:</p>
        <asp:TextBox ID="tb_password" runat="server" Height="30px" Width="345px" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="cb_see" runat="server" AutoPostBack="true" Style="position: relative; right: 22px;" OnCheckedChanged="cb_see_CheckedChanged" />

        <br />
        <asp:RequiredFieldValidator ID="rfv_password" runat="server" ControlToValidate="tb_password" ErrorMessage="Please enter your new password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="rev_password" runat="server" ControlToValidate="tb_password" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
        <br />

        <p style="font-size: 20px; line-height: 0px;">Confrim New Password:</p>
        <asp:TextBox ID="tb_password2" runat="server" Height="30px" Width="345px" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="cb_see2" runat="server" AutoPostBack="true" Style="position: relative; right: 22px;" OnCheckedChanged="cb_see2_CheckedChanged" />
        <br />
        <asp:RequiredFieldValidator ID="rfv_password2" runat="server" ControlToValidate="tb_password2" ErrorMessage="Please confirm your new password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="rev_password2" runat="server" ControlToValidate="tb_password2" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btn_change" runat="server" Text="Change" OnClick="btn_change_Click" />
        <asp:Button ID="btn_back" runat="server" Text="Back" CausesValidation="False" OnClick="btn_back_Click" />

    </div>

</asp:Content>

