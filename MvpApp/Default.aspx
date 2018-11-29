<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MvpApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> &nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />

</asp:Content>
