<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarTurno.aspx.cs" Inherits="TP_Final_equipo2.AgregarTurno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-75">
            <h1 class="text-center">Agregando turno</h1>
            <hr />
            <div class="container text-center w-50">
                <%if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Turno asignado")
                  {%>
                     <div class="alert alert-success alert-dismissible fade show">
                     <button class="btn-close" data-bs-dismiss="alert"></button>
                     <strong>Perfecto !</strong> Turno cargado exitosamente...
                     </div>
                <%}
                    if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Turno cancelado")
                        {%>
                            <div class="alert alert-danger alert-dismissible fade show">
                            <button class="btn-close" data-bs-dismiss="alert"></button>
                            Turno <strong>cancelado </strong>exitosamente...
                            </div>
                  <%}
                    if (Session["AlertaMensaje"] != null && Session["AlertaMensaje"].ToString() == "Turno reprogramado")
                    {%>
                        <div class="alert alert-info alert-dismissible fade show">
                        <button class="btn-close" data-bs-dismiss="alert"></button>
                        Turno <strong>reprogramado </strong>exitosamente...
                        </div>
                <%}
                    Session["AlertaMensaje"] = null;%>
            </div>
            <div class="row align-items-center">
                <div class="col text-center">
                    <asp:Label ID="lblLeyenda" runat="server" CssClass="form-label alert-link" Text="Ingrese el DNI del paciente:"></asp:Label>
                    <asp:TextBox ID="tbxDNI" CssClass="bg-light bg-success-subtle" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Buscar Paciente" />
                </div>
            </div>
            <div class="row align-items-center">
                <div class="col text-center">
                    <asp:Label ID="lblResultado" CssClass="form-label text-capitalize lead" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <br />
            <div class="row align-items-center">
                <div class="col text-center">
                    <asp:Label Text="Seleccione la especialidad: " CssClass="form-label alert-link" runat="server" />
                    <asp:DropDownList ID="ddlEspecialidades" AutoPostBack="true" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged" CssClass="rounded-pill text-white text-bg-info text-center" runat="server"></asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row align-items-center">
                <div class="col text-center">
                    <asp:Label ID="lblJornada" Text="Seleccione el rango horario: " CssClass="form-label alert-link" Visible="false" runat="server" />
                    <asp:DropDownList ID="ddlJornada" Visible="false" AutoPostBack="true" OnSelectedIndexChanged="ddlJornada_SelectedIndexChanged" CssClass="rounded-pill text-white text-bg-info text-center" runat="server"></asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row align-items-center">
                <div class="col text-center">
                    <asp:Label ID="lblMedicos" Text="Seleccione el Médico: " CssClass="form-label alert-link" Visible="false" runat="server" />
                    <asp:DropDownList ID="ddlMedicos" Visible="false" AutoPostBack="true" OnLoad="ddlMedicos_Load" CssClass="rounded-pill text-white text-bg-info text-center" OnSelectedIndexChanged="ddlMedicos_SelectedIndexChanged" runat="server"></asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="row align-items-center">
                <div class="col-4"></div>
                <div class="col-4 text-center">
                    <asp:TextBox ID="tbxFecha" type="date" CssClass="form-control bg-light" placeholder="Fecha" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="container text-center">
                <div>
                    <asp:Label Text="¡Seleccione Especialidad y Médico!" CssClass="text-bg-danger" ID="lblBuscar" Visible="false" runat="server" />
                    <asp:Label Text="¡Seleccione una Fecha!" CssClass="text-bg-danger" ID="lblFecha" Visible="false" runat="server" />
                    <asp:Label Text="¡Seleccione un Médico!" CssClass="text-bg-danger" ID="lblNoMedico" Visible="false" runat="server" />
                </div>
                <br />
                <asp:Button ID="btnBuscar2" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Buscar Horario" OnClick="btnBuscar2_Click" />
            </div>
            <br />
            <div class="row align-items-center">
                <div class="col text-center">
                    <asp:Label ID="lblHorarios" Text="Seleccione el Horario: " CssClass="form-label alert-link" Visible="false" runat="server" />
                    <asp:DropDownList ID="ddlHorarios" Visible="false" CssClass="rounded-pill text-white text-bg-info text-center" runat="server"></asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="container text-center">
                <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Volver" OnClick="btnVolver_Click" />
                <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-success text-white w-20 fw-semibold shadow-sm" Text="Tomar Turno" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnReprogramar" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Reprogramar" OnClick="btnReprogramar_Click" Visible="false" />
                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger text-white w-20 fw-semibold shadow-sm" Text="Cancelar Turno" OnClick="btnCancelar_Click" Visible="false" />
                <asp:Button ID="btnNovino" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Confirmar ausencia del paciente" OnClick="btnNovino_Click" Visible="false" />
            </div>
        </div>
    </div>

</asp:Content>
