<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DeliveryTracking.aspx.cs" Inherits="DeliveryTracking" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 802px;
        }
        .auto-style10 {
            height: 311px;
            width: 77%;
            float: right;
        }
                 .btnto {
  background-color: white; 
  color: black; 
  border: 2px solid lemonchiffon ;
  margin-top: 0px;
}

.btnto:hover {
  background-color: lemonchiffon;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="text-center">Track Your Order here!</h1>
    <table class="w-100">
        <tr>
            <td class="auto-style9">
                <div class="text-left">
                    Enter your order number:
                    <asp:TextBox ID="tb_Order" runat="server" Width="199px"></asp:TextBox>
&nbsp;</div>
            </td>
            <td>
                <img src="pics/parcel.jpg" alt="Parcel" class="auto-style10"/>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfv_OrderNo" runat="server" ControlToValidate="tb_Order" ErrorMessage="Please input your order number." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2">
                <asp:Button ID="btn_TrackOrder" runat="server" Cssclass="btnto" OnClick="btn_TrackOrder_Click" Text="Track Order" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

