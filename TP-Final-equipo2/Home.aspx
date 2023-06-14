<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TP_Final_equipo2.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido al HOME...</h1>
    <div class="Login">
        <div class="d-grid gap-2 col-6 mx-auto" style="max-block-size=20px">
            <div>
                <asp:Button runat="server" Cssclass="btn btn-secondary btn-lg" id="btnnewPaciente" OnClick="btnnewPaciente_Click" Text="Cargar nuevo paciente"/>
            </div>
            <div>
                <asp:Button runat="server" Cssclass="btn btn-secondary btn-lg" id="btnnewMedico" OnClick="btnnewMedico_Click" Text="Cargar nuevo medico" />
            </div>
            <div>
                <asp:Button runat="server" Cssclass="btn btn-secondary btn-lg" id="btnJornada" Text="Cargar jornada" />
            </div>
            <div>
                <asp:Button runat="server" Cssclass="btn btn-secondary btn-lg" id="btTurno" Text="Cargar Turno" />
            </div>
        </div
    </div>
</asp:Content>
