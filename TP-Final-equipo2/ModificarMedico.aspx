<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarMedico.aspx.cs" Inherits="TP_Final_equipo2.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <h2>Modificar Médico</h2>
    </div>
    <div class="Login">
        <div class="mb-3">
            <label class="form-label">Seleccione el médico:</label>
            <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" ID="ddlMedicos" runat="server">
            </asp:DropDownList>
        </div>
        <div class="mb-3">
            <label class="form-label">o ingrese el DNI del médico:</label>
            <asp:TextBox ID="tbxDNI" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" runat="server" Text="Buscar" />
        </div>

    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblApellido" CssClass="form-label alert-link accordion-button" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="tbxApellido" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblNombre" CssClass="form-label alert-link accordion-button" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="tbxNombre" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblDni" CssClass="form-label alert-link accordion-button" runat="server" Text="DNI"></asp:Label>
                    <asp:TextBox ID="tbxDNINuevo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col-5">
                <div class="mb-3">
                    <asp:Label ID="lblSexo" CssClass="form-label alert-link accordion-button" runat="server" Text="Sexo"></asp:Label>
                    <asp:DropDownList ID="ddlSexo" CssClass="list-group-item-action bg-dark-subtle " runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblTelefono" CssClass="form-label alert-link accordion-button" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="tbxTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblCelular" CssClass="form-label alert-link accordion-button" runat="server" Text="Celular"></asp:Label>
                    <asp:TextBox ID="tbxCelular" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="tbxEmail" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <asp:Label ID="lblActivo" CssClass="form-label alert-link accordion-button" runat="server" Text="Medico Activo" Visible="false"></asp:Label>
        <asp:Label ID="lblInactivo" CssClass="form-label alert-link accordion-button" runat="server" Text="Medico Inactivo" Visible="false"></asp:Label>
        </div>
    <div class="container text-center">
        <div class="mb-3">
            <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de nacimiento"></asp:Label>
            <asp:Calendar ID="calFechaNacimiento" runat="server"></asp:Calendar>
            <asp:Label ID="lvlFechaIngreso" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de ingreso"></asp:Label>
            <asp:Calendar ID="calFechaIngreso" runat="server"></asp:Calendar>
        </div>
    </div>


    <div class="container text-center">
        <div>
            <label for="exampleInputPassword1" class="form-label">Especialidades</label>
        </div>
        <div>
            <asp:DropDownList ID="ddlEspecialidades" CssClass="btn btn-secondary dropdown-toggle" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <div>
                        <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnAceptar_Click" />
                        <asp:Button ID="btnVovler" runat="server" CssClass="btn btn-primary" OnClick="btnVovler_Click" Text="Volver" />
                        <asp:Button ID="btnEliminar" runat="server" CssClass="btn btn-primary" OnClick="btnEliminar_Click" Text="Eliminar" />
                    </div>
                    <div>
                        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>

    
</asp:Content>
