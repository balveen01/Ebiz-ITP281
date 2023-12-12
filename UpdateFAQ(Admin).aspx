
<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="UpdateFAQ(Admin).aspx.cs" Inherits="UpdateFAQ_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 480px;
        }

        .auto-style3 {
            width: 438px;
        }

        .auto-style4 {
            width: 26px;
            height: 48px;
            margin-top: 6px;
        }

        .auto-style5 {
            width: 438px;
            height: 223px;
        }

        .auto-style9 {
            width: 480px;
            height: 365px;
        }
        .auto-style10 {
            width: 438px;
            height: 365px;
        }
        .auto-style11 {
            width: 480px;
            height: 26px;
        }
        .auto-style12 {
            width: 438px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Update FAQ Particulars</p>-->
    <h1 style="text-align: center;">Update FAQ Particulars</h1>
    <br />
    <div style="padding-bottom: 5%; padding-left:23%;">
        <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Question Id</td>
                <td class="auto-style3">
                    <asp:Label ID="lbl_questionid" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Category</td>
                <td class="auto-style12">
                    <asp:DropDownList ID="ddl_category" runat="server">
                        <asp:ListItem>-- Select -- </asp:ListItem>
                        <asp:ListItem>Payment</asp:ListItem>
                        <asp:ListItem>Ordering</asp:ListItem>
                        <asp:ListItem>Delivery</asp:ListItem>
                        <asp:ListItem>Returns</asp:ListItem>
                        <asp:ListItem>My Order</asp:ListItem>
                        <asp:ListItem>Miscellaneous </asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Question</td>
                <td class="auto-style4">
                    <asp:TextBox ID="tb_question" runat="server" TextMode="MultiLine" Height="186px" Width="393px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Answer</td>
                <td class="auto-style10">
                    <asp:TextBox ID="tb_answer" runat="server" TextMode="MultiLine" Height="324px" Width="407px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_updat" runat="server" OnClick="btn_updat_Click" Text="Update" style="margin-left:36%;"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

