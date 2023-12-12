<%@ Page Title="" Language="C#" MasterPageFile="~/Site(Admin).master" AutoEventWireup="true" CodeFile="Staff(Admin).aspx.cs" Inherits="Staff_Admin_" %>

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
        <!--<p style="font-size: 80px; line-height: 0px; text-align: center;">Staff Information</p>-->
       <h1 style="text-align: center;">Staff Information</h1>
        <!--<p style="font-size: 80px; line-height: 0px; text-align: center;">Information</p>-->
        <br />

        <div style="float: right; padding-bottom: 40px; padding-right: 80px; padding-top: 30px;">
            <p style="font-size: 20px; line-height: 0;">Search for staff_id</p>
            <asp:TextBox Style="font-size: 15px;" ID="tb_search" runat="server"></asp:TextBox>
            <asp:Button Style="font-size: 15px;" ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
            <asp:Button ID="btn_insert" runat="server" Text="Insert Staff" OnClick="btn_insert_Click" Style="font-size: 15px; margin-left: 55px;" />
        </div>

        <br />

        <asp:Label ID="lbl_result" runat="server" ForeColor="Red"></asp:Label>

        <br />

        <asp:Label ID="lbl_search" runat="server" ForeColor="Red" Style="font-weight: bold; padding-left: 20px; font-size: 20px;"></asp:Label>
    </div>
    <div style="padding-bottom: 5%">
        <asp:GridView ID="gv_staff" runat="server" AutoGenerateColumns="False" CssClass="wholetable" DataKeyNames="staff_id" OnRowDeleting="gv_staff_RowDeleting" OnRowCancelingEdit="gv_staff_RowCancelingEdit" OnRowEditing="gv_staff_RowEditing" OnRowUpdating="gv_staff_RowUpdating">
            <Columns>
                <asp:BoundField DataField="staff_id" HeaderText="Staff ID" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="Name" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="gender" HeaderText="Gender" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="designation" HeaderText="Designation" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="nric" HeaderText="NRIC" HeaderStyle-CssClass="headers" ItemStyle-CssClass="items">
                    <HeaderStyle CssClass="headers"></HeaderStyle>

                    <ItemStyle CssClass="items"></ItemStyle>
                </asp:BoundField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="update" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="edit" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="delete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this record?');"></asp:LinkButton>
                    </ItemTemplate>
                    <HeaderStyle CssClass="headers" />
                    <ItemStyle CssClass="items" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>

