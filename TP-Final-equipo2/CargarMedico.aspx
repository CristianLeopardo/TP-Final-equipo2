<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargarMedico.aspx.cs" Inherits="TP_Final_equipo2.CargarMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <h2>Carga de Medico...</h2>
    </div>

    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblApellido" CssClass="form-label alert-link accordion-button" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="tbxApellido" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblNombre" CssClass="form-label alert-link accordion-button" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="tbxNombre" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblDni" CssClass="form-label alert-link accordion-button" runat="server" Text="DNI"></asp:Label>
                    <asp:TextBox ID="tbxDni" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col-5">
                <div class="mb-3">
                    <asp:Label ID="lblSexo" CssClass="form-label alert-link accordion-button" runat="server" Text="Sexo"></asp:Label>
                    <asp:DropDownList ID="ddlSexo" CssClass="list-group-item-action bg-dark-subtle " runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblTelefono" CssClass="form-label alert-link accordion-button" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="tbxTelefono" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblCelular" CssClass="form-label alert-link accordion-button" runat="server" Text="Celular"></asp:Label>
                    <asp:TextBox ID="tbxCelular" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="tbxEmail" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="mb-3">
            <asp:Label ID="lblFechaNacimiento" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de nacimiento"></asp:Label>
            <asp:Calendar ID="calFechaNacimiento" runat="server"></asp:Calendar>
            <asp:Label ID="lvlFechaIngreso" CssClass="form-label alert-link accordion-button" runat="server" Text="Fecha de ingreso"></asp:Label>
            <asp:Calendar ID="calFechaIngreso" runat="server"></asp:Calendar>
        </div>
    </div>

    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <div>
                        <asp:Button ID="btcontinuar" runat="server" CssClass="btn btn-primary" Text="Continuar" OnClick="btcontinuar_Click" />
                    </div>
                    <div>
                        <asp:Label ID="lblmensaje" runat="server" Text="" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%if (lblmensaje.Visible == true)
        {%>
    <div class="container text-center">
        <div>
            <label for="exampleInputPassword1" class="form-label">Especialidades</label>
        </div>
        <div class="table">
            <asp:GridView ID="gvsespcialidades" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" OnSelectedIndexChanged="gvsespcialidades_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Especialidad" DataField="Nombre" />
                    <asp:CommandField ShowSelectButton="true" SelectText="✅" HeaderText="Cargar" />
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
                        <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-primary" OnClick="btnVolver_Click" Text="Volver"/>
                        <asp:Button ID="btnaceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" OnClick="btnaceptar_Click" visible="false"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
