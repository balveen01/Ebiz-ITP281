<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="Customer(Admin).aspx.cs" Inherits="Customer_Admin_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style type="text/css">
        .wholetable {
            border-color: black;
            border: 1px solid Black;
            border-collapse: collapse;
            width: 100%;
        }

        .headers {
            color: black;
            background-color: #4CAF50;
            border: 1px solid black;
            padding-top: 12px;
            padding-bottom: 12px;
        }

        .items {
            color: black;
            text-align: center;
            background-color: mintcream;
            border: 1px solid black;
            padding-top: 12px;
            padding-bottom: 12px;
        }

        .whole {
            height: 170px;
        }
    </style>

    <div class="whole">
        <!--<p style="font-size: 80px; line-height: 0px; float: left;">Users Information</p>
    <p style="font-size: 100px; line-height: 0px; text-align: center;">Information</p>-->

        <h1 style="text-align: center;">Users Information</h1>
        <div style="width: 100%; padding-bottom: 50px">
            <br />

            <div style="float: right; padding-bottom: 40px; padding-right: 80px; padding-top: 30px;">
                <p style="font-size: 20px; line-height: 0;">Search for user_id</p>
                <asp:TextBox Style="font-size: 15px;" ID="tb_search" runat="server"></asp:TextBox>
                <asp:Button Style="font-size: 15px;" ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
            </div>
            <br />
            <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="lbl_search" runat="server" ForeColor="Red" Style="font-weight: bold; padding-left: 20px; font-size: 20px;"></asp:Label>
        </div>
    </div>
    <div style="padding-bottom: 5%;">
        <asp:GridView ID="gv_Customer" runat="server" AutoGenerateColumns="False" CssClass="wholetable" DataKeyNames="user_id" OnRowDeleting="gv_Customer_RowDeleting" OnRowCancelingEdit="gv_Customer_RowCancelingEdit" OnRowEditing="gv_Customer_RowEditing" OnRowUpdating="gv_Customer_RowUpdating">
            <Columns>
                <asp:BoundField DataField="user_id" HeaderText="User_id" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="email" HeaderText="Email Address" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="address" HeaderText="Address" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="phone_number" HeaderText="Phone Number" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="month" HeaderText="Birthday Month" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="gender" HeaderText="Gender" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="email_status" HeaderText="Email Verification" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this record?');"></asp:LinkButton>
                    </ItemTemplate>
                    <HeaderStyle CssClass="headers" />
                    <ItemStyle CssClass="items" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>



