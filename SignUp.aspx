<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style type="text/css">
        .response {
            padding-left: 550px;
            font-size: 25px;
        }

        .whole {
            padding-left: 20%;
            padding-top: 5%;
            padding-bottom: 5%;
        }

        td {
            padding-bottom: 15px;
        }
        .topbottom 
        {
            padding-top:7%; 
        }

        @media screen and (max-width: 1300px) {

            .response {
                padding-left: 0px;
            }
        }

        .auto-style1 {
            padding-left: 500px;
        }
               .btnca {
  background-color: white; 
  color: black; 
  border: 2px solid khaki ;
  margin-top: 0px;
}

.btnca:hover {
  background-color: khaki;
  color: white;
}
    </style>
    <div class="topbottom">


        <p style="font-size: 70px; line-height: 0px; text-align: center;">New Account</p>

        <asp:Label runat="server" ID="lbl_repsonse" ForeColor="Red" CssClass="response"></asp:Label>

        <div class="whole">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">
                            UserName:
                        <asp:Label ID="lbl_username" runat="server" ForeColor="Red"></asp:Label>
                        </p>
                        <asp:TextBox ID="tb_username" runat="server" Height="35px" Width="258px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfv_username" runat="server" ControlToValidate="tb_username" ErrorMessage="Please enter a username" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="rev_phoneno0" runat="server" ControlToValidate="tb_username" ErrorMessage="The username is invalid" ForeColor="Red" ValidationExpression="^([a-zA-Z0-9!@#$%^&amp;*()-_=+;:'&quot;|~`&lt;&gt;?/{}]{3,16})$"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">Email:</p>
                        <asp:TextBox ID="tb_email" runat="server" Height="35px" Width="258px" TextMode="Email"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="tb_email" ErrorMessage="Please enter your email" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="rev_phoneno1" runat="server" ControlToValidate="tb_email" ErrorMessage="The email address is invalid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">Address:</p>
                        <asp:TextBox ID="tb_address" runat="server" Height="35px" Width="258px"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfv_address" runat="server" ControlToValidate="tb_address" ErrorMessage="Please enter your address" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                    </td>
                    <td>
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">Mobile Number:</p>
                        <asp:TextBox ID="tb_phoneno" runat="server" Height="35px" Width="258px" TextMode="Phone" CssClass="auto-style3"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfv_phoneno" runat="server" ControlToValidate="tb_phoneno" ErrorMessage="Please enter your phone number" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="rev_phoneno" runat="server" ControlToValidate="tb_phoneno" ErrorMessage="The phone number is invalid" ForeColor="Red" ValidationExpression="^[89]\d{7}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">
                            Password:
                        <asp:Label ID="lbl_password1" runat="server" ForeColor="Red"></asp:Label>
                        </p>
                        <asp:TextBox ID="tb_password" runat="server" Height="35px" Width="258px" TextMode="Password"></asp:TextBox>
                        <asp:CheckBox ID="cb_see" runat="server" OnCheckedChanged="cb_see_CheckedChanged" AutoPostBack="true" Style="position: relative; right: 22px;" />

                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_password" ErrorMessage="Please enter a password" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_password" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">
                            Confirm Password:
                        <asp:Label ID="lbl_password2" runat="server" ForeColor="Red"></asp:Label>
                        </p>
                        <asp:TextBox ID="tb_password2" runat="server" Height="35px" Width="258px" TextMode="Password"></asp:TextBox>
                        <asp:CheckBox ID="cb_see2" runat="server" AutoPostBack="true" OnCheckedChanged="cb_see2_CheckedChanged" Style="position: relative; right: 22px;" />

                        <br />
                        <asp:RequiredFieldValidator ID="rfv_password2" runat="server" ControlToValidate="tb_password2" ErrorMessage="Please enter your password to confirm" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="rev_password2" runat="server" ControlToValidate="tb_password2" ErrorMessage="6 - 15 Characters with a combination of upper and lower casing" ForeColor="Red" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">Birthday Month:</p>
                        <asp:DropDownList ID="ddl_month" runat="server" Style="height: 35px; width: 258px;">
                            <asp:ListItem>-- Select --</asp:ListItem>
                            <asp:ListItem>01</asp:ListItem>
                            <asp:ListItem>02</asp:ListItem>
                            <asp:ListItem>03</asp:ListItem>
                            <asp:ListItem>04</asp:ListItem>
                            <asp:ListItem>05</asp:ListItem>
                            <asp:ListItem>06</asp:ListItem>
                            <asp:ListItem>07</asp:ListItem>
                            <asp:ListItem>08</asp:ListItem>
                            <asp:ListItem>09</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator ID="rfv_month" runat="server" ControlToValidate="ddl_month" ErrorMessage="Please choose a month" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="cpv_month" runat="server" ControlToValidate="ddl_month" ErrorMessage="Please select a choice" ForeColor="Red" Operator="NotEqual" ValueToCompare="-- Select --"></asp:CompareValidator>
                    </td>
                    <td>
                        <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">Gender:</p>
                        <asp:RadioButtonList ID="rb_gender" runat="server">
                            <asp:ListItem Value="F" style="font-size: 20px; line-height: 0px;">Female</asp:ListItem>
                            <asp:ListItem Value="M" style="font-size: 20px; line-height: 0px;">Male</asp:ListItem>
                        </asp:RadioButtonList>

                        <asp:RequiredFieldValidator ID="rfv_gender" runat="server" ControlToValidate="rb_gender" ErrorMessage="Please choose a gender" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button Style="font-size: 26px; border-radius: 25px; margin-left: 28%;" Cssclass="btnca" ID="btn_signup" runat="server" Text="Create Account" Height="41px" Width="209px" OnClick="btn_signup_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>






</asp:Content>

