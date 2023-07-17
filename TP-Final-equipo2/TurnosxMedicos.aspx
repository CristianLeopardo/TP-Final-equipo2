<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TurnosxMedicos.aspx.cs" Inherits="TP_Final_equipo2.TurnosxMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-75">
            <h1 class="text-center">Turnos</h1>
            <hr />
            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col-3">
                        <asp:Button ID="btntodslosturnos" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btntodslosturnos_Click" Text="Turnos" />
                        <asp:Button ID="btnturnoshoy" runat="server" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" OnClick="btnturnoshoy_Click" Text="Turnos de Hoy" />
                    </div>
                    <div class="col-3">
                        <asp:Label ID="lblCampo" runat="server" CssClass="form-label alert-link" Text="Seleccionar campo de busqueda: "></asp:Label>
                        <asp:DropDownList ID="ddlcampo" AutoPostBack="true" CssClass="rounded-pill text-white text-bg-info text-center" OnSelectedIndexChanged="ddlcampo_SelectedIndexChanged" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col-3">
                        <asp:Label ID="lblcriterio" runat="server" Text=""></asp:Label>
                        <asp:TextBox ID="txtcriterio" AutoPostBack="true" OnTextChanged="txtcriterio_TextChanged" runat="server" Text=""></asp:TextBox>
                    </div>
                    <div class="col-3">
                        <asp:Button ID="btnBuscar" OnClick="btnBuscar_Click" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" runat="server" Text="Buscar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <asp:GridView ID="dgvturnos" AutoGenerateColumns="false" CssClass="container table table-info table-striped-columns text-center text-truncate" OnSelectedIndexChanged="dgvturnos_SelectedIndexChanged" DataKeyNames="ID" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="ID" Visible="false" />
                        <asp:BoundField HeaderText="Estado" DataField="Estado" />
                        <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                        <asp:BoundField HeaderText="Nombre del paciente" DataField="NombrePaciente" />
                        <asp:BoundField HeaderText="Especialidad" DataField="NombreEspecialidad" />
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Seleccionar turno" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <asp:Button ID="btnvolver" OnClick="btnvolver_Click" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" runat="server" Text="Volver" />
            </div>
        </div>
    </div>

</asp:Content>
