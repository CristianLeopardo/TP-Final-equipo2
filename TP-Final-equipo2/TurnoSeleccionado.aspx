<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TurnoSeleccionado.aspx.cs" Inherits="TP_Final_equipo2.TurnoSeleccionado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <div>
                    <asp:Label ID="lblfecha" runat="server" Text="Fecha"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblFechamuestra" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblespecialidadmuestra" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="lbldoctor" runat="server" Text="Doctor"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lbldoctormuestra" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>
    <h6>Datos del paciente</h6>
    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <div>
                    <asp:Label ID="lblApe" runat="server" Text="Apellido"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblApellidocliente" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="lblnom" runat="server" Text="Nombre"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblNombrePac" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="lbldni" runat="server" Text="DNI"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblDNImuestra" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="lblsex" runat="server" Text="Sexo"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblsexpaciente" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <div>
                    <h4>Observaciones</h4>
                </div>
                <div>
                    <asp:TextBox ID="txtobservaciones" CssClass="form-control" Rows="6" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <asp:Button ID="btnvolver" runat="server" OnClick="btnvolver_Click" Text="Volver" />
            </div>
            <div class="col">
                <asp:Button ID="btncancelarturno" runat="server" OnClick="btncancelarturno_Click" Text="Cancelar Turno" />
            </div>
            <div class="col">
                <asp:Button ID="btnguardar" OnClick="btnguardar_Click" runat="server" Text="Guardar" />
            </div>
        </div>
    </div>


</asp:Content>
