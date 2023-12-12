<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        .auto-style4 {
            width: 297px;
        }

        .auto-style5 {
            width: 829px;
        }

        .auto-style10 {
            width: 212px;
            height: 141px;
        }
        .auto-style11 {
            width: 212px;
            height: 160px;
            margin-top: 6px;
        }
        .auto-style12 {
            width: 871px;
            height: 93px;
        }
        .auto-style13 {
            width: 139px;
            height: 93px;
            margin-top: 6px;
        }
        .auto-style14 {
            width: 139px;
            height: 160px;
            margin-top: 6px;
        }
        .auto-style15 {
            width: 871px;
            height: 160px;
        }
        .auto-style16 {
            width: 139px;
            height: 141px;
            margin-top: 6px;
        }
        .auto-style17 {
            width: 871px;
            height: 141px;
        }
        .auto-style18 {
            height: 414px;
        }
                         .btnsu {
  background-color: white; 
  color: black; 
  border: 2px solid  gold ;
  margin-top: 0px;
}

.btnsu:hover {
  background-color: gold;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>FEEDBACK</h1>
    <table class="auto-style18">
        <tr>
            <td class="auto-style16">UserName</td>
            <td class="auto-style17">
                <asp:TextBox ID="tb_Name" runat="server" Width="292px"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="rfv_Name" runat="server" ControlToValidate="tb_Name" ErrorMessage="Please put in your username. " ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td class="auto-style16">Feedback </td>
            <td class="auto-style17">
                <asp:TextBox ID="tb_Feedback" runat="server" Height="225px" TextMode="MultiLine" Width="500px"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="rfv_Feedback" runat="server" ControlToValidate="tb_Feedback" ErrorMessage="Please complete your feedback." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td class="auto-style14">Ratings on our services</td>
            <td class="auto-style15">
                <asp:DropDownList ID="ddl_Ratings" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem>1(Worst)</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5(Best)</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style11">
                <asp:CompareValidator ID="cpv_Ratings" runat="server" ControlToValidate="ddl_Ratings" ErrorMessage="Please select your ratings on our services. " ForeColor="Red" Operator="NotEqual" ValueToCompare="Please Select"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style12">
                <br />
                <asp:Button ID="btn_Submit" CssClass="btnsu" runat="server" OnClick="btn_Submit_Click" Text="Submit" Width="109px" />
            &nbsp;</td>


        </tr>
    </table>
</asp:Content>

