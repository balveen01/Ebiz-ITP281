<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PhoneDashboard(User).aspx.cs" Inherits="PhoneDashboard_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
                 .btnc {
  background-color: white; 
  color: black; 
  border: 2px solid  mediumorchid ;
  margin-top: 0px;
}

.btnc:hover {
  background-color: mediumorchid;
  color: white;
}
                 .btnba {
  background-color: white; 
  color: black; 
  border: 2px solid  darkblue ;
  margin-top: 0px;
}

.btnba:hover {
  background-color: darkblue;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Change Phone Number</p>-->
    <h1 style="text-align: center;">Change Phone Number</h1>
    <div style="padding-bottom:5%">
        <p style="font-size: 22px; line-height: 0px;">New Phone Number:</p>
        <asp:TextBox ID="tb_phoneno" runat="server" Height="30px" Width="20%"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv_phoneno" runat="server" ControlToValidate="tb_phoneno" ErrorMessage="Please enter your phone number" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="rev_phoneno" runat="server" ControlToValidate="tb_phoneno" ErrorMessage="The phone number is invalid" ForeColor="Red" ValidationExpression="^[89]\d{7}$"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btn_change" Cssclass="btnc" runat="server" Text="Change" OnClick="btn_change_Click" />
        <asp:Button ID="btn_back" runat="server" CssClass="btnba" Text="Back" CausesValidation="False" OnClick="btn_back_Click" />
    </div>
</asp:Content>

