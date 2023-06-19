<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargaPaciente.aspx.cs" Inherits="TP_Final_equipo2.CargaPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                    <asp:TextBox ID="tbxDni" CssClass="form-control" runat="server"></asp:TextBox>
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
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de nacimiento"></asp:Label>
                    <asp:Calendar ID="calFechaNacimiento" runat="server"></asp:Calendar>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <div>
                        <asp:Button ID="btnAceptar" runat="server" CssClass="btn-toolbar" Text="Aceptar" OnClick="btnAceptar_Click"/>
                        <asp:Button ID="btnVolver" runat="server" CssClass="btn-toolbar" Text="Volver" />
                    </div>
                    <div>
                        <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
