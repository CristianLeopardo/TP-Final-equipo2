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
                    <asp:TextBox ID="txtfecha" runat="server">11/02/2023</asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Especialidad"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TextBox2" runat="server">Clinico</asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Doctor"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="TextBox3" runat="server">Hernan Froiman</asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-center">
            <div class="col">
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Apellido"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label8" runat="server" Text="Labela"></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label9" runat="server" Text="Labeln"></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="Label6" runat="server" Text="DNI"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label10" runat="server" Text="Labeldni"></asp:Label>
                </div>
            </div>
            <div class="col">
                <div>
                    <asp:Label ID="Label7" runat="server" Text="Sexo"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label11" runat="server" Text="Labels"></asp:Label>
                </div>
            </div>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div>
                    <h4>Observaciones</h4>
                </div>
                <div>
                    <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server" Rows="6"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <asp:Button ID="Button1" runat="server" Text="Volver" />
            </div>
            <div class="col">
                <asp:Button ID="Button2" runat="server" Text="Cancelar Turno" />
            </div>
            <div class="col">
                <asp:Button ID="Button3" runat="server" Text="Guardar" />
            </div>
        </div>
    </div>
</asp:Content>
