<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="TP_Final_equipo2.Turnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Turnos!</h1>
    <div class="Login">
        <div class="mb-3">
            <label class="form-label">Seleccione el paciente:</label>
            <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" ID="ddlPacientes" runat="server">
            </asp:DropDownList>
        </div>
        <div class="mb-3">
            <label class="form-label">Seleccione la especialidad:</label>
            <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" ID="ddlEspecialidades" runat="server">
            </asp:DropDownList>
            <div class="mb-3">
                <asp:Button ID="btnBuscarMedico" runat="server"  OnClick="btnBuscarMedico_Click" Text="BuscarMedico" />
            </div>

            <div class="mb-3">
                <label class="form-label">Seleccione el médico:</label>
                <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" ID="ddlMedicos" runat="server">
                </asp:DropDownList>
            </div>
            
            <div class="mb-3">
                <label class="form-label">Seleccione la fecha para el turno</label>
                <asp:Calendar ID="calFechaTurno" runat="server"></asp:Calendar>
            </div>
        </div>
</asp:Content>
