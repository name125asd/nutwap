<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="nutloginWebForm1.aspx.cs" Inherits="nutwap.nutloginWebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>Login</h1>
        <p class="lead">Enter your username and password</p>
        <div class="row justify-content-center">
            <div class="col-md-12">
                <asp:TextBox ID="username" runat="server" CssClass="form-control mx-auto" placeholder="Username" Style="margin: auto;"></asp:TextBox>
                <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control mx-auto" placeholder="Password" Style="margin: auto;"></asp:TextBox>
                <asp:Button ID="btnClickMe" runat="server" Text="Login" OnClick="btnClickMe_Click" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
    <div class="row justify-content-center">
        <div class="col-md-12">
            <asp:Label ID="name" runat="server" CssClass="label-style"></asp:Label>
            <asp:Label ID="address" runat="server" CssClass="label-style"></asp:Label>
            <asp:Label ID="age" runat="server" CssClass="label-style"></asp:Label>
            <asp:Label ID="email" runat="server" CssClass="label-style"></asp:Label>
            <asp:Label ID="is_student" runat="server" CssClass="label-style"></asp:Label>
        </div>
    </div>
</asp:Content>