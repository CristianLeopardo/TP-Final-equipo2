<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuMedicos.aspx.cs" Inherits="TP_Final_equipo2.MenuMedicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <nav class="navbar bg-body-tertiary">
            <div class="container-fluid">
                <div class="d-flex" role="search">
                    <asp:TextBox ID="txtfiltro" runat="server"></asp:TextBox>
                    <asp:Button ID="btnbuscar" runat="server" OnClick="btnbuscar_Click" Text="Buscar" />
                </div>
            </div>
        </nav>
    </div>
    <div>
        <div class="container text-center">
            <div class="row justify-content-start">
                <div class="col">
                    <h3>Buscar por: </h3>
                </div>
                <div class="col">
                    <asp:Label ID="lblcampo" runat="server" Text="Buscar por: "></asp:Label>
                    <asp:DropDownList ID="ddlcampos" runat="server"></asp:DropDownList>
                </div>
                <div class="col">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <asp:GridView ID="dgvMedicos" runat="server" AutoGenerateColumns="false"  OnSelectedIndexChanged="dgvMedicos_SelectedIndexChanged" OnRowCommand="dgvMedicos_RowCommand" class="table table-dark table-striped-columns">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="ID" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />      
            <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
            <asp:BoundField HeaderText="DNI" DataField="DNI" />
            <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
            <asp:BoundField HeaderText="Celular" DataField="Celular" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField HeaderText="FechaIngreso" DataField="FechaIngreso" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento"  DataFormatString="{0:dd/MM/yyyy}"  />
            <asp:BoundField HeaderText="Estado" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Editar" HeaderText="Acción"/>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnAgregar" runat="server" Text="Nuevo Médico" OnClick="btnAgregar_Click" />
    <asp:Button ID="btnActivos" runat="server" Text="Mostrar Inactivos" OnClick="btnActivos_Click" />
    <asp:Label ID="lblPrueba" runat="server" Text="Label"></asp:Label>

</asp:Content>
