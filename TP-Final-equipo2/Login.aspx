<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TP_Final_equipo2.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 24px">


        <div class="bg-white p-5 rounded-5 text-secondary shadow" style="width: 25rem">
            <div class="d-flex justify-content-center">
                <img src="Imagenes/login-icon.svg" alt="login-icon" style="height: 7rem" />
            </div>
            <div class="text-center fs-1 fw-bold">Login</div>
            <div class="mb-3 text-center">
                <asp:Label ID="lblMensajeError" runat="server" Text="" Visible="false" CssClass="errorMensaje"></asp:Label>
            </div>
            <div class="input-group mt-4">
                <div class="input-group-text bg-info">
                    <img
                        src="Imagenes/username-icon.svg"
                        alt="username-icon"
                        style="height: 1rem" />
                </div>
                <asp:TextBox ID="tbxUsuario" CssClass="form-control bg-light" placeholder="Usuario" runat="server" />
            </div>
            <div class="input-group mt-1">
                <div class="input-group-text bg-info">
                    <img
                        src="Imagenes/password-icon.svg"
                        alt="password-icon"
                        style="height: 1rem" />
                </div>
                <asp:TextBox ID="tbxClave" CssClass="form-control bg-light" type="password" placeholder="*********" runat="server" />
            </div>
            <div class="pt-1">
                <a
                    href="RecuperarClave.aspx"
                    class="text-decoration-none text-info fw-semibold fst-italic"
                    style="font-size: 0.9rem">Olvidaste tu contraseña?</a>
            </div>
            <asp:Button ID="btnIngresar" CssClass="btn btn-info text-white w-100 mt-4 fw-semibold shadow-sm" OnClick="btnIngresar_Click" runat="server" Text="Ingresar" />
            <div class="d-flex gap-1 justify-content-center mt-1">
                <div>¿No tenes cuenta?</div>
                <a href="Registrarse.aspx" class="text-decoration-none text-info fw-semibold">Registrate</a>
            </div>
        </div>
    </div>
</asp:Content>
