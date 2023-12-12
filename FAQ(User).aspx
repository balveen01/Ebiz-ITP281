<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FAQ(User).aspx.cs" Inherits="FAQ_User_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
      <style type="text/css">
                 .btnse {
  background-color: white; 
  color: black; 
  border: 2px solid  beige ;
  margin-top: 0px;
}

.btnse:hover {
  background-color: beige;
  color: white;
}
                 .btnus {
  background-color: white; 
  color: black; 
  border: 2px solid  forestgreen ;
  margin-top: 0px;
}

.btnus:hover {
  background-color: forestgreen;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--<p style="font-size: 100px; line-height: 0px; padding-left: 200px; float: left;">FAQs</p>-->
    <h1 style="text-align: center;">FAQs</h1>
    <br />
    <div style="float: right; padding-right: 40px; padding-top: 49px;">
        <p style="font-size: 15px; line-height: 0;">
            Search for the category:
        </p>
        <asp:DropDownList ID="ddl_search" runat="server" Style="font-size: 14px;">
            <asp:ListItem>-- Select -- </asp:ListItem>
            <asp:ListItem>Payment</asp:ListItem>
            <asp:ListItem>Ordering</asp:ListItem>
            <asp:ListItem>Delivery</asp:ListItem>
            <asp:ListItem>Returns</asp:ListItem>
            <asp:ListItem>My Order</asp:ListItem>
            <asp:ListItem>Miscellaneous </asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btn_search" CssClass="btnse" runat="server" Text="Search" OnClick="btn_search_Click" Style="font-size: 14px;" />
    </div>
    <br />

    <div style="padding-bottom: 5%; padding-top:5%;">
        <asp:Label ID="lbl_topic" runat="server" Style='font-size: 20px; font-weight: bold; text-decoration: underline; padding-left: 200px;'></asp:Label>
        <asp:Label ID="lbl_qna" runat="server"></asp:Label>
        <asp:Button ID="btn_emailus" CssClass="btnus" runat="server" Text="Unable to find your question. Ask us!" OnClick="btn_emailus_Click" style="margin-left:38%;"/>
    </div>

</asp:Content>

