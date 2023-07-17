<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TurnosxPaciente.aspx.cs" Inherits="TP_Final_equipo2.TurnosxPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Como desea solicitar el turno?</h1>
    <div>
        <asp:Button ID="btnMenuTurnos" runat="server" OnClick="btnMenuTurnos_Click" Text="Buscar mi turno" />
    </div>
    <div>
        <asp:Button ID="btnSolicitud" runat="server" OnClick="btnSolicitud_Click" Text="Que me asignen un turno" />
    </div>
    <div>
        <asp:Label ID="lblDescripcion" runat="server" Visible="false" Text="Ingrese el area y el motivo por el cual necesita un turno y sera respondido a su email a la brevedad:"></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="tbxDescripccion" runat="server" Visible="false"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar Solicitud" OnClick="btnEnviar_Click" Visible="false" />
    </div>
</asp:Content>
