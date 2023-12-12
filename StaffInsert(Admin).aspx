<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="StaffInsert(Admin).aspx.cs" Inherits="StaffInsert_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 style="text-align:center;">Insert Staff</h1>
    <asp:Label ID="lbl_response" runat="server"></asp:Label>
    <div style="padding-bottom: 5%; padding-left:30%;">
        <table class="auto-style1">
            <tr>
                <td>Staff ID</td>
                <td>
                    <asp:TextBox ID="tb_staffid" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_staffid" runat="server" ControlToValidate="tb_staffid" ErrorMessage="Please enter a staff id" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_name" runat="server" ControlToValidate="tb_name" ErrorMessage="Please enter a name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:DropDownList ID="ddl_gender" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:CompareValidator ID="cpv_gender" runat="server" ControlToValidate="ddl_gender" ErrorMessage="Please select a choice" ForeColor="Red" Operator="NotEqual" ValueToCompare="-- Select --"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Desgination</td>
                <td>
                    <asp:DropDownList ID="ddl_designation" runat="server">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>Manager</asp:ListItem>
                        <asp:ListItem>Supervisor</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:CompareValidator ID="cpv_designation" runat="server" ControlToValidate="ddl_designation" ErrorMessage="Please select a choice" ForeColor="Red" Operator="NotEqual" ValueToCompare="-- Select --"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>NRIC</td>
                <td>
                    <asp:TextBox ID="tb_nric" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_nric" runat="server" ControlToValidate="tb_nric" ErrorMessage="Please enter a NRIC" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_insert" runat="server" OnClick="btn_insert_Click" Text="Insert Staff" Style="margin-left: 23%;" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

