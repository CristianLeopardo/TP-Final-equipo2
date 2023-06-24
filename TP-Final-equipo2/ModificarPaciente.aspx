<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ModificarPaciente.aspx.cs" Inherits="TP_Final_equipo2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <h2>Modificar Paciente</h2>
    </div>
    <div class="Login">
        <div class="mb-3">
            <label class="form-label">Seleccione el paciente:</label>
            <asp:DropDownList CssClass="btn btn-secondary dropdown-toggle" ID="ddlPacientes" runat="server">
            </asp:DropDownList>
        </div>
        <div class="mb-3">
            <label class="form-label">o ingrese el DNI del paciente:</label>
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
                    <asp:TextBox ID="tbxDNIN" CssClass="form-control" runat="server"></asp:TextBox>
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
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblDomicilio" CssClass="form-label alert-link accordion-button" runat="server" Text="Domicilio"></asp:Label>
                    <asp:TextBox ID="tbxDomicilio" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblLocalidad" CssClass="form-label alert-link accordion-button" runat="server" Text="Localidad"></asp:Label>
                    <asp:TextBox ID="tbxLocalidad" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblProvincia" CssClass="form-label alert-link accordion-button" runat="server" Text="Provincia"></asp:Label>
                    <asp:TextBox ID="tbxProvincia" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <asp:Label ID="lblActivo" CssClass="form-label alert-link accordion-button" runat="server" Text="Paciente Activo" Visible="false"></asp:Label>
        <asp:Label ID="lblInactivo" CssClass="form-label alert-link accordion-button" runat="server" Text="Paciente Inactivo" Visible="false"></asp:Label>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de nacimiento"></asp:Label>
                    <asp:TextBox ID="FechaNacimiento" CssClass="form-control" type="date" placeholder="Fecha de Nacimiento" runat="server" />
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <div>
                        <%-- MODAL ACEPTAR --%>
                        <button id="btnAceptar" type="button" class="btn btn-primary" OnClick="btnAceptar_Click" data-bs-toggle="modal" text="Modificar" data-bs-target="#staticBackdrop">
                            Modificar
                        </button>
                        <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                            <div class="modal-dialog modal-xl">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title" id="staticBackdropLabel">Confirmación de modificación</h2>
                                        <asp:Button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" runat="server" />
                                    </div>
                                    <div class="modal-body">
                                        <asp:Label ID="lblMensaje1" runat="server" Text="Paciente modificado exitosamente..."></asp:Label>
                                    </div>
                                    <div class="modal-footer">
                                        <asp:Button ID="btnHome" type="button" class="btn btn-secondary" Text="Ir a Home" OnClick="btnHome_Click" data-bs-dismiss="modal" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-primary" OnClick="btnVolver_Click" Text="Volver" />
                        <%-- MODAL ELIMINAR --%>
                        <button id="btnEliminar" type="button" class="btn btn-primary" OnClick="btnEliminar_Click" data-bs-toggle="modal" text="Eliminar" data-bs-target="#staticBackdrop1">
                            Eliminar
                        </button>
                        <div class="modal fade" id="staticBackdrop1" data-bs-backdrop="static" tabindex="-1" aria-labelledby="staticBackdropLabel1" aria-hidden="true">
                            <div class="modal-dialog modal-xl">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title" id="staticBackdropLabel1">Confirmación de modificación</h2>
                                        <asp:Button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" runat="server" />
                                    </div>
                                    <div class="modal-body">
                                        <asp:Label ID="lblMensaje2" runat="server" Text="Paciente eliminado exitosamente..."></asp:Label>
                                    </div>
                                    <div class="modal-footer">
                                        <asp:Button ID="btnHome1" type="button" class="btn btn-secondary" Text="Ir a Home" OnClick="btnHome1_Click" data-bs-dismiss="modal" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
