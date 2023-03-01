<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Quarzo_Web_App.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:DropDownList ID="DDLCategorias" runat="server" AutoPostBack="True" OnSelectedIndexChanged="IndexChange"></asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label">Descrption</asp:Label>
    <asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label">Active</asp:Label>
    <asp:CheckBox ID="CheckBoxActive" runat="server" />

    <br />
    <br />
    <asp:Button ID="ButtonModify" runat="server" Text="Modify" OnClick="ModifyCategory"/>
    <a runat="server" href="~/CreateCategory">New</a>

    
</asp:Content>

