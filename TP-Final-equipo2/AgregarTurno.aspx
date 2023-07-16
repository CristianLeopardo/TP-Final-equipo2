<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarTurno.aspx.cs" Inherits="TP_Final_equipo2.AgregarTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Agregando turno</h1>
    <div>
        <asp:Label ID="lblLeyenda" runat="server" Text="Ingrese el DNI del paciente:"></asp:Label>
        <asp:TextBox ID="tbxDNI" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Paciente" />
    </div>
    <div>
        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:DropDownList ID="ddlEspecialidades" AutoPostBack="true" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:DropDownList ID="ddlJornada" Visible="false" AutoPostBack="true"  OnSelectedIndexChanged="ddlJornada_SelectedIndexChanged" runat="server"></asp:DropDownList>
    </div>
    <asp:DropDownList ID="ddlMedicos" Visible="false" AutoPostBack="true" OnLoad="ddlMedicos_Load" OnSelectedIndexChanged="ddlMedicos_SelectedIndexChanged" runat="server"></asp:DropDownList>

    <div>
        <asp:TextBox ID="tbxFecha" type="date"  CssClass="form-control bg-light" placeholder="Fecha" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnBuscar2" runat="server" Text="Buscar Horario" OnClick="btnBuscar2_Click" />
    </div>
    <div>
        <asp:DropDownList ID="ddlHorarios" Visible="false" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        <asp:Button ID="btnAgregar" runat="server" Text="Tomar Turno" OnClick="btnAgregar_Click" />
        <asp:Button ID="btnReprogramar" runat="server" Text="Reprogramar"  OnClick="btnReprogramar_Click" Visible="false" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar Turno" OnClick="btnCancelar_Click" Visible="false" />
        <asp:Button ID="btnNovino" runat="server" Text="Confirmar ausencia del paciente" OnClick="btnNovino_Click" Visible="false" />
    </div>

</asp:Content>
