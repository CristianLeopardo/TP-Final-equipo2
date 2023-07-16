<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="TP_Final_equipo2.Turnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Turnos!</h1>

    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                Filtrar
                <asp:TextBox ID="txtFiltro" AutoPostBack="true" OnTextChanged="txtFiltro_TextChanged" runat="server"></asp:TextBox>
                Presione Enter o Tab para aplicar el filtro
            </div>
        </div>
    </div>
    <asp:GridView ID="dgvTurnos" DataKeyNames="ID" OnSelectedIndexChanged="dgvTurnos_SelectedIndexChanged" runat="server" class="table table-dark table-striped-columns" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Paciente" DataField="NombrePaciente" />
            <asp:BoundField HeaderText="Medico" DataField="NombreMedico" />
            <asp:BoundField HeaderText="Especialdiad" DataField="NombreEspecialidad" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="Estado" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Cambiar estado" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Turno" OnClick="btnNuevo_Click" CssClass="btn" />
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="btn" />
</asp:Content>
