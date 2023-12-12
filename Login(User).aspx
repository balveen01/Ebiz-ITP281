<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login(User).aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style type="text/css">
        .whole {
            width: 100%;
            height: 500px;
            padding-left: 15%;
            padding-top:7%;
        }

        .firstpart {
            height: 450px;
            width: 410px;
            float: left;
        }

        .second {
            float: left;
            background-color: #DDE8E2;
            width: 467px;
            height: 275px;
            margin-bottom: 50px;
        }

        @media screen and (max-width: 1300px) {
            .firstpart {
                padding-left: 0px;
            }
        }

        @media screen and (max-width: 1300px) {
            .firstpart {
                padding-left: 0px;
                width: 100%;
            }

            .second {
                width: 100%;
            }
        }

                         .btnlog {
  background-color: white; 
  color: black; 
  border: 2px solid  lightblue ;
  margin-top: 0px;
}

.btnlog:hover {
  background-color: lightblue;
  color: white;
}
                 .btncreate {
  background-color: white; 
  color: black; 
  border: 2px solid  lightsalmon ;
  margin-top: 0px;
}

.btncreate:hover {
  background-color: lightsalmon;
  color: white;
}
    </style>
    <div class="whole">
        <div class="firstpart">
            <p style="font-size: 70px; line-height: 0px; padding-bottom: 70px">Login</p>
            <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
            <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">Username:</p>
            <asp:TextBox ID="tb_username" runat="server" Height="30px" Width="83%"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfv_username" runat="server" ControlToValidate="tb_username" ErrorMessage="Please enter your username" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <p style="font-size: 30px; line-height: 0px; padding-bottom: 15px;">Password:</p>
            <asp:TextBox ID="tb_password" runat="server" Height="30px" Width="83%" TextMode="Password"></asp:TextBox>
            <asp:CheckBox ID="cb_see" runat="server"  AutoPostBack="true" Style="position: relative; right: 22px;" OnCheckedChanged="cb_see_CheckedChanged" />


            <br />
            <asp:RequiredFieldValidator ID="rfv_password" runat="server" ControlToValidate="tb_password" ErrorMessage="Please enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btn_login" Cssclass="btnlog" runat="server" Text="Login" OnClick="btn_login_Click" />
            &nbsp;<asp:HyperLink ID="hy_fgtpassword" runat="server" NavigateUrl="~/FgtPassword(User).aspx">Forgot Password</asp:HyperLink>
        </div>


        <div class="second">
            <h5 style="font-size: 30px; display: inline;">&nbsp New Customer?</h5>
            <p style="font-size: 20px;">&nbsp Create an account with us and you'll be able to:</p>
            <ul>
                <li>Check out faster</li>
                <li>Save multiple party ideas</li>
                <li>Access your order history</li>
                <li>Track new orders</li>
            </ul>
            <asp:Button ID="btn_createAccount" Cssclass="btncreate" runat="server" Text="Create Account" OnClick="btn_createAccount_Click" CausesValidation="false" Style="margin-left: 20px" />

        &nbsp;</div>

    </div>
    <br />

</asp:Content>

