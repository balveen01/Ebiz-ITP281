<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AWedding.aspx.cs" Inherits="AWedding" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

        <head> 
        <style type="text/css">

        .auto-style20 {
            float: left;
            width: 174px;
        }
        .data1{
           text-align:center;
        }
        .auto-style21 {
            height: 806px;
        }
       .auto-style22 {
            text-align: center;
            font-size: xx-large;
        }
       .btnfilter {
  background-color: white; 
  color: black; 
  border: 2px solid chocolate ;
  margin-top: 0px;
}

.btnfilter:hover {
  background-color: chocolate;
  color: white;
}
    </style>
    </head>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
            <p class="auto-style22"><strong>Wedding</strong></p>
            <br />
            <br />

            <div class="auto-style20">    
                <tr>
                <br />
                    <td>
                        <asp:Panel ID="Panel2" runat="server" GroupingText="Sort Product By:" Width="171px">
                            <div>
                                <asp:RadioButtonList ID="RadioButtonList2" runat="server" Width="171px">
                                    <asp:ListItem>Low to High Price</asp:ListItem>
                                    <asp:ListItem>High to Low Price</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </asp:Panel>
                    </td>
                    <br />
           
                    <td><asp:Button ID="Btn_filter" runat="server" CssClass="btnfilter" Text="Filter" OnClick="Btn_filter_Click" /></td>
                </tr>
            </div>
          <br />

            <div class="data1">
                <asp:DataList ID="DataList1" runat="server" DataSourceID ="SqlDataSource1" RepeatColumns ="3" Width ="800px" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="180px" Width="180px" ImageUrl ='<%# Eval ("Product_Image") %>'/>
                            <br />
                            <br />
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
                            <br />
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Unit_Price") %>'></asp:Label>
                            <br />
                            <br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [AShower] ORDER BY [Unit_Price] DESC"></asp:SqlDataSource>
            </div>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString ="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand ="SELECT * FROM [AWedding] ORDER BY [Unit_Price]">
            </asp:SqlDataSource>

</asp:Content>

