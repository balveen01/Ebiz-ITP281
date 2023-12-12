<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bundle.aspx.cs" Inherits="Bundle" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            width: 96%;
            height: 586px;
            margin-bottom: 17px;
        }
                
    .auto-style22 {
        height: 300px;
    }
            
        .auto-style23 {
            margin-right: 290px;
        }
        .auto-style24 {
            width: 100%;
            height: 236px;
        }
            
        .auto-style25 {
            margin-bottom: 0px;
        }
                       .btnboth3 {
  background-color: white; 
  color: black; 
  border: 2px solid blueviolet;
  margin-top: 0px;
}

.btnboth3:hover {
  background-color: blueviolet;
  color: white;
}
                       .btnv3 {
  background-color: white; 
  color: black; 
  border: 2px solid  bisque;
  margin-top: 0px;
}

.btnv3:hover {
  background-color: bisque;
  color: white;
}
            
    </style>
</asp:Content>

<asp:Content ID="Content2"  contentplaceholderid="ContentPlaceHolder1" runat="server">

        <table class="auto-style14">
        <tr>
            <td class="auto-style22">
                 <asp:Button runat="server" align="right" text="Search" OnClick="Unnamed1_Click" />
                <asp:TextBox ID="tb_Search" runat="server" align="right" OnTextChanged="TextBox1_TextChanged1" CssClass="auto-style25" Height="29px"></asp:TextBox>
              <asp:Label ID="lbl_search" runat="server" align="right"></asp:Label>
                <asp:Panel ID="Panel2" runat="server" GroupingText="Sub-Category" Width="196px">
                    <asp:CheckBoxList ID="chkCountries" runat="server" >
                        <asp:ListItem Text="Kids" Value="Kids"></asp:ListItem>
                        <asp:ListItem Text="Teens" Value="Teens"></asp:ListItem>
                        <asp:ListItem Text="Young Adults" Value="Young Adults"></asp:ListItem>
                        <asp:ListItem Text="Adults" Value="Adults"></asp:ListItem>
                    </asp:CheckBoxList>
                    
                  
                    
                </asp:Panel>
                <asp:Panel ID="Panel1" runat="server" GroupingText="Sort Product by:" Width="196px">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server"  Width="226px">
                        <asp:ListItem value="UNIT_PRICE">Low to High Price</asp:ListItem>
                        <asp:ListItem value="UNIT_PRICE DESC">High to Low Price</asp:ListItem>
                    </asp:RadioButtonList>

                </asp:Panel>
                <asp:Button ID="btn_both" CssClass="btnboth3" runat="server" OnClick="btn_both_Click" Text="Filter" />
                <asp:DataList ID="DataList1" runat="server" CssClass="auto-style23" DataKeyField="Bundle_ID" DataSourceID="SqlDataSource1"  align="center" Height="496px" RepeatColumns="3" RepeatDirection="Horizontal" Width="1225px" OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                    <ItemTemplate>
                        <table class="auto-style24">
                            <tr>
                                <td>
                                    <asp:ImageButton ID="ImageButton1" runat="server" CommandName="BundleDetails" Height="180px" ImageUrl='<%# Eval("Bundle_Image") %>' Width="200px"  CommandArgument='<%# Eval("Bundle_ID") %>' OnCommand="ImageButton1_Command" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Bundle_Name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                  <asp:Label ID="Label2" runat="server" Text='<%# Eval("Unit_Price") %>'></asp:Label>
                                    <br />
                                    <br />
                                </td>
                            </tr>
                        </table>
                        <asp:Button ID="Button3" Cssclass="btnv3" runat="server" CommandName="BundleDetails" Text="View" CommandArgument='<%# Eval("Bundle_ID") %>' OnCommand="Button3_Command"  />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
                </td>
          
        </tr>
        
           
         

        <tr>
            <td>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [Bundles]"></asp:SqlDataSource>
            </td>
        </tr>
    </table>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HealthDBContext %>" SelectCommand="SELECT * FROM [Bundles] ORDER BY [Unit_Price] " >
    </asp:SqlDataSource>

</asp:Content>


