<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuEspecialidades.aspx.cs" Inherits="TP_Final_equipo2.MenuEspecialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row align-items-start">
        <h1>Menu Especialidades</h1>
        <div class="container">
            <asp:RadioButtonList ID="rbtEleccion" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Text="Agregar" Value="1"></asp:ListItem>
                <asp:ListItem Text="Modificar" Value="2"></asp:ListItem>
                <asp:ListItem Text="Eliminar" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnSeleccionar" CssClass="btn btn-primary" runat="server" Text="Seleccionar" />
        </div>
        <div class="col">
            <div class="mb-3">
                <asp:Label ID="lblEspecialidades" CssClass="form-label alert-link accordion-button" runat="server" Text="Ingrese el nombre de la especialidad:" Visible="false"></asp:Label>
                <asp:TextBox ID="tbxEspecialidad" CssClass="form-control" runat="server" Visible="false"></asp:TextBox>
            </div>
        </div>
        <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" Visible="false" ID="ddlEspecialidades" runat="server"></asp:DropDownList>
        <asp:Button ID="btnEliminar" CssClass="btn btn-primary" Visible="false" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" Visible="false" OnClick="btnAgregar_Click" Text="Agregar" />
        <asp:Button ID="btnModificar" CssClass="btn btn-primary" runat="server" Visible="false" OnClick="btnModificar_Click" Text="Modificar" />
        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
    </div>
</asp:Content>
