<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="FAQInsert(Admin).aspx.cs" Inherits="FAQInsert_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 style="text-align: center;">Insert Questions</h1>
    <p>
        <asp:Label ID="lbl_response" runat="server"></asp:Label>
    </p>
    <div style="padding-bottom: 5%; padding-left: 30%">
        <table class="auto-style1">
            <tr>
                <td>Category</td>
                <td>
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
                    <br />
                    <asp:CompareValidator ID="cpv_category" runat="server" ControlToValidate="ddl_category" ErrorMessage="Please select a choice" ForeColor="Red" Operator="NotEqual" ValueToCompare="-- Select --"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Question</td>
                <td>
                    <asp:TextBox ID="tb_question" runat="server" TextMode="MultiLine" Height="186px" Width="393px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_question" runat="server" ControlToValidate="tb_question" ErrorMessage="Please enter a question" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Answer</td>
                <td>
                    <asp:TextBox ID="tb_answer" runat="server" TextMode="MultiLine" Height="324px" Width="407px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_answer" runat="server" ControlToValidate="tb_answer" ErrorMessage="Please enter a answer" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_insert" runat="server" Text="Insert Question" OnClick="btn_insert_Click" Style="margin-left: 23%;" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

