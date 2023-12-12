<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUpVerification(User).aspx.cs" Inherits="SignUpVerfication_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .btnnv {
  background-color: white; 
  color: black; 
  border: 2px solid darkturquoise ;
  margin-top: 0px;
}

.btnnv:hover {
  background-color: darkturquoise;
  color: white;
}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 70px; line-height: 0px; text-align: center;">Verfication</p>-->
    <h1 style="text-align: center;">Verification</h1>
    <div style="padding-bottom: 5%">
        <asp:Label ID="lbl_emailver" runat="server"></asp:Label>

        <p style="font-size: 22px; line-height: 0px; padding-top: 25px">Email Verification Code:</p>
        <asp:TextBox ID="tb_code" runat="server" Height="30px" Width="200px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv_code" runat="server" ControlToValidate="tb_code" ErrorMessage="Please enter your verification code" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbl_responsebad" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="lbl_responsegood" runat="server" ForeColor="Blue"></asp:Label>
        <br />
        <asp:Button ID="btn_verify" runat="server" Text="Verify" Cssclass="btnnv" OnClick="btn_verify_Click" />
    </div>

</asp:Content>

