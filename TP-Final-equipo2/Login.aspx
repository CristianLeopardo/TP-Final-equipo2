<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP_Final_equipo2.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Este es el login</h1>
    <div class="Login">
        <div class="mb-3 text-center">
            <asp:Label ID="lblMensajeError" runat="server" Text="" Visible="false" CssClass="errorMensaje"></asp:Label>
        </div>
        <div class="mb-3">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox id="tbxUsuario" CssClass="form-control" placeholder="Usuario" runat="server"/>
        </div>
        <div class="mb-3">
            <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox id="tbxClave" CssClass="form-control" placeholder="*********" runat="server"/>
        </div>
        <div>
            <a href="RecuperarClave.aspx">Olvide mi contraseña</a>
        </div>
        <asp:Button ID="btnIngresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" runat="server" Text="Ingresar" />
        <a href="Default.aspx" class="btn btn-primary">Volver</a>
        <asp:Button ID="btnRegistrarse" CssClass="btn btn-primary" runat="server" OnClick="btnRegistrarse_Click" Text="Registrarse" />
    </div>
</asp:Content>
