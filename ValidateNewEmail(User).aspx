<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ValidateNewEmail(User).aspx.cs" Inherits="ValidateNewEmail_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <style type="text/css">

             .btnvvv {
            background-color: white; 
            color: black; 
            border: 2px solid palevioletred;          
}

        .btnvvv:hover {
            background-color: palevioletred;
            color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Verfication</p>-->
    <h1 style="text-align: center;">Verification</h1>

    <div style="padding-bottom:5%">
        <asp:Label ID="lbl_emailver" runat="server"></asp:Label>

        <p style="font-size: 22px; line-height: 0px; padding-top: 25px">Email Verification Code:</p>
        <asp:TextBox ID="tb_code" runat="server" Height="30px" Width="200px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv_code" runat="server" ControlToValidate="tb_code" ErrorMessage="Please enter your verification code" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbl_responsebad" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="lbl_responsegood" runat="server" ForeColor="Blue"></asp:Label>
        <br />

        <asp:Button ID="btn_verify" CssClass="btnvvv" runat="server" Text="Verify" OnClick="btn_verify_Click" />
    </div>
</asp:Content>

