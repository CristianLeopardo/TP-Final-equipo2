<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuEspecialidades.aspx.cs" Inherits="TP_Final_equipo2.MenuEspecialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-50 text-center text-decoration-underline">
            <h1>Menu Especialidades</h1>
        </div>
    </div>
    <div class="container text-center w-50">
        <%if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Especialidad cargada")
            {%>
        <div class="alert alert-success alert-dismissible fade show">
            <button class="btn-close" data-bs-dismiss="alert"></button>
            <strong>Perfecto !</strong> Especialidad cargada exitosamente...
        </div>
        <%}
            if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Especialidad eliminada")
            {%>
        <div class="alert alert-danger alert-dismissible fade show">
            <button class="btn-close" data-bs-dismiss="alert"></button>
             Especialidad <strong>eliminada </strong>exitosamente...
        </div>
        <%}
          Session["AlertaMensaje"] = null;%>
    </div>
    <div class="container">
        <asp:GridView ID="dgvEspecialidades" DataKeyNames="ID" class="container table table-info w-50 table-striped-columns text-center" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvEspecialidades_SelectedIndexChanged" runat="server">
            <Columns>
                <asp:BoundField HeaderText="Especialidad" DataField="Nombre" />
                <asp:CommandField ShowSelectButton="true" ControlStyle-CssClass="text-danger text-decoration-none" SelectText="❌ ELIMINAR ❌" HeaderText="Accion" />
            </Columns>
        </asp:GridView>
    </div>

    <div class="container text-center">
        <button type="button" class="btn btn-success text-white fw-semibold" data-bs-toggle="modal" data-bs-target="#exampleModal">
            Agregar Especialidad
        </button>
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header text-center">
                        <h1 class="modal-title fs-2" id="exampleModalLabel">Agregar Especialidad</h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <h4 class="fs-6 text-center text-success">Ingrese el nombre de la especialidad: </h4>
                        <asp:TextBox ID="tbxEspecialidad" CssClass="form-control bg-light bg-success-subtle" runat="server"></asp:TextBox>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
                        <asp:Button ID="btnAgregar" CssClass="btn btn-success" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                    </div>
                </div>
            </div>
        </div>

        <asp:Button ID="btnVolver" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnVolver_Click" runat="server" Text="Volver" />
    </div>
</asp:Content>
