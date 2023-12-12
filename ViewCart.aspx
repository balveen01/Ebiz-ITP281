<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
     <style type="text/css">
        .auto-style3 {
            width: 152px;
        }
        .auto-style5 {
            width: 316px;
        }
        .auto-style6 {
            margin-right: 0px;
        }
        .auto-style7 {
            width: 259px;
        }
        .auto-style10 {
            margin-right: 0px;
            height: 48px;
             width: 340px;
         }
        .auto-style12 {
            width: 345px;
            height: 48px;
        }


.btnclear {
  background-color: white; 
  color: black; 
  border: 2px solid lightcoral;
}

.btnclear:hover {
  background-color: lightcoral;
  color: white;
}
.btnupdate {
  background-color: white; 
  color: black; 
  border: 2px solid darkorange;
}

.btnupdate:hover {
  background-color: darkorange;
  color: white;
}
.btnpayment {
  background-color: white; 
  color: black; 
  border: 2px solid lightblue;
}

.btnpayment:hover {
  background-color: lightblue;
  color: black;
}
.prod_img{
    padding: 20px;
}
.btnplus{
    border:0;
    background-color:transparent;
}
.btnminus{
    border:0;
    background-color:transparent;
}
.tbqty{
    border:0;
    background-color:transparent;
    text-align:center;
}
.qty{
    padding-top:20px;
}

         .auto-style14 {
             height: 26px;
         }
         .auto-style15 {
             width: 61%
         }
         th {
             text-align:center !important;
 
         }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:GridView ID="gv_CartView" runat="server" AutoGenerateColumns="False" EmptyDataText="There is nothing in your shopping cart." DataKeyNames="ItemID" OnRowCommand="GridView1_RowCommand" Height="100px"  Width="100%" CssClass="auto-style6" CellPadding="0">
                        <HeaderStyle HorizontalAlign="Left" BackColor=" #ff8080" ForeColor="#FFFFFF" />
                <AlternatingRowStyle BackColor=" #FADBD8" />
         <Columns>
            <asp:BoundField DataField="ItemID" HeaderText="ID" >
             <ItemStyle Width="100px" HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:TemplateField HeaderText="Product">
                <ItemTemplate>
                    <asp:Image ID="img_Product" runat="server" Width="100px" Height="100px" CssClass="prod_img" ImageUrl="<%# Bind('Product_Image') %>"/>
                </ItemTemplate>
                 <ItemStyle Height="100px" HorizontalAlign="Center" Width="100px" />
             </asp:TemplateField>
         
            <asp:BoundField DataField="Product_Name" >
             <ItemStyle Width="270px" HorizontalAlign="Center" />
             </asp:BoundField>
            <asp:BoundField DataField="Product_Price" DataFormatString="{0:C}" HeaderText="Unit Price" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle Width="110px" HorizontalAlign="Center" />
             </asp:BoundField>
            <asp:TemplateField ItemStyle-CssClass="qty" HeaderText="Quantity">
                <ItemTemplate>
                    <asp:Button  width="18px" CssClass="btnplus" ID="btn_Plus"  CommandArgument='<%# Eval("ItemID")  %>' CommandName="Plus" runat="server" Text="+" />
                    <asp:TextBox width="40px" CssClass="tbqty" ID="tb_Quantity" runat="server"  Text='<%# Eval("Quantity") %>' ></asp:TextBox>
                    <asp:Button  width="18px" CssClass="btnminus" ID="btn_Minus"  CommandArgument='<%# Eval("ItemID")  %>' CommandName="Minus" runat="server" Text="-" /><br /><br />

                    <asp:ImageButton ID="btn_Remove" runat="server" CommandArgument='<%# Eval("ItemID") %>' CommandName="Remove" Width="15px" Height="15px" BorderWidth="0" ImageUrl="~/Images/bin.png"></asp:ImageButton>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" Width="150px" />
            </asp:TemplateField>
            <asp:BoundField DataField="TotalPrice" DataFormatString="{0:C}" HeaderText="SubTotal" >
             <HeaderStyle Height="15px" />
             <ItemStyle HorizontalAlign="Center" />
             </asp:BoundField>
        </Columns>
    </asp:GridView>
       <table class="auto-style2" width="100%">
       <tr>
           <td class="auto-style15"> &nbsp </td>
           <td class="auto-style6" align="center"> &nbsp 
           </td>
              <td align="right" class="auto-style14"> 
                  <br />
                  Total Item : $&nbsp; <br />
                  Shipping Fee : $&nbsp;
                  <br />
                  Order Total : $&nbsp;
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           </td>
           <td class="auto-style3"> <asp:Label ID="lbl_TotalItem" runat="server">0.00</asp:Label>
               <br />
               <asp:Label ID="lbl_ShippingFee" runat="server">  0.00</asp:Label>
               <br />
        <asp:Label ID="lbl_TotalPrice" runat="server"> 0.00</asp:Label>
               <br />
               <br />
           </td>
           </tr>
   </table>
       <table class="auto-style2" width="100%">
       <tr>
           <td class="auto-style10" align="right"> &nbsp;</td>
           <td class="auto-style12" align="center"> 
         <asp:Label ID="lbl_Error" runat="server" ForeColor="Red"></asp:Label>
               <br />
               <br />
         <asp:Button ID="btn_Clear" runat="server" OnClick="btn_Clear_Click" Text="Clear Cart" CssClass="btnclear" />&nbsp;&nbsp;
         <asp:Button ID="btn_Update" runat="server" OnClick="btn_Update_Click" Text="Update Cart" CssClass="btnupdate" />&nbsp;&nbsp;
         <asp:Button ID="btn_payment" runat="server" OnClick="btn_payment_Click" Text="Proceed to payment" CssClass="btnpayment" />
           </td>
           </tr>
   </table>
     <%-- <FooterStyle HorizontalAlign="Right" BackColor="#6C6B66" ForeColor="#FFFFFF" /> --%>
     &nbsp;&nbsp;&nbsp;&nbsp;<br />
     &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</asp:Content>

