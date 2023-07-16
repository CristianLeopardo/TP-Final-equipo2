<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_Final_equipo2.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80 text-center" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-60">
            <h1>Inicie sesión para ingresar a <span class="text-primary">Tecno</span>Clinica</h1>
            <a href="Login.aspx" class="btn btn-info text-white w-20 fw-semibold shadow-sm">Iniciar sesión</a>
        </div>
    </div>
</asp:Content>
