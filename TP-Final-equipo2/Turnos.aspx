<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="TP_Final_equipo2.Turnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">
            <h1 class="text-center">Carga de Turnos</h1>
            <hr />
            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col">
                        <asp:Label Text="Filtrar" CssClass="form-label alert-link" runat="server" />
                        <asp:TextBox ID="txtFiltro" AutoPostBack="true" OnTextChanged="txtFiltro_TextChanged" CssClass="bg-light bg-success-subtle" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row align-items-center">
                    <div class="col">
                        <asp:Label Text="Presione Enter o Tab para aplicar el filtro" CssClass="form-label alert-link" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:GridView ID="dgvTurnos" DataKeyNames="ID" OnSelectedIndexChanged="dgvTurnos_SelectedIndexChanged" runat="server" class="container table table-info table-striped-columns text-center text-truncate" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Paciente" DataField="NombrePaciente" />
            <asp:BoundField HeaderText="Medico" DataField="NombreMedico" />
            <asp:BoundField HeaderText="Especialdiad" DataField="NombreEspecialidad" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="Estado" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Cambiar estado" />
        </Columns>
    </asp:GridView>
    <div class="container text-center">
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Turno" OnClick="btnNuevo_Click" CssClass="btn btn-success text-white fw-semibold" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" />
    </div>
</asp:Content>
