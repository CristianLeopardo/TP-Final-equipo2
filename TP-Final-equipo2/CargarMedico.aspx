<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargarMedico.aspx.cs" Inherits="TP_Final_equipo2.CargarMedico" %>

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
                var fechaingreso = document.getElementById("<% = FechaIngreso.ClientID %>").value;
                var fechanacimiento = document.getElementById("<% = FechaNacimiento.ClientID %>").value;

            if (apellido === "" || nombre === "" || dni === "" || telefono === "" || celular === "" || email === "" || fechaingreso === "" || fechanacimiento === "") {
                alert("Por favor, complete todos los campos.");
                return false;
            }
            return true;

        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">

            <div class="container text-center">
                <asp:Label ID="lblTitulo" class="welcome" runat="server" Text="Carga de nuevo Médico..."></asp:Label>
                <%if (Session["AlertaMensaje"] != null)
                    {%>
                <div class="alert alert-success alert-dismissible fade show">
                    <button class="btn-close" data-bs-dismiss="alert"></button>
                    <strong>Perfecto !</strong> Medico cargado exitosamente...
                    <a href="MenuMedicos.aspx" class="alert-link">Menú de Médicos</a>
                </div>
                <%  }
                    Session["AlertaMensaje"] = null;
                %>
                <hr />
                <div class="row align-items-start">
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblApellido" CssClass="form-label alert-link accordion-button" runat="server" Text="Apellido"></asp:Label>
                            <asp:TextBox ID="tbxApellido" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblNombre" CssClass="form-label alert-link accordion-button" runat="server" Text="Nombre"></asp:Label>
                            <asp:TextBox ID="tbxNombre" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblDni" CssClass="form-label alert-link accordion-button" runat="server" Text="DNI"></asp:Label>
                            <asp:TextBox ID="tbxDni" TextMode="Number" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblSexo" CssClass="form-label alert-link accordion-button" runat="server" Text="Sexo"></asp:Label>
                            <asp:DropDownList ID="ddlSexo" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        </div>
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblEstado" CssClass="form-label alert-link accordion-button" runat="server" Text="Estado:"></asp:Label>
                            <asp:DropDownList ID="ddlEstado" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        </div>
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblJornada" CssClass="form-label alert-link accordion-button" runat="server" Text="Jornada:"></asp:Label>
                            <asp:DropDownList ID="ddlJornada" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblTelefono" CssClass="form-label alert-link accordion-button" runat="server" Text="Telefono"></asp:Label>
                            <asp:TextBox ID="tbxTelefono" TextMode="Phone" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblCelular" CssClass="form-label alert-link accordion-button" runat="server" Text="Celular"></asp:Label>
                            <asp:TextBox ID="tbxCelular" TextMode="Phone" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-4 mb-3">
                            <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server" Text="Email"></asp:Label>
                            <asp:TextBox ID="tbxEmail" TextMode="Email" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                        <div class="col-6 mb-3">
                            <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de nacimiento"></asp:Label>
                            <asp:TextBox ID="FechaNacimiento" type="date" CssClass="form-control bg-light" placeholder="Fecha de Nacimiento" runat="server" />
                        </div>
                        <div class="col-6 mb-3">
                            <asp:Label ID="lvlFechaIngreso" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de ingreso"></asp:Label>
                            <asp:TextBox ID="FechaIngreso" CssClass="form-control bg-light" type="date" placeholder="Fecha de Ingreso" runat="server" />
                        </div>
                </div>
                <hr />
            </div>


            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col">
                        <div class="mb-3">
                            <div>
                                <asp:Button ID="btcontinuar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Continuar" OnClick="btcontinuar_Click" />
                            </div>
                            <div>
                                <asp:Button ID="btnEspecialidades" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Ver Especialidades" OnClick="btnEspecialidades_Click" Visible="false" />
                            </div>
                            <div>
                                <asp:Label ID="lblmensaje" runat="server" Text="" Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <%if (lblmensaje.Visible == true && lblTitulo.Text != "Modificando Médico")
                {%>
            <div class="container text-center">
                <div>
                    <h2>Especialidades</h2>
                </div>
                <div class="table">
                    <asp:GridView ID="dgvEspcialidades" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" OnSelectedIndexChanged="dgvEspcialidades_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="ID" />
                            <asp:BoundField HeaderText="Especialidad" DataField="Nombre" />
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label ID="lblSeleccionar" runat="server" Text="Seleccionar"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="Checked" runat="server" AutoPostBack="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--  
                    <asp:CheckBoxField HeaderText="Seleccionar" Visible="true" />
                    <asp:CommandField ShowSelectButton="true" SelectText="✅" HeaderText="Cargar" />
                            --%>
                        </Columns>
                    </asp:GridView>
                </div>
                <div>
                    <asp:Label ID="lblEspecialidad" runat="server" Text="" Visible="false"></asp:Label>
                </div>
            </div>
            <%}%>

            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col">
                        <div class="mb-3">
                            <div>
                                <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnVolver_Click" Text="Volver" />
                                <%--<asp:Button ID="btnaceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnaceptar_Click" Visible="false" />--%>
                                <asp:Button ID="btnAceptar" type="button" class="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Aceptar" OnClick="btnAceptar_Click" runat="server" />
                                <%-- MODAL --%>
                                <%--<button id="btnAceptar" type="button" class="btn btn-info text-white w-20 fw-semibold shadow-sm" text="Aceptar">
                                    Aceptar
                                </button>--%>
                                <% %>
                                <%--<div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" tabindex="-1" aria-labelledby="staticBackdropLabel">
                                    <div class="modal-dialog modal-xl">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <h2 class="modal-title" id="staticBackdropLabel">Confirmacion de alta</h2>
                                                <asp:Button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" runat="server" />
                                            </div>
                                            <div class="modal-body">
                                                <asp:Label ID="lblMensaje1" runat="server" Text="Medico cargado exitosamente..."></asp:Label>
                                            </div>
                                            <div class="modal-footer">
                                                <asp:Button ID="btnAceptar2" type="button" class="btn btn-secondary" Text="Ir a Home" OnClick="btnaceptar_Click" data-bs-dismiss="modal" runat="server" />
                                            </div>
                                        </div>
                                    </div>
                                </div>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
