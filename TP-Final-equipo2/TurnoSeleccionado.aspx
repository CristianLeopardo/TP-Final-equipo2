<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TurnoSeleccionado.aspx.cs" Inherits="TP_Final_equipo2.TurnoSeleccionado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-75">
            <h1 class="text-center">Informacion del turno</h1>
            <hr />
            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col">
                        <div>
                            <asp:Label ID="lblfecha" runat="server" CssClass="form-label alert-link" Text="Fecha y hora"></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lblEspecialidad" runat="server" CssClass="form-label alert-link" Text="Especialidad"></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lbldoctor" runat="server" CssClass="form-label alert-link" Text="Doctor"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="row align-items-center">
                    <div class="col">
                        <div>
                            <asp:Label ID="lblFechamuestra" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lblespecialidadmuestra" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lbldoctormuestra" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <hr />
            <h6 class="text-center text-decoration-underline">Datos del paciente</h6>
            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col">
                        <div>
                            <asp:Label ID="lblApe" runat="server" CssClass="form-label alert-link" Text="Apellido"></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lblnom" runat="server" CssClass="form-label alert-link" Text="Nombre"></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lbldni" runat="server" CssClass="form-label alert-link" Text="DNI"></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lblsex" runat="server" CssClass="form-label alert-link" Text="Sexo"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="row align-items-center">
                    <div class="col">
                        <div>
                            <asp:Label ID="lblApellidocliente" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lblNombrePac" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lblDNImuestra" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="col">
                        <div>
                            <asp:Label ID="lblsexpaciente" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <hr />

            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col">
                        <div>
                            <h4>Observaciones</h4>
                        </div>
                        <div>
                            <asp:TextBox ID="txtobservaciones" TextMode="MultiLine" CssClass="form-control" Rows="6" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col">
                        <asp:Button ID="btnvolver" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" runat="server" OnClick="btnvolver_Click" Text="Volver" />
                    </div>
                    <div class="col">
                        <asp:Button ID="btncancelarturno" CssClass="btn btn-danger text-white w-20 fw-semibold shadow-sm" runat="server" OnClick="btncancelarturno_Click" Text="Cancelar Turno" />
                    </div>
                    <div class="col">
                        <asp:Button ID="btnguardar" CssClass="btn btn-success text-white w-20 fw-semibold shadow-sm" OnClick="btnguardar_Click" runat="server" Text="Guardar" />
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
