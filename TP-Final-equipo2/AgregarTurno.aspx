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
    <asp:DropDownList ID="ddlMedicos" Visible="false" runat="server"></asp:DropDownList>
    <div>
    </div>
    <div>
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>

</asp:Content>
