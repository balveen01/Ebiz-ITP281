<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RecommendationQuestion.aspx.cs" Inherits="RecommendationQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <meta charset="utf-8" />
        <style type="text/css">

        .btnsubmit {
  background-color: white; 
  color: black; 
  border: 2px solid darkseagreen;
  margin-top: 0px;
}

.btnsubmit:hover {
  background-color: darkseagreen;
  color: white;
}
    </style>
    <asp:Panel ID="Panel1" runat="server" GroupingText="What is your budget for the whole party ?">
         &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:RadioButtonList ID="rbl_Budget" runat="server">
            <asp:ListItem Value="100">100 Dollars</asp:ListItem>
            <asp:ListItem Value="200">200 Dollars</asp:ListItem>
            <asp:ListItem Value="300">300 Dollars</asp:ListItem>
            <asp:ListItem Value="400">400 Dollars</asp:ListItem>
            <asp:ListItem Value="500">500 Dollars</asp:ListItem>
        </asp:RadioButtonList>
         <br />
         <asp:Label ID="lbl_budgeterror" runat="server" ForeColor="Red"></asp:Label>
         <br />
        <br />
    </asp:Panel>
    </span>
    <asp:Panel ID="Panel2" runat="server" GroupingText="The number of people attending the party?">
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:RadioButtonList ID="rbl_Ppl" runat="server">
            <asp:ListItem Value="B30">Below 30pax</asp:ListItem>
            <asp:ListItem Value="B60">Below 60pax</asp:ListItem>
            <asp:ListItem Value="B90">Below 90pax</asp:ListItem>
            <asp:ListItem Value="M90">More than 90pax</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lbl_pplerror" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
    </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" GroupingText="Which kind of theme would you go for? ">
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:CheckBoxList ID="cbl_Theme" runat="server" >
                <asp:ListItem Value="1">Elegance</asp:ListItem>
                <asp:ListItem Value="2">Charaters</asp:ListItem>
                <asp:ListItem Value="3">Cute</asp:ListItem>
                <asp:ListItem Value="4">Simple Wedding & Bridal shower</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
        </asp:Panel>
     <!--   <asp:Panel ID="Panel4" runat="server" GroupingText="Would you like to go for bundle or ala carte?">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:CheckBoxList ID="cbl_AorB" runat="server" >
                <asp:ListItem>Ala carte</asp:ListItem>
                <asp:ListItem>Bundle</asp:ListItem>
            </asp:CheckBoxList>
             <br />
        </asp:Panel> 
        <asp:Panel ID="Panel5" runat="server" GroupingText="Do you need Help out / Helpping Hand?">
            <meta charset="utf-8" />
            <b id="docs-internal-guid-48ffecc9-7fff-9660-4b90-97add5f0f078" style="font-weight:normal;"><span style="font-size:8pt;font-family:Arial;color:#000000;background-color:transparent;font-weight:400;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre;white-space:pre-wrap;">( provide both setting up services and after party cleaning services.)<br /> </span>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:RadioButtonList ID="rbl_Helpout" runat="server">
            <asp:ListItem Value="Yes">Yes</asp:ListItem>
            <asp:ListItem Value="No">No</asp:ListItem>
        </asp:RadioButtonList>
        <br />
                <meta charset="utf-8" />
            <b id="docs-internal-guid-3405f649-7fff-6fae-c7db-9fe5bb0782e1" style="font-weight:normal;">
            <p dir="ltr" style="line-height:1.2;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:9pt;font-family:Arial;color:#000000;background-color:transparent;font-weight:400;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre;white-space:pre-wrap;">Disclaimer:</span></p>
            <p dir="ltr" style="line-height:1.2;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:9pt;font-family:Arial;color:#000000;background-color:transparent;font-weight:400;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre;white-space:pre-wrap;">do note that for helping hand, it will be a separately payment. </span>
            </p>
            <p dir="ltr" style="line-height:1.2;margin-top:0pt;margin-bottom:0pt;">
                <span style="font-size:9pt;font-family:Arial;color:#000000;background-color:transparent;font-weight:400;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;white-space:pre;white-space:pre-wrap;">our helper will be paid $9 per hour for each helper at the end of the event. </span>
            </p>--> 
            <br />
            <br class="Apple-interchange-newline" />
                        <asp:Button ID="btn_submit" runat="server" CssClass="btnsubmit" Height="35px" Text="Submit" Width="150px" Align="Right" OnClick="btn_submit_Click" OnClientClick="javascript:return Validate()" />
    <br />
        </asp:Panel>

        </b>
</asp:Content>



