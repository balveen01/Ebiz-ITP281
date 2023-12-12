<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FgtPassword(User).aspx.cs" Inherits="FgtPassword_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .bigname 
        {
            font-size:100px; 
            line-height: 0px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 360px;
            font-size:30px; 
            line-height: 0px;
        }
        .auto-style3 {
            width: 360px;
            height: 33px;
            font-size:30px; 
            line-height: 0px;
        }
        .auto-style4 {
            height: 33px;
        }

        @media screen and (max-width: 750px) {
            .bigname {
                font-size:50px;     
            }
        }
                         .btnforgot {
  background-color: white; 
  color: black; 
  border: 2px solid  dodgerblue ;
  margin-top: 0px;
}

.btnforgot:hover {
  background-color: dodgerblue;
  color: white;
}
                 .btnback {
  background-color: white; 
  color: black; 
  border: 2px solid  indigo ;
  margin-top: 0px;
}

.btnback:hover {
  background-color: indigo;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--<p class="bigname">Forgot Password</p>-->
    <h1 style="text-align:center;">Forgot Password</h1>
    <table class="auto-style1">
        <tr>
            <td style="font-size:22px; line-height: 0px;">Registered Email</td>
            <td>
                <asp:TextBox ID="tb_fgtemail" runat="server" Height="30px" Width="25%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="tb_fgtemail" ErrorMessage="Please enter your registered email" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btn_fgtpassword" CssClass="btnforgot" runat="server" Text="Forgot Password" OnClick="btn_fgtpassword_Click"/>
                <asp:Button ID="btn_back" Cssclass="btnback" runat="server" Text="Back" OnClick="btn_back_Click" CausesValidation="False"/>
                <br />
                <br />
                <asp:Label ID="lbl_info" runat="server" ForeColor="Blue"></asp:Label>
                
            </td>
        </tr>
    </table>
</asp:Content>

