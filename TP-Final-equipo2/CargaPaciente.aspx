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
    <script>
        function validar() {

            var apellido = document.getElementById("<% = tbxApellido.ClientID %>").value;
            var nombre = document.getElementById("<% = tbxNombre.ClientID %>").value;
            var dni = document.getElementById("<% = tbxDni.ClientID %>").value;
            var tefelono = document.getElementById("<% = tbxTelefono.ClientID %>").value;
            var celular = document.getElementById("<% = tbxCelular.ClientID %>").value;
            var email = document.getElementById("<% = tbxEmail.ClientID %>").value;
            var domicilio = document.getElementById("<% = tbxDomicilio.ClientID %>").value;
            var localidad = document.getElementById("<% = tbxLocalidad.ClientID %>").value;
            var provincia = document.getElementById("<% = tbxProvincia.ClientID %>").value;
            var fechanacimiento = document.getElementById("<% = FechaNacimiento.ClientID %>").value;

            if (apellido === "" || nombre === "" || dni === "" || telefono === "" || celular === "" || email === "" || domicilio === "" || localidad === "" || provincia === "" || fechanacimiento === "") {
                alert("Por favor, complete todos los campos.");
                return false;
            }
            return true;

        }

        //const alertPlaceholder = document.getElementById('liveAlertPlaceholder')
        //const appendAlert = (message, type) => {
        //    const wrapper = document.createElement('div')
        //    wrapper.innerHTML = [
        //        `<div class="alert alert-${type} alert-dismissible" role="alert">`,
        //        `   <div>${message}</div>`,
        //        '   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
        //        '</div>'
        //    ].join('')

        //    alertPlaceholder.append(wrapper)
        //}

        //const alertTrigger = document.getElementById('liveAlertBtn')
        //if (alertTrigger) {
        //    alertTrigger.addEventListener('click', () => {
        //        appendAlert('Nice, you triggered this alert message!', 'success')
        //    })
        //}
    </script>


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <h1 class="welcome">Carga del nuevo paciente...</h1>
        <%if (Session["AlertaMensaje"] != null)
            {%>
        <div class="alert alert-success alert-dismissible fade show">
            <button class="btn-close" data-bs-dismiss="alert"></button>
            <strong>Perfecto !</strong> Paciente cargado exitosamente...
        </div>
        <%  }
            Session["AlertaMensaje"] = null;
            %>

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
                    <asp:TextBox ID="tbxDni" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="tbxTelefono" TextMode="Phone" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblCelular" CssClass="form-label alert-link accordion-button" runat="server" Text="Celular"></asp:Label>
                    <asp:TextBox ID="tbxCelular" TextMode="Phone" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="tbxEmail" TextMode="Email" CssClass="form-control" runat="server"></asp:TextBox>
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
    <div class="container text-center">
        <hr />
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">

                    <div>
                        <%-- MODAL --%>
                        <%--<asp:Button ID="btnAceptar" type="button" class="btn btn-primary" data-bs-toggle="modal" autopostback="false" OnClientClick="return validar()" OnClick="btnAceptar_Click" Text="Aceptar" data-bs-target="#staticBackdrop" runat="server"></asp:Button>--%>

                        <asp:Button type="button" class="btn btn-primary" ID="btnAceptar" Text="Aceptar" autopostback="false" OnClientClick="return validar()" OnClick="btnAceptar_Click" runat="server"></asp:Button>

                        <%--<div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" tabindex="-1" aria-labelledby="staticBackdropLabel">
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
                        </div>--%>
                        <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-primary" OnClick="btnVolver_Click" Text="Volver" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
