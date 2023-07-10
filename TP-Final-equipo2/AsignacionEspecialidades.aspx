<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AsignacionEspecialidades.aspx.cs" Inherits="TP_Final_equipo2.AsignacionEspecialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Asigne las especialidades al médico correspondiente</h1>
    <asp:GridView ID="dgvEspecialidadesMedico" OnSelectedIndexChanged="dgvEspecialidadesMedico_SelectedIndexChanged" DataKeyNames="IDEspecialdiad" class="container table table-info w-50 table-striped-columns text-center" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField HeaderText="Especialidad" DataField="NombreEspecialidad" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Eliminar" HeaderText="Accion" />
                    </Columns>
     </asp:GridView>

        <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" ID="ddlEspecialidades" runat="server"></asp:DropDownList>
        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
    <asp:Button ID="btnVolver" CssClass="btn btn-primary" OnClick="btnVolver_Click" runat="server" Text="Volver" />
        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
        
</asp:Content>
