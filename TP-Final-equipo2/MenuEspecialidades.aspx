<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuEspecialidades.aspx.cs" Inherits="TP_Final_equipo2.MenuEspecialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row align-items-start">
        <h1>Menu Especialidades</h1>
        <div class="container">
            <asp:GridView ID="dgvEspecialidades" DataKeyNames="ID" class="table table-dark table-striped-columns" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvEspecialidades_SelectedIndexChanged" runat="server">
                <Columns>
                    <asp:BoundField HeaderText="Especialidad" DataField="Nombre" />
                    <asp:CommandField ShowSelectButton="true" SelectText="Eliminar" HeaderText="Accion" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="col">
            <div class="mb-3">
                <asp:Label ID="lblEspecialidades" CssClass="form-label alert-link accordion-button" runat="server" Text="Ingrese el nombre de la especialidad:"></asp:Label>
                <asp:TextBox ID="tbxEspecialidad" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>    
        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Button ID="btnVolver"  CssClass="btn btn-primary" OnClick="btnVolver_Click" runat="server" Text="Volver" />
        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
    </div>
</asp:Content>
