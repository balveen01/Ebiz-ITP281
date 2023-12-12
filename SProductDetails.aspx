<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 90%;
            height: 261px;
            align-content:center;
        }
        .auto-style4 {
            width: 188px;
        }

        .auto-style9 {
            width: 204px;
            height: 26px;
            margin-top: 6px;
        }
         .img_Product{
            height: 250px;
            width: 250px;
            padding: 30px;
    }
         .btnadd {
            background-color: white; 
            color: black; 
            border: 2px solid palevioletred;          
}

        .btnadd:hover {
            background-color: palevioletred;
            color: white;
}

        .auto-style10 {
            width: 342px;
        }
        h2{
            text-align:center;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>PRODUCT DETAILS</h2>
    <table align="center" class="auto-style3">
        <tr>
            <td class="auto-style9" rowspan="3">
                <asp:image CssClass="img_Product" ID="img_Product" runat="server" />
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Btn_Add" CssClass="btnadd" runat="server" Text="Add to Cart" OnClick="Btn_Add_Click" />
                <br />
                <!--ProductID =<asp:Label ID="lbl_ProdID" runat="server" Text="Label"></asp:Label> -->
                <br />
                <br />
            </td>
            <td class="auto-style10">
                Product Name:
                <asp:Label ID="lbl_ProdName" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                Product Desciption:
                <asp:Label ID="lbl_ProdDesc" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                Product Price:
                <asp:Label ID="lbl_Price" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

