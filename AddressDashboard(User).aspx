<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddressDashboard(User).aspx.cs" Inherits="AddressDashboard_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .btnchange {
            background-color: white;
            color: black;
            border: 2px solid aquamarine;
            margin-top: 0px;
        }

            .btnchange:hover {
                background-color: aquamarine;
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
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Change Address</p>-->
    <h1 style="text-align: center;">Change Address</h1>
    <div style="padding-bottom: 5%">
        <br />
        <p style="font-size: 22px; line-height: 0px;">New Address:</p>
        <asp:TextBox ID="tb_address" runat="server" Height="30px" Width="45%" Style="margin-bottom: 2%;"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="rfv_address" runat="server" ControlToValidate="tb_address" ErrorMessage="Please enter your address" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btn_change" CssClass="btnchange" runat="server" Text="Change" OnClick="btn_change_Click" />
        <asp:Button ID="btn_back" Text="Back" CssClass="btnba" runat="server" OnClick="btn_back_Click" Style="margin-left: 20px;" CausesValidation="False" />

    </div>
</asp:Content>

