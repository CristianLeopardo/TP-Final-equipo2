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
   <%-- <script>
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
    </script>--%>

    


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">
            <div class="container text-center">
                <asp:Label ID="lblTitulo" class="welcome" runat="server" Text="Carga del nuevo Paciente... <i class='bi bi-person-fill-add'></i>"></asp:Label>
                <%if (Session["AlertaMensajeok"] != null)
                    {%>
                <div class="alert alert-success alert-dismissible fade show" id="alerta">
                    <asp:button class="btn-close" data-bs-dismiss="alert" autopostback="false" runat="server"></asp:button>
                    <strong>Perfecto !</strong> Paciente cargado exitosamente...
                </div>
                <%  }
                    Session["AlertaMensaje"] = null;
                %>

                <hr />
                <asp:ValidationSummary runat="server" DisplayMode="BulletList" CssClass="text-danger fs-2" HeaderText="<i class='bi bi-exclamation-triangle-fill'></i> Complete los campos obligatorios <i class='bi bi-exclamation-triangle-fill'></i>" ValidationGroup="GrupoPaciente" />
                
                <div class="row align-items-start">
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblApellido" CssClass="form-label alert-link accordion-button" runat="server">Apellido<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxApellido" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvApellido" ControlToValidate="tbxApellido" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblNombre" CssClass="form-label alert-link accordion-button" runat="server">Nombre<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxNombre" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre" ControlToValidate="tbxNombre" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblDni" CssClass="form-label alert-link accordion-button" runat="server">DNI<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxDni" TextMode="Number" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDni" ControlToValidate="tbxDni" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblSexo" CssClass="form-label alert-link accordion-button" runat="server">Sexo<span style="color: red;">*</span></asp:Label>
                        <asp:DropDownList ID="ddlSexo" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvSexo" ControlToValidate="ddlSexo" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblEstado" CssClass="form-label alert-link accordion-button" runat="server">Estado<span style="color: red;">*</span></asp:Label>
                        <asp:DropDownList ID="ddlEstado" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvEstado" ControlToValidate="ddlEstado" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server">Fecha de nacimiento<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="FechaNacimiento" CssClass="form-control bg-light" type="date" placeholder="Fecha de Nacimiento" runat="server" />
                        <asp:RequiredFieldValidator ID="rfvFechaNacimiento" ControlToValidate="FechaNacimiento" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblTelefono" CssClass="form-label alert-link accordion-button" runat="server">Télefono<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxTelefono" TextMode="Phone" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTelefono" ControlToValidate="tbxTelefono" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblCelular" CssClass="form-label alert-link accordion-button" runat="server">Celular<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxCelular" TextMode="Phone" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCelular" ControlToValidate="tbxCelular" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server">Email<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxEmail" TextMode="Email" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="tbxEmail" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblDomicilio" CssClass="form-label alert-link accordion-button" runat="server">Domicilio<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxDomicilio" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDomicilio" ControlToValidate="tbxDomicilio" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblLocalidad" CssClass="form-label alert-link accordion-button" runat="server">Localidad<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxLocalidad" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvLocalidad" ControlToValidate="tbxLocalidad" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblProvincia" CssClass="form-label alert-link accordion-button" runat="server">Provincia<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxProvincia" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvProvincia" ControlToValidate="tbxProvincia" ValidationGroup="GrupoPaciente" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <hr />
            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col">
                        <div class="mb-3">
                            <div>
                                <asp:Button type="button" class="btn btn-info text-white w-20 fw-semibold shadow-sm" ID="btnAceptar" Text="Cargar" autopostback="false" OnClick="btnAceptar_Click" runat="server" CausesValidation="true" ValidationGroup="GrupoPaciente"></asp:Button>
                                <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnVolver_Click" Text="Volver" />
                                <asp:Label ID="lblmensaje" autopostback="true" Visible="false" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
