<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FeedbackPage.aspx.cs" Inherits="FeedbackPage" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            border-collapse: collapse;
            text-align: center;
        }
                         .btnsea {
  background-color: white; 
  color: black; 
  border: 2px solid  goldenrod ;
  margin-top: 0px;
}

.btnsea:hover {
  background-color: goldenrod;
  color: white;
}
                 .btnhoo {
  background-color: white; 
  color: black; 
  border: 2px solid  greenyellow ;
  margin-top: 0px;
}

.btnhoo:hover {
  background-color: greenyellow;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Search Ratings:
        <asp:DropDownList ID="ddl_SearchRating" runat="server" Height="30px" Width="189px">
            <asp:ListItem>Please Select</asp:ListItem>
            <asp:ListItem>1(Worst)</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5(Best)</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:Button Cssclass="btnsea" ID="btn_Search" runat="server" OnClick="btn_Search_Click" Text="Search" />
    </p>
    <p>
        <asp:Label ID="lbl_Search"  runat="server" CssClass="h-100" ForeColor="Red"></asp:Label>
    </p>
    <div class="w3-left-align">
    <asp:GridView ID="gv_Feedback" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_Feedback_SelectedIndexChanged" CssClass="grid" Height="346px" Width="1238px">
        <Columns>
            <asp:BoundField DataField="FeedbackUsername" HeaderText="Username" />
            <asp:BoundField DataField="Ffeedback" HeaderText="Feedback" />
            <asp:BoundField DataField="Feedback_Rating" HeaderText="Feedback Ratings" />
        </Columns>
    </asp:GridView>
    </div>
    <asp:Button ID="btn_Home" Cssclass="btnhoo" runat="server" OnClick="btn_Home_Click" Text="Back To Home" Width="156px" />
</asp:Content>

