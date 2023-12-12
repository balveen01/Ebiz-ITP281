<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmailDashboard(User).aspx.cs" Inherits="EmailDashboard_User_" %>

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
        <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Change Email Address</p>-->
    <h1 style="text-align: center;">Change Email Address</h1>
    <div style="padding-bottom:5%;">
        <p style="font-size: 22px; line-height: 0px;">New Email Address:</p>
        <asp:TextBox ID="tb_email" runat="server" Height="30px" Width="25%" ></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="tb_email" ErrorMessage="Please enter your email address" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
                    <asp:RegularExpressionValidator ID="rev_phoneno1" runat="server" ControlToValidate="tb_email" ErrorMessage="The email address is invalid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btn_change" Cssclass="btnc" Text="Change" runat="server" OnClick="btn_change_Click" />
        <asp:Button ID="btn_back" Text="Back" CssClass="btnba" runat="server" OnClick="btn_back_Click" style="margin-left:20px;" CausesValidation="False"/>
    </div>
</asp:Content>

