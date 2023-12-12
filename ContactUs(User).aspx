<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs(User).aspx.cs" Inherits="ContactUs_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
                 .btnnsub {
  background-color: white; 
  color: black; 
  border: 2px solid darkcyan;
  margin-top: 0px;
}

.btnnsub:hover {
  background-color: darkcyan;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Contact Us</p>-->
    <h1 style="text-align: center;">Contact Us</h1>
    <br />
    <asp:Label ID="lbl_result" runat="server" ForeColor="Blue"></asp:Label>
    <br />
    <div style="padding-bottom: 5%; padding-left: 30%;">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Username</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tb_username" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_fname" runat="server" ControlToValidate="tb_username" ErrorMessage="Please enter your username" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Subject</td>
                <td class="auto-style4">
                    <asp:TextBox ID="tb_subject" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_lname" runat="server" ControlToValidate="tb_subject" ErrorMessage="Please enter the reason for contacting us" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <!--<td class="auto-style2">Email Address</td>
                <td>
                    <asp:TextBox ID="tb_email" runat="server" TextMode="Email"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="tb_email" ErrorMessage="Please enter you email address" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>-->
            </tr>
            <tr>
                <td class="auto-style2">Tell Us More</td>
                <td>
                    <asp:TextBox ID="tb_info" runat="server" TextMode="MultiLine" Height="190px" Width="287px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_info" runat="server" ControlToValidate="tb_info" ErrorMessage="Please tell us your problem" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_submit" Cssclass="btnnsub" runat="server" Text="Submit" OnClick="btn_submit_Click" style="margin-top:5%; margin-left:25%;"/>

                </td>

            </tr>
        </table>
    </div>
</asp:Content>

