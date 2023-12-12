<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dashboard(User).aspx.cs" Inherits="Dashboard_User_" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        table {
            border-collapse: collapse;
            height: 300px;
            margin-left: 150px;
            margin-right: 150px;
            border-right: 1px solid black;
            border-left: 1px solid black;
        }
        .whole 
        {
            padding-bottom:5%;
            padding-left: 7%;
            padding-top:6%;
        }

        td {
            border-top: 1px solid black;
            border-bottom: 1px solid black;
            height: 75px;
        }

        table .header {
            width: 400px;
            font-size: 22px;
            font-weight: bold;
            padding-left:7px;
        }

        table .items {
            width: 900px;
            font-size: 19px;
            padding-left:50px;
        }
                 .btnout {
  background-color: white; 
  color: black; 
  border: 2px solid darkorchid ;
  margin-top: 0px;
}

.btnout:hover {
  background-color: darkorchid;
  color: white;
}
         .btnd {
  background-color: white; 
  color: black; 
  border: 2px solid firebrick ;
  margin-top: 0px;
}

.btnd:hover {
  background-color: firebrick;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 70px; line-height: 0px; padding-left: 145px;">Personal Info</p>-->
    <h1 style="text-align:center;">Personal Info</h1>
    <asp:Button ID="btn_logout" Cssclass="btnout" runat="server" Text="Logout" OnClick="btn_logout_Click" style="float:right; margin-right:63px;"/>
    <asp:Button ID="btn_delivery" CssClass="btnd" runat="server" Text="Track Your Delivery" style="float:right; margin-right:63px;" OnClick="btn_delivery_Click"/>
    <div class="whole">
        
        
        <table>
            <tr>
                <td class="header">Username</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_username"></asp:Label></td>
                <td></td>

            </tr>

            <tr>
                <td class="header">Email</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_email"></asp:Label></td>
                <td>
                    <asp:ImageButton ID="img_email" runat="server" ImageUrl="~/pics/arrow.jpg" Width="74px" Height="76px" OnClick="img_email_Click" /></td>
            </tr>
            <tr>
                <td class="header">Address</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_address"></asp:Label></td>
                <td>
                    <asp:ImageButton ID="img_address" runat="server" ImageUrl="~/pics/arrow.jpg" Width="74px" Height="76px" OnClick="img_address_Click" /></td>
            </tr>
            <tr>
                <td class="header">Password</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_password"></asp:Label></td>
                <td>
                    <asp:ImageButton ID="img_password" runat="server" ImageUrl="~/pics/arrow.jpg" Width="74px" Height="76px" OnClick="img_password_Click" /></td>
            </tr>
            <tr>
                <td class="header">Phone Number</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_phoneno"></asp:Label></td>
                <td>
                    <asp:ImageButton ID="img_phoneno" runat="server" ImageUrl="~/pics/arrow.jpg" Width="74px" Height="76px" OnClick="img_phoneno_Click" /></td>
            </tr>
            <tr>
                <td class="header">Birthday Month</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_month"></asp:Label></td>
                <td></td>
            </tr>
            <tr>
                <td class="header">Gender</td>
                <td class="items">
                    <asp:Label runat="server" ID="lbl_gender"></asp:Label></td>
                <td></td>
            </tr>
        </table>

    </div>




</asp:Content>

