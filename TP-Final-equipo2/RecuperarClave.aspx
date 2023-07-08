<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RecuperarClave.aspx.cs" Inherits="TP_Final_equipo2.RecuperarClave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-50">
            <div class="container text-center">
                <h1>Recupero de clave</h1>
                <hr />
                <asp:Label ID="lblMensaje" runat="server" CssClass="alert alert-danger text-dg-danger" Text="" Visible="false"></asp:Label>
                <div>
                    <asp:Label ID="lblIngreseEmail" CssClass="form-label alert-link" runat="server" Text="Ingrese el Email"></asp:Label>
                    
                </div>
                <div>
                    <asp:TextBox ID="tbxEmail" CssClass="container text-center" runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Button ID="btnAceptar" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" runat="server" OnClick="btnAceptar_Click" Text="Recuperar contraseña" />
                    <a href="Default.aspx" class="btn btn-info text-white w-20 fw-semibold shadow-sm">Volver</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
