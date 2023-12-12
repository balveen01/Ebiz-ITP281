<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="VenueDetails.aspx.cs" Inherits="VenueDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <style type="text/css">
        .auto-style3 {
            width: 90%;
            height: 261px;
        }
        .auto-style4 {
            width: 188px;
        }
        .img_Venue{
            height: 250px;
            width: 250px;
            padding:30px;
    }

          .auto-style9 {
              width: 183px;
              height: 26px;
              margin-top: 6px;
          }
          h2{
              text-align:center;
          }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>VENUE DETAILS</h2>
    &nbsp;&nbsp;
    <table align="center" class="auto-style3">
        <tr>
            <td class="auto-style9" rowspan="3">
                <asp:image CssClass="img_Venue" ID="img_Venue" runat="server"/>
                <br />
                <br />
                <br />
               <!-- VenueID = <asp:Label ID="lbl_VenueId" runat="server" Text="Label"></asp:Label>-->
            </td>
            <td>
                Venue Name : <asp:Label ID="lbl_VenueName" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Venue capacity :
                <asp:Label ID="lbl_VenueCap" runat="server" Text="Label"></asp:Label> <br />
                Venue Desciption : <asp:Label ID="lbl_VenueDesc" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Venue Website : <asp:LinkButton ID="lbl_VenueLink" runat="server" Text="Label" OnClick="lbl_VenueLink_Click">  </asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>

