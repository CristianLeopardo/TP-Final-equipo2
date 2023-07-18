<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TurnosxPaciente.aspx.cs" Inherits="TP_Final_equipo2.TurnosxPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">
            <h1 class="text-center">Solicitud de turno</h1>
            <hr />
            <h4 class="text-center">¿Como desea solicitar el turno?</h4>
            <div class="row align-items-center">
                <div class="col-2"></div>
                <div class="col-2"></div>
                <div class="col-2">
                    <asp:Button ID="btnMenuTurnos" runat="server" OnClick="btnMenuTurnos_Click" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Buscar mi turno" />
                </div>
                <div class="col-3">
                    <asp:Button ID="btnSolicitud"  OnClick="btnSolicitud_Click" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" Text="Que me asignen un turno" runat="server" />
                </div>
            </div>
            <br />
            <div class="container text-center">
                <div class="row align-items-center">
                    <div class="col">
                        <div class="mb-3">
                            <asp:Label ID="lblDescripcion" runat="server" Visible="false" CssClass="offset-2 form-label alert-link accordion-button" Text="↓ Ingrese el area y el motivo por el cual necesita un turno y sera respondido a su email a la brevedad ↓"></asp:Label>
                        </div>
                        <div>
                            <asp:TextBox ID="tbxDescripccion" CssClass="offset-3 form-control bg-light w-50" runat="server" Visible="false"></asp:TextBox>
                        </div>
                        <br />
                        <div>
                            <asp:Button ID="btnEnviar" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" runat="server" Text="Enviar Solicitud" OnClick="btnEnviar_Click" Visible="false" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
