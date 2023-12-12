<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FAQContact(User).aspx.cs" Inherits="FAQContact_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
                         .btneus {
  background-color: white; 
  color: black; 
  border: 2px solid  dimgrey ;
  margin-top: 0px;
}

.btneus:hover {
  background-color: dimgrey;
  color: white;
}
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; text-align: center;">Ask us a Question</p>-->
    <h1 style="text-align:center;">Ask us a Question</h1>
    <br />
    <asp:Label ID="lbl_result" runat="server" ForeColor="Blue"></asp:Label>

    <br />

    <div style="padding-bottom: 5%; padding-left:30%;">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Category
                    <br />
                    <br />
                    <br />
                </td>
                <td>
                    <asp:DropDownList ID="ddl_category" runat="server" Width="178px">
                        <asp:ListItem>-- Select --</asp:ListItem>
                        <asp:ListItem>Payment</asp:ListItem>
                        <asp:ListItem>Ordering</asp:ListItem>
                        <asp:ListItem>Delivery</asp:ListItem>
                        <asp:ListItem>Returns</asp:ListItem>
                        <asp:ListItem>My Order</asp:ListItem>
                        <asp:ListItem>Miscellaneous </asp:ListItem>
                        <asp:ListItem>Others </asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_category" ControlToValidate="ddl_category" runat="server" ErrorMessage="Please choose a category" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="cv_category" runat="server" ControlToValidate="ddl_category" ErrorMessage="Please Select a Choice" ForeColor="Red" Operator="NotEqual" ValueToCompare="-- Select --"></asp:CompareValidator>
                    <br />

                </td>
            </tr>
            <tr>
                <td class="auto-style2">Question</td>
                <td>
                    <asp:TextBox ID="tb_question" runat="server" Height="303px" Width="395px" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfv_question" runat="server" ControlToValidate="tb_question" ErrorMessage="Please enter your question" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_emailus" Cssclass="btneus" runat="server" Text="Submit" OnClick="btn_emailus_Click" style="margin-left:24%;"/>

                </td>

            </tr>
        </table>
    </div>


</asp:Content>

