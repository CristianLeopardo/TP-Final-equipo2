<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MisTurnos.aspx.cs" Inherits="TP_Final_equipo2.MisTurnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-75 text-center text-decoration-underline">
            <h1>Mis Turnos</h1>
        </div>
    </div>
    <div class="container text-center w-50">
        <%if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Turno")
            {%>
        <div class="alert alert-success alert-dismissible fade show">
            <button class="btn-close" data-bs-dismiss="alert"></button>
            <strong>Perfecto !</strong> Turno modificado exitosamente...
        </div>
        <%}
            if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Error")
            {%>
        <div class="alert alert-danger alert-dismissible fade show">
            <button class="btn-close" data-bs-dismiss="alert"></button>
            <strong>ERROR </strong>No pudo realizar la modificacion del turno...
        </div>
        <%}
            Session["AlertaMensaje"] = null;%>
    </div>
    <div>
        <asp:GridView ID="dgvTurnos" DataKeyNames="ID" OnSelectedIndexChanged="dgvTurnos_SelectedIndexChanged" OnRowCommand="dgvTurnos_RowCommand" class="container table table-info table-striped-columns text-center text-truncate" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundField HeaderText="Paciente" DataField="NombrePaciente" />
                <asp:BoundField HeaderText="Medico" DataField="NombreMedico" />
                <asp:BoundField HeaderText="Especialdiad" DataField="NombreEspecialidad" />
                <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                <asp:BoundField HeaderText="Estado" DataField="Estado" />
                <asp:CommandField ShowSelectButton="true" ControlStyle-CssClass="text-decoration-none text-success" SelectText="Reprogramar <i class='bi bi-pencil-fill'></i>" HeaderText="Reprogramar" />
                <asp:TemplateField HeaderText="Cancelar">
                    <ItemTemplate>
                        <asp:Button ID="btnEliminar" runat="server" Text="❌ Cancelar ❌" CommandName="CancelarTurno" CommandArgument='<%# Container.DataItemIndex %>' CssClass="text-danger border-danger-subtle" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="container text-center">
        <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnVolver_Click" Text="Volver" />
        <asp:Button ID="btnNuevo" runat="server" CssClass="btn btn-success text-white fw-semibold" OnClick="btnNuevo_Click" Text="Nuevo Turno" />
    </div>
</asp:Content>
