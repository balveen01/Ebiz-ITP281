<%@ Page Title="" Language="C#" MasterPageFile="~/Site(admin).master" AutoEventWireup="true" CodeFile="UpdateProduct.aspx.cs" Inherits="UpdateProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            text-align: center;
            font-size: x-large;
        }
    .auto-style12 {
        width: 768px;
        text-align: center;
    }
             .btnup {
            background-color: white; 
            color: black; 
            border: 2px solid palevioletred;          
}

        .btnup:hover {
            background-color: palevioletred;
            color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style10"><strong>Update in Product Details</strong></p>
            
    <p>
        <table cellspacing="0" class="w-100">
            <tr>
                <td class="auto-style12">Product ID</td>
                <td>
                    <asp:Label ID="lbl_id" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Product name</td>
                <td>
                    <asp:Label ID="lbl_name" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Unit Price</td>
                <td>
                    <asp:TextBox ID="tb_price" runat="server" Width="210px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" colspan="2">
                    <asp:Button ID="btn_update" runat="server" Cssclass="btnup" Text="Update" Width="138px" OnClick="btn_update_Click" />
                </td>
            </tr>
        </table>
        <br />
    </p>
    

    
    
</asp:Content>

