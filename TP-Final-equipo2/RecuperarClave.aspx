<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RecuperarClave.aspx.cs" Inherits="TP_Final_equipo2.RecuperarClave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Recupero de clave</h1> 
    <asp:Label ID="lblIngreseEmail" runat="server" Text="Ingrese el Email"></asp:Label>
    <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
    <asp:Button ID="btnAceptar" class="btn btn-primary" runat="server" OnClick="btnAceptar_Click" Text="Recuperar contraseña" />
    <a href="Default.aspx"  class="btn btn-primary">Volver</a>
    <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
</asp:Content>
