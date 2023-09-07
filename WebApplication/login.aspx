<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class=" container">
        <div class="row">
            <div class=" col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3> Přihlášení uživatele</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="loginMail" runat="server" placeholder="Email"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Heslo</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="loginHeslo" runat="server" placeholder="Heslo" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                                <div class="form-group w-90 mx-auto">
                                    <asp:Button class="btn btn-primary btn-block" ID ="loginBtn" runat="server" Text="Log in" OnClick="loginBtn_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
