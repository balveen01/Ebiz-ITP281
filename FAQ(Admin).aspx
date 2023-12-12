<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="FAQ(Admin).aspx.cs" Inherits="FAQ_Admin_" %>

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
            padding-top: 60px;
            padding-bottom: 60px;
            padding-left: 40px;
            padding-right: 40px;
        }

        .tb {
            overflow: auto;
            text-overflow: ellipsis;
            white-space: pre;
            font-size: 12px;
            rows: 6;
            columns: 60;
        }

        .whole {
            height: 170px;
        }
    </style>

    <div class="whole">
        <!--<p style="font-size: 80px; line-height: 0px; float: left;">FAQ</p>-->
        <h1 style="text-align: center;">FAQs</h1>
        <br />
        <div style="float: right; padding-bottom: 40px; padding-right: 80px; padding-top: 30px;">
            <p style="font-size: 20px; line-height: 0;">
                Search for the category:
            </p>
            <asp:DropDownList ID="ddl_search" runat="server" Style="font-size: 15px;">
                <asp:ListItem>-- Select -- </asp:ListItem>
                <asp:ListItem>Payment</asp:ListItem>
                <asp:ListItem>Ordering</asp:ListItem>
                <asp:ListItem>Delivery</asp:ListItem>
                <asp:ListItem>Returns</asp:ListItem>
                <asp:ListItem>My Order</asp:ListItem>
                <asp:ListItem>Miscellaneous </asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
            </asp:DropDownList>
            <asp:Button Style="font-size: 15px;" ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
            <asp:Button ID="btn_insert" runat="server" Text="Add Question" OnClick="btn_insert_Click" />
        </div>
        <br />
        <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="lbl_search" runat="server" ForeColor="Red" Style="font-weight: bold; padding-left: 20px; font-size: 20px;"></asp:Label>
    </div>

    <div style="padding-bottom: 5%;">
        <asp:GridView ID="gv_faq" runat="server" AutoGenerateColumns="False" CssClass="wholetable" DataKeyNames="question_id" OnRowUpdating="gv_faq_RowUpdating" OnRowDeleting="gv_faq_RowDeleting" OnRowEditing="gv_faq_RowEditing" OnRowCancelingEdit="gv_faq_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="topic" HeaderText="Category" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="question_id" HeaderText="Question ID" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="question" HeaderText="Question" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="answer" HeaderText="Answer" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">

                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle Width="3000px" />
                    <ControlStyle Width="100%" CssClass="tb" />
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

