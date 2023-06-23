<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargaPaciente.aspx.cs" Inherits="TP_Final_equipo2.CargaPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            background-color: #f2f2f2;
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        .welcome {
            text-align: center;
            font-size: 30px;
            color: #333;
        }

        .container {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
        }

        .form-label {
            font-weight: bold;
            color: #333;
        }

        .form-control {
            width: 100%;
            padding: 10px;
            font-size: 16px;
            background-color: #fff;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        .mb-3 {
            margin-bottom: 20px;
        }

        .text-center {
            text-align: center;
        }

        .btn-primary {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            font-size: 16px;
            border-radius: 4px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

            .btn-primary:hover {
                background-color: #0056b3;
            }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
        <h1 class="welcome">Carga del nuevo paciente...</h1>
        <hr />
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
                    <asp:DropDownList ID="ddlSexo" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblTelefono" CssClass="form-label alert-link accordion-button" runat="server" Text="Teléfono"></asp:Label>
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
    <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>--%>
    <div class="container">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de nacimiento"></asp:Label>
                    <asp:TextBox ID="FechaNacimiento" CssClass="form-control" type="date" placeholder="Fecha de Nacimiento" runat="server" />
                </div>
            </div>
        </div>
    </div>
    <%-- </ContentTemplate>
    </asp:UpdatePanel>--%>

    <div class="container text-center">
        <hr />
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">

                    <div>
                        <%-- MODAL --%>
                        <button id="btnAceptar" type="button" class="btn btn-primary" data-bs-toggle="modal" OnClick="btnAceptar_Click" text="Aceptar" data-bs-target="#staticBackdrop">
                            Aceptar
                        </button>
                        <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                            <div class="modal-dialog modal-xl">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title" id="staticBackdropLabel">Confirmacion de alta</h2>
                                        <asp:Button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" runat="server" />
                                    </div>
                                    <div class="modal-body">
                                        <asp:Label ID="lblMensaje1" runat="server" Text="Paciente cargado exitosamente..."></asp:Label>
                                    </div>
                                    <div class="modal-footer">
                                        <asp:Button ID="btnAceptar2" type="button" class="btn btn-secondary" Text="Ir a Home" data-bs-dismiss="modal" runat="server" OnClick="btnAceptar2_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <%--<asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnAceptar_Click" />--%>
                        <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-primary" OnClick="btnVolver_Click" Text="Volver" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
