<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AsignacionEspecialidades.aspx.cs" Inherits="TP_Final_equipo2.AsignacionEspecialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-50">
            <h2 class="text-center">Asigne las especialidades al médico correspondiente</h2>
        </div>
    </div>
    <asp:GridView ID="dgvEspecialidadesMedico" OnSelectedIndexChanged="dgvEspecialidadesMedico_SelectedIndexChanged" DataKeyNames="IDEspecialdiad" class="container table table-info w-50 table-striped-columns text-center" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField HeaderText="Especialidad" DataField="NombreEspecialidad" />
            <asp:CommandField ShowSelectButton="true" ControlStyle-CssClass="text-danger text-decoration-none" SelectText="<i class='bi bi-exclamation-circle'></i> ELIMINAR <i class='bi bi-exclamation-circle'></i>" HeaderText="Eliminar" />
        </Columns>
    </asp:GridView>
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-25 text-center">
            <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle rounded-pill text-white text-bg-info text-center mb-2" ID="ddlEspecialidades" runat="server"></asp:DropDownList>
            <asp:Button ID="btnAgregar" CssClass="btn btn-success text-white fw-semibold mb-2" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
            <asp:Button ID="btnVolver" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm mb-2" OnClick="btnVolver_Click" runat="server" Text="Volver" />
            <asp:Label ID="lblMensaje" runat="server" CssClass="text-bg-light" Text="" Visible="false"></asp:Label>
        </div>
    </div>
</asp:Content>
