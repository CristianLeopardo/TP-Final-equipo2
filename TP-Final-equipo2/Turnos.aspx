<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="TP_Final_equipo2.Turnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Turnos!</h1>
    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                DNI del paciente
                <asp:TextBox ID="txtDNIpaciente" runat="server"></asp:TextBox>
                <asp:Button ID="btnbuscardni" runat="server" OnClick="btnbuscardni_Click" Text="Buscar"  CssClass="btn" />
                <asp:Label ID="lblincorrecto" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <div class="col">
                Selecionar especialidad
                <asp:DropDownList ID="ddlEspecialidad" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEspecialidad_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="col">
                Seleccionar doctor
                <asp:DropDownList ID="ddldoctores" runat="server" OnSelectedIndexChanged="ddldoctores_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            </div>
        </div>
    </div>
    <asp:GridView ID="dgvTurnos" DataKeyNames="ID" runat="server" class="table table-dark table-striped-columns" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Paciente" DataField="NombrePaciente"/>
            <asp:BoundField HeaderText="Medico" DataField="NombreMedico"/>
            <asp:BoundField HeaderText="Especialdiad" DataField="NombreEspecialidad"/>
            <asp:BoundField HeaderText="Fecha" DataField="Fecha"/>
            <asp:BoundField HeaderText="Estado" DataField="Estado"/>
            <asp:CommandField ShowSelectButton="true" SelectText="Eliminar" HeaderText="Accion" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Turno" OnClick="btnNuevo_Click" CssClass="btn" />
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="btn" />
</asp:Content>
