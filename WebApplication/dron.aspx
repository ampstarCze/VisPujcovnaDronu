<%@ Page Title="" Language="C#" Async="true" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="dron.aspx.cs" Inherits="WebApplication.dron" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <div class ="row">
                    <asp:Label ID="nazev" runat="server" Text="Label"></asp:Label>
                </div>
                <div class ="row">
                    <asp:Label ID="kategorie" runat="server" Text="Label"></asp:Label>
                </div>
                <div class ="row">
                    <asp:Label ID="rychlost" runat="server" Text="Label"></asp:Label>
                </div>
                <div class ="row">
                    <asp:Label ID="dobaLetu" runat="server" Text="Label"></asp:Label>
                </div>
                <div class ="row">
                    <asp:Label ID="pocetVrtuli" runat="server" Text="Label"></asp:Label>
                </div>
                <div class ="row">
                    <asp:Label ID="cenaDen" runat="server" Text="Label"></asp:Label>
                </div>
                <div class ="row">
                    <asp:Label ID="zaloha" runat="server" Text="Label"></asp:Label>
                </div>
                <div class ="row">
                    <asp:Label ID="stav" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="row w-50">
                    <div class="col-2">
                        <asp:Label ID="Label1" runat="server" Text="Hodnoceni:"></asp:Label>
                    </div>
                    <div class="col-2">
                        <asp:Button ID="pridatHodnoceniBtn" Text="Přidat hodnoceni" OnClick="pridatHodnoceniBtn_Click" Visible="False" runat="server"/>
                    </div>
                </div>
                <div class="row w-90 mx-auto">
                    <asp:GridView ID="hodnoceniView" style="width:40vw;" GridLines="None" ShowHeader="False" runat="server" AutoGenerateColumns="False" DataKeyNames="id">
                        <Columns>
                            <asp:BoundField ItemStyle-Width="25%" DataField="jmenoZakaznika"/>
                            <asp:BoundField ItemStyle-Width="10%" DataField="hodnoceni" />
                            <asp:BoundField ItemStyle-Width="65%"  DataField="poznamka"/>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
