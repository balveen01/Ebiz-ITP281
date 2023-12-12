<%@ Page Language="C#" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="ResetPassword.aspx.cs" Inherits="ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 593px;
        }
                .btnrp {
  background-color: white; 
  color: black; 
  border: 2px solid highlight ;
  margin-top: 0px;
  font-size:20px;
}

.btnrp:hover {
  background-color: Highlight;
  color: white;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="99px" ImageUrl="~/pics/Company Name.png" Width="342px" />
        <br />
        <br />
        <p style="font-size: 100px; line-height: 0px; text-align: center;">Reset Password</p>
        <br />

        <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="font-size:30px; line-height: 0px;">Username</td>
                <td>
                    <asp:Label ID="lbl_username" runat="server" style="font-size:24px;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-size:30px; line-height: 0px;">Password</td>
                <td>
                    <asp:TextBox ID="tb_password" runat="server" Height="30px" Width="345px" TextMode="Password"></asp:TextBox>
                    <asp:CheckBox ID="cb_see" runat="server" AutoPostBack="true" style="position:relative; right:22px;" OnCheckedChanged="cb_see_CheckedChanged"/>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_password" runat="server" ControlToValidate="tb_password" ErrorMessage="Please enter your new password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_password" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-size:30px; line-height: 0px;">Confirm Password</td>
                <td>
                    <asp:TextBox ID="tb_password2" runat="server" Height="30px" Width="345px" TextMode="Password"></asp:TextBox>
                    <asp:CheckBox ID="cb_see2" runat="server" AutoPostBack="true" style="position:relative; right:22px;" OnCheckedChanged="cb_see2_CheckedChanged"/>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_password2" runat="server" ControlToValidate="tb_password2" ErrorMessage="Please confirm your new password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tb_password2" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    
                    <asp:Button ID="btn_resetpassword" Cssclass="btnrp" runat="server" Text="Reset Password" OnClick="btn_resetpassword_Click"/>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
