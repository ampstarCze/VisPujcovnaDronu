<%@ Page Title="" Language="C#" Async="true" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="NoveHodnoceni.aspx.cs" Inherits="WebApplication.NoveHodnoceni" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="container">
        <div class="row">
            <div class="col-2">
                <asp:label runat="server" text="Hodnocení 1-10"></asp:label>
            </div>
            <div class ="col">
                <asp:textbox id="hodnoceniIn" runat="server" MaxLength="2" TextMode="Number"></asp:textbox>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:label runat="server" text="Poznámka:"></asp:label>
            </div>
        </div>
        <div class="row mx-auto">
            <div class="col p-0 w-100">
                <asp:textbox class="w-100" id="poznamkaIn" runat="server" TextMode="MultiLine"></asp:textbox>
            </div>
        </div>
        <div class="row">
            <div class="col ml-3 mt-2">
                <asp:button class="btn btn-primary" id="pridatBtn" runat="server" text="Přidat" OnClick="pridatBtn_Click" />
            </div>
        </div>
    </div>

</asp:Content>
