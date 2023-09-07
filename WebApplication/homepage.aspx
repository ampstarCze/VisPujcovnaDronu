<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class ="container w-75 mx-auto">
        <div class ="row w-100">
            <asp:GridView ID="GridView1" style="width:40vw;" runat="server" AutoGenerateColumns="False" DataKeyNames="idDron">
                <Columns>


                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="container-fluid">
                                <div class ="row">
                                    <div class ="col-lg-8">                                       
                                            <asp:Label class="ml-2 font-weight-bold" ID="nazevDronu" runat="server" Text='<%# Eval("nazev") %>' ></asp:Label>                                      
                                    </div>
                                    <div class="col-lg-4">
                                        <asp:Button class="btn btn-primary float-right" ID="dronBtn" runat="server" Text="Zobrazit" OnClick="dronBtn_Click" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>


                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
