<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MisTurnos.aspx.cs" Inherits="TP_Final_equipo2.MisTurnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <asp:GridView ID="dgvTurnos" DataKeyNames="ID" OnSelectedIndexChanged="dgvTurnos_SelectedIndexChanged" OnRowCommand="dgvTurnos_RowCommand" class="container table table-info table-striped-columns text-center text-truncate" AutoGenerateColumns="false" runat="server">
            <Columns>
            <asp:BoundField HeaderText="Paciente" DataField="NombrePaciente" />
            <asp:BoundField HeaderText="Medico" DataField="NombreMedico" />
            <asp:BoundField HeaderText="Especialdiad" DataField="NombreEspecialidad" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:BoundField HeaderText="Estado" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Reprogramar" HeaderText="Reprogramar" />
                <asp:TemplateField HeaderText="Cancelar">
                <ItemTemplate>
                    <asp:Button ID="btnEliminar" runat="server" Text="❌ Cancelar ❌" CommandName="CancelarTurno" CommandArgument='<%# Container.DataItemIndex %>' CssClass="text-danger text-decoration-none" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
        <asp:Button ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" Text="Nuevo Turno" />
    </div>
</asp:Content>
