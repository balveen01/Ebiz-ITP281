<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Confirmation.aspx.cs" Inherits="Confirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
            <style type="text/css">
         .btnhome {
  background-color: white; 
  color: black; 
  border: 2px solid crimson ;
  margin-top: 0px;
}

.btnhome:hover {
  background-color: crimson;
  color: white;
}
         .btntrack {
  background-color: white; 
  color: black; 
  border: 2px solid coral ;
  margin-top: 0px;
}

.btntrack:hover {
  background-color: coral;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 class="text-center">YOUR ORDER HAS BEEN CONFIRMED!</h1>
    <meta charset="utf-8" />
    <!--<b id="docs-internal-guid-114f82a7-7fff-0593-5fe7-b1d06e3d84bc" style="font-weight: normal;">-->
    <p dir="ltr" style="line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt; text-align: center;">
        <span style="font-size: 13.999999999999998pt; font-family: Arial; color: #000000; background-color: transparent; font-weight: 400; font-style: normal; font-variant: normal; text-decoration: none; vertical-align: baseline; white-space: pre; white-space: pre-wrap;">For more information about your order&nbsp;</span>
    </p>
    <p dir="ltr" style="line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt; text-align: center;">
        <span style="font-size: 13.999999999999998pt; font-family: Arial; color: #000000; background-color: transparent; font-weight: 400; font-style: normal; font-variant: normal; text-decoration: none; vertical-align: baseline; white-space: pre; white-space: pre-wrap;">Please refer to your Email.
        <asp:Label ID="lbl_email" runat="server"></asp:Label>
        </span>
    </p>
    <p dir="ltr" style="line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt; text-align: center;">
        <span style="font-size: 13.999999999999998pt; font-family: Arial; color: #000000; background-color: transparent; font-weight: 400; font-style: normal; font-variant: normal; text-decoration: none; vertical-align: baseline; white-space: pre; white-space: pre-wrap;">Thank You for shopping with us,</span>
    </p>
    <p dir="ltr" style="line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt; text-align: center;" />
    <span style="font-size: 13.999999999999998pt; font-family: Arial; color: #000000; background-color: transparent; font-weight: 400; font-style: normal; font-variant: normal; text-decoration: none; vertical-align: baseline; white-space: pre; white-space: pre-wrap;">
        <asp:Label ID="lbl_CustName" runat="server"></asp:Label>!

        </p>
        <p dir="ltr" style="line-height: 1.2; margin-top: 0pt; margin-bottom: 0pt; text-align: center;">
            <asp:Button ID="btn_Home" runat="server" CssClass="btnhome" OnClick="btn_Home_Click" Text="Back To Home" Width="163px" />
            &nbsp;<asp:Button ID="btn_Delivery" runat="server" CssClass="btntrack" OnClick="btn_Delivery_Click" Text="Track Order" />
        </p>
        <!--</b>-->
    </span>
</asp:Content>

