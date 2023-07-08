<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuPacientes.aspx.cs" Inherits="TP_Final_equipo2.MenuPacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">
            <div class="container text-center">
                <h2>Menú de Pacientes</h2>
                <hr />
                <div class="container text-center">
                    <h3>Busqueda de Pacientes</h3>
                    <br />
                    <div class="row justify-content-md-center">
                        <div class="col col-lg-3">
                            <asp:Label ID="lblcampo" CssClass="form-label alert-link" runat="server" Text="Buscar por: "></asp:Label>
                            <asp:DropDownList ID="ddlcampos" runat="server" AutoPostBack="true" CssClass="rounded-pill text-white text-bg-info text-center" OnSelectedIndexChanged="ddlcampos_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="col-md-auto">
                            <asp:Label ID="lblcriterio" CssClass="form-label alert-link" runat="server" Text=""></asp:Label>
                            <asp:TextBox ID="txtcriterio" CssClass="bg-light bg-success-subtle" runat="server"></asp:TextBox>
                        </div>
                        <div class="col col-lg-2">
                            <asp:Button ID="btnfiltrar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnfiltrar_Click" Text="Buscar" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <asp:GridView ID="dgvPacientes" runat="server" DataKeyNames="ID" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvPacientes_SelectedIndexChanged" OnRowCommand="dgvPacientes_RowCommand" CssClass="container table table-info table-striped-columns text-center">
        <Columns>
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
            <asp:BoundField HeaderText="DNI" DataField="DNI" />
            <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
            <asp:BoundField HeaderText="Celular" DataField="Celular" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField HeaderText="Domicilio" DataField="Domicilio" />
            <asp:BoundField HeaderText="Localidad" DataField="Localidad" />
            <asp:BoundField HeaderText="Provincia" DataField="Provincia" />
            <asp:BoundField HeaderText="Estado" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />
        </Columns>
    </asp:GridView>
    <div class="container text-center">
        <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Nuevo Paciente" OnClick="btnAgregar_Click" />
        <asp:Button ID="btnActivos" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Mostrar Activos" OnClick="btnActivos_Click" />
        <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnVolver_Click" Text="Volver" />
    </div>
    <br />

</asp:Content>
