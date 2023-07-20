<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuMedicos.aspx.cs" Inherits="TP_Final_equipo2.MenuMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">
            <div class="container text-center">
                <h2>Menú de Médicos <i class="bi bi-file-medical"></i></h2>
                <hr />
                <div class="container text-center">
                    <h3>Busqueda de Médicos</h3>
                    <br />
                    <div class="row justify-content-md-center">
                        <div class="col col-lg-3">
                            <asp:Label ID="lblcampo" CssClass="form-label alert-link" runat="server" Text="Buscar por: "></asp:Label>
                            <asp:DropDownList ID="ddlcampos" runat="server" AutoPostBack="true" CssClass="rounded-pill text-white text-bg-info text-center" OnSelectedIndexChanged="ddlcampos_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="col-md-auto">
                            <asp:Label ID="lblcriterio" CssClass="form-label alert-link" runat="server" Text=""></asp:Label>
                            <asp:TextBox ID="txtcriterio" CssClass="bg-light bg-success-subtle" OnTextChanged="txtcriterio_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                        </div>
                        <div class="col col-lg-2">
                            <asp:Button ID="btnfiltrar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnfiltrar_Click" Text="Buscar" />
                        </div>
                    </div>
                </div>
                <br />
                <div>
                    <div>
                        <div class="col">
                            <p>Filtrar por especialidades</p>
                            <asp:DropDownList ID="ddlespecialidades" CssClass="rounded-pill text-white text-bg-info text-center" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlespecialidades_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center w-50">
        <%if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Medico eliminado")
            {%>
        <div class="alert alert-danger alert-dismissible fade show">
            <button class="btn-close" data-bs-dismiss="alert"></button>
            Médico <strong>dado de baja </strong>exitosamente...
        </div>
        <%}
            Session["AlertaMensaje"] = null;%>
    </div>


    <asp:GridView ID="dgvMedicos" runat="server" DataKeyNames="ID" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvMedicos_SelectedIndexChanged" OnRowCommand="dgvMedicos_RowCommand" CssClass="container table table-info table-striped-columns text-center text-truncate">
        <Columns>
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
            <asp:BoundField HeaderText="DNI" DataField="DNI" />
            <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
            <asp:BoundField HeaderText="Celular" DataField="Celular" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField HeaderText="Jornada" DataField="JornadaLaboral" />
            <asp:BoundField HeaderText="FechaIngreso" DataField="FechaIngreso" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField HeaderText="Estado" DataField="Estado" />
            <asp:CommandField ShowSelectButton="true" ControlStyle-CssClass="text-decoration-none text-success" SelectText="Modificar <i class='bi bi-pencil-fill'></i>" HeaderText="Modificar" />
            <asp:TemplateField HeaderText="Eliminar">
                <ItemTemplate>
                    <asp:Button ID="btnEliminar" runat="server" Text="❌ ELIMINAR ❌" CommandName="EliminarMedico" CommandArgument='<%# Container.DataItemIndex %>' CssClass="text-danger border-danger-subtle" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div class="container text-center">
        <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Nuevo Médico" OnClick="btnAgregar_Click" />
        <asp:Button ID="btnActivos" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Mostrar Activos" OnClick="btnActivos_Click" />
        <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnVolver_Click" Text="Volver" />
    </div>
    <br />

</asp:Content>
