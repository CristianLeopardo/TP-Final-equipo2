﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuMedicos.aspx.cs" Inherits="TP_Final_equipo2.MenuMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="container text-center">
            <div class="row justify-content-start">
                <div class="col">
                    <h3>Buscar por: </h3>
                </div>
                <div class="col">
                    <asp:Label ID="lblcampo" runat="server" Text="Buscar por: "></asp:Label>
                    <asp:DropDownList ID="ddlcampos" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlcampos_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div class="col">
                    <asp:Label ID="lblcriterio" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtcriterio" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <asp:Button ID="btnfiltrar" runat="server" OnClick="btnfiltrar_Click" Text="Buscar" />
                </div>
            </div>
        </div>
    </div>
        <asp:GridView ID="dgvMedicos" runat="server" DataKeyNames="ID" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvMedicos_SelectedIndexChanged" OnRowCommand="dgvMedicos_RowCommand" class="table table-dark table-striped-columns">
            <columns>
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
                <asp:BoundField HeaderText="DNI" DataField="DNI" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="Celular" DataField="Celular" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="FechaIngreso" DataField="FechaIngreso" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField HeaderText="Estado" DataField="Estado" />
                <asp:CommandField ShowSelectButton="true" SelectText="Editar" HeaderText="Acción" />
            </columns>
        </asp:GridView>
    <asp:Button ID="btnAgregar" runat="server" Text="Nuevo Médico" OnClick="btnAgregar_Click" />
    <asp:Button ID="btnActivos" runat="server" Text="Mostrar Activos" OnClick="btnActivos_Click" />
    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />

</asp:Content>