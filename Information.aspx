<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Information.aspx.cs" Inherits="Information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style14 {
            width: 357px;
        }

        .auto-style15 {
            width: 268px;
        }

        .auto-style16 {
            width: 357px;
            height: 39px;
        }

        .auto-style17 {
            width: 268px;
            height: 39px;
        }

        .auto-style18 {
            height: 39px;
        }
                         .btnorder {
  background-color: white; 
  color: black; 
  border: 2px solid  lightcoral ;
  margin-top: 0px;
}

.btnorder:hover {
  background-color: lightcoral;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <table class="auto-style2">
        <tr>
            <td class="auto-style14">
                <asp:CheckBox ID="cb_others" runat="server" Text="Sending to someone else" OnCheckedChanged="cb_others_CheckedChanged"  AutoPostBack="true" />
            </td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Recipient Name</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_Name" runat="server" placeholder="Enter your Name"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_name" runat="server"    ControlToValidate="tb_Name" ErrorMessage="Please enter your name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Recipient Address</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_Address" runat="server" placeholder="Enter your Address" ></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_address" runat="server"   ControlToValidate="tb_Address" ErrorMessage="Please enter your address" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Recipient Email</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_Email" runat="server" placeholder="Enter your email" pattern="[^ @]*@[^ @]*"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_email" runat="server" ControlToValidate="tb_Email" ErrorMessage="Please enter your email" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Recipient Contact</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_Contact" runat="server" MaxLength="8"  placeholder="Enter your phone number" ></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_cardtype" runat="server" ControlToValidate="rbl_cardtype" ErrorMessage="Please choose the card you are using" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Card Type</td>
            <td class="auto-style15">
                <asp:RadioButtonList ID="rbl_cardtype" runat="server">
                    <asp:ListItem>American Express</asp:ListItem>
                    <asp:ListItem>Master Card</asp:ListItem>
                    <asp:ListItem>Visa</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_cardname" runat="server"   ControlToValidate="tb_CardName" ErrorMessage="Please enter your card name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Name on Card</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_CardName" runat="server" placeholder="Enter your Card name"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_contact" runat="server" ControlToValidate="tb_Contact" ErrorMessage="Please enter your contact number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Card Number</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_CardNum" runat="server" MaxLength="16" placeholder="Enter your Card Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_cardexpiry" runat="server" ControlToValidate="tb_CardExpiry" ErrorMessage="Please enter your card expiry" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Card Expiry Date</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_CardExpiry" runat="server" placeholder="DD/MM/YY" MaxLength="10"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_cardnum" runat="server" ControlToValidate="tb_CardNum" ErrorMessage="Please enter your card number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Card CVV</td>
            <td class="auto-style15">
                <asp:TextBox ID="tb_CardCVV" runat="server" MaxLength="3" placeholder="Enter your Card CVV Numbers"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_cardCW" runat="server" ControlToValidate="tb_CardCVV" ErrorMessage="Please enter your card CW" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style17">
                <asp:Button Cssclass="btnorder" ID="btn_PlaceOrder" runat="server" OnClick="Button1_Click" Text="Place Order" />
            </td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

