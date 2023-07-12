<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TurnosxMedicos.aspx.cs" Inherits="TP_Final_equipo2.TurnosxMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>turnos</h1>
    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <asp:Button ID="btnturnoshoy" runat="server" OnClick="btnturnoshoy_Click" Text="Turnos de Hoy" />
            </div>
            <div class="col">
                <asp:Label ID="lblCampo" runat="server" Text="Seleccionar campo de busqueda: "></asp:Label>
                <asp:DropDownList ID="ddlcampo" AutoPostBack="true" OnSelectedIndexChanged="ddlcampo_SelectedIndexChanged" runat="server"></asp:DropDownList>
            </div>
            <div class="col">
                <asp:Label ID="lblcriterio" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="txtcriterio" AutoPostBack="true" OnTextChanged="txtcriterio_TextChanged" runat="server" Text=""></asp:TextBox>
            </div>
            <div class="col">
                <asp:Button ID="btnBuscar" OnClick="btnBuscar_Click" runat="server" Text="Buscar" />
            </div>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <asp:GridView ID="dgvturnos" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvturnos_SelectedIndexChanged" DataKeyNames="ID" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="ID" Visible="false" />
                        <asp:BoundField HeaderText="Estado" DataField="Estado" />
                        <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                        <asp:BoundField HeaderText="Especialidad" DataField="NombreEspecialidad" />
                        <asp:CommandField ShowSelectButton="true" SelectText="0" HeaderText="Seleccionar turno" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <asp:Button ID="btnvolver" OnClick="btnvolver_Click" runat="server" Text="Volver" />
            </div>
        </div>
    </div>

</asp:Content>
