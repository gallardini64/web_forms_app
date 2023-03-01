<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Quarzo_Web_App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Categories</h1>
    <br />
    <asp:DropDownList ID="DDLCategorias" runat="server" OnSelectedIndexChanged="DDLCategorias_SelectedIndexChanged" AutoPostBack="True" >
    </asp:DropDownList>
    <br />
    <h1>Products</h1>
    <br />
    <asp:GridView ID="GridProductos" runat="server" CssClass="table"></asp:GridView>

</asp:Content>

    