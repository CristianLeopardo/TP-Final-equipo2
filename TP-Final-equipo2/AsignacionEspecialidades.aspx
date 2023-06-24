<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AsignacionEspecialidades.aspx.cs" Inherits="TP_Final_equipo2.AsignacionEspecialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Asigne las especialidades al médico correspondiente</h1>
    <div class="row align-items-start">
        <div class="container text-center">
            <asp:RadioButtonList ID="rbtEleccion"  OnSelectedIndexChanged="rbtEleccion_SelectedIndexChanged" runat="server">
                <asp:ListItem Text="Agregar" Value="1"></asp:ListItem>
                <asp:ListItem Text="Eliminar" Value="2"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnSeleccionar" CssClass="btn btn-primary" runat="server" Text="Seleccionar" />
        </div>
        <div class="container text-center">
            <div>
                <label for="exampleInputPassword1" class="form-label">Medicos</label>
            </div>
            <asp:DropDownList ID="ddlMedicos" CssClass="btn btn-secondary dropdown-toggle" OnSelectedIndexChanged="ddlMedicos_SelectedIndexChanged" runat="server" AutoPostBack="True"></asp:DropDownList>
        </div>
        <div class="container text-center">
            <div>
                <label for="exampleInputPassword1" class="form-label">Especialidades</label>
            </div>
            <asp:DropDownList ID="ddlEspecialidades" CssClass="btn btn-secondary dropdown-toggle" runat="server"></asp:DropDownList>
        </div>
        <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" Visible="false" ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:Button ID="btnEliminar" CssClass="btn btn-primary" Visible="false" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" Visible="false" OnClick="btnAgregar_Click" Text="Agregar" />
      
        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
    </div>
</asp:Content>
