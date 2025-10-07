<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolaMundo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <label for="txtNombre">Ingrese su nombre:</label>
    <asp:TextBox runat="server" id="insertar" OnTextChanged="insertar_TextChanged"/>
        <br />
        <br />      

      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

</asp:Content>
