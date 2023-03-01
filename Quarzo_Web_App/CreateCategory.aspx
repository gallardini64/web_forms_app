<%@ Page Title="Create Category" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateCategory.aspx.cs" Inherits="Quarzo_Web_App.CreateCategory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label">Description </asp:Label>
    <asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label">Active</asp:Label>
    <asp:CheckBox ID="CheckBoxActivo" runat="server" />

    <br />
    <br />
    <asp:Button ID="ButtonCrear" runat="server" Text="Create" OnClick="CreateNewCategory"/>

    
</asp:Content>
