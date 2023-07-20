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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">

            <div class="container text-center">
                <asp:Label ID="lblTitulo" class="welcome" runat="server" Text="Carga de nuevo Médico... <i class='bi bi-person-fill-add'></i>"></asp:Label>
                <%if (Session["AlertaMensaje"] != null && lblerror.Visible == false)
                    {%>
                        <div class="alert alert-success alert-dismissible fade show">
                        <asp:Button class="btn-close" data-bs-dismiss="alert" autopostback="false" runat="server"></asp:Button>
                        <strong>Perfecto !</strong> Medico cargado exitosamente...
                        <a href="MenuMedicos.aspx" class="alert-link">Menú de Médicos</a>
                </div>
                <%  }
                    Session["AlertaMensaje"] = null;
                %>
                <hr />
                <asp:ValidationSummary runat="server" DisplayMode="BulletList" CssClass="text-danger fs-2" HeaderText="<i class='bi bi-exclamation-triangle-fill'></i> Complete los campos obligatorios <i class='bi bi-exclamation-triangle-fill'></i>" ValidationGroup="GrupoMedico" />
                <div class="row align-items-start">
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblApellido" CssClass="form-label alert-link accordion-button" runat="server">Apellido<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxApellido" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvApellido" ControlToValidate="tbxApellido" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblNombre" CssClass="form-label alert-link accordion-button" runat="server">Nombre<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxNombre" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre" ControlToValidate="tbxNombre" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblDni" CssClass="form-label alert-link accordion-button" runat="server">DNI<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxDni" TextMode="Number" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDni" ControlToValidate="tbxDni" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblSexo" CssClass="form-label alert-link accordion-button" runat="server">Sexo<span style="color: red;">*</span></asp:Label>
                        <asp:DropDownList ID="ddlSexo" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvSexo" ControlToValidate="ddlSexo" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblEstado" CssClass="form-label alert-link accordion-button" runat="server">Estado<span style="color: red;">*</span></asp:Label>
                        <asp:DropDownList ID="ddlEstado" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvEstado" ControlToValidate="ddlEstado" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblJornada" CssClass="form-label alert-link accordion-button" runat="server">Jornada<span style="color: red;">*</span></asp:Label>
                        <asp:DropDownList ID="ddlJornada" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvJornada" ControlToValidate="ddlJornada" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblTelefono" CssClass="form-label alert-link accordion-button" runat="server">Telefono<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxTelefono" TextMode="Phone" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTelefono" ControlToValidate="tbxTelefono" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblCelular" CssClass="form-label alert-link accordion-button" runat="server">Celular<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxCelular" TextMode="Phone" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCelular" ControlToValidate="tbxCelular" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-4 mb-3">
                        <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server">Email<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="tbxEmail" TextMode="Email" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="tbxEmail" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col-6 mb-3">
                        <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server">Fecha de nacimiento<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="FechaNacimiento" type="date" CssClass="form-control bg-light" placeholder="Fecha de Nacimiento" runat="server" />
                        <asp:RequiredFieldValidator ID="rfvFechaNacimiento" ControlToValidate="FechaNacimiento" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-6 mb-3">
                        <asp:Label ID="lvlFechaIngreso" CssClass="form-label alert-link accordion-button" runat="server">Fecha de ingreso<span style="color: red;">*</span></asp:Label>
                        <asp:TextBox ID="FechaIngreso" CssClass="form-control bg-light" type="date" placeholder="Fecha de Ingreso" runat="server" />
                        <asp:RequiredFieldValidator ID="rfvFechaIngreso" ControlToValidate="FechaIngreso" ValidationGroup="GrupoMedico" runat="server"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <hr />
            </div>


            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col">
                        <div class="mb-3">

                            <div>

                                <%--<asp:Button ID="btcontinuar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Continuar" OnClientClick="return validar()" OnClick="btcontinuar_Click" />--%>

                                <asp:Button ID="btcontinuar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Continuar" OnClick="btcontinuar_Click" CausesValidation="true" ValidationGroup="GrupoMedico" />
                            </div>
                            <div>
                                <asp:Button ID="btnEspecialidades" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Ver Especialidades" OnClick="btnEspecialidades_Click" Visible="false" />
                            </div>
                            <div>
                                <asp:Label ID="lblmensaje" runat="server" Text="" Visible="false"></asp:Label>
                                <asp:Label ID="lblerror" runat="server" Text="" Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <%if (lblmensaje.Visible == true && lblerror.Visible == false && lblTitulo.Text != "Modificando Médico")
                {%>
            <div class="container text-center">
                <h2>Especialidades</h2>
            </div>
            <div>
                <asp:GridView ID="dgvEspcialidades" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" CssClass="container table table-info w-50 table-striped-columns text-center" OnSelectedIndexChanged="dgvEspcialidades_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="ID"/>
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
            <%}%>

            <div class="container text-center">
                <div class="row align-items-start">
                    <div class="col">
                        <div class="mb-3">
                            <div>
                                <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnVolver_Click" Text="Volver" />
                                <%--<asp:Button ID="btnaceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnaceptar_Click" Visible="false" />--%>
                                <asp:Button ID="btnAceptar" type="button" class="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Aceptar" OnClientClick="return validar()" OnClick="btnAceptar_Click" runat="server" />
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
                                <%--<asp:Button ID="btnAceptar" type="button" class="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Aceptar" OnClick="btnAceptar_Click" runat="server" />--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
