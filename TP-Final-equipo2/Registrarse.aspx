<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="TP_Final_equipo2.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">


        <div class="bg-white p-3 rounded-5 text-secondary shadow w-100">
            <hr />
            <div class="d-flex justify-content-center mb-3" style="margin: 2px">
                <img src="Imagenes/login-icon.svg" alt="login-icon" style="height: 4rem" />
                <div class="text-center fs-1 fw-bold">Registrate</div>
                <img src="Imagenes/login-icon.svg" alt="login-icon" style="height: 4rem" />
            </div>
            <hr />
            <div class="text-center">
                <asp:ValidationSummary runat="server" DisplayMode="BulletList" CssClass="text-danger fs-2 text-decoration-underline" HeaderText="Complete los campos obligatorios *" ValidationGroup="GrupoRegistro" />
            </div>

            <div class="row align-items-start">
                <div class="col-4 mb-3">
                    <asp:Label ID="lblUsuario" CssClass="form-label alert-link accordion-button" runat="server">Ingrese el Usuario: <span style="color: red;">*</span></asp:Label>
                    <asp:TextBox ID="tbxUsuario" CssClass="form-control bg-light" placeholder="Usuario" runat="server" />
                    <asp:RequiredFieldValidator ID="rfvUsuario" ControlToValidate="tbxUsuario" ValidationGroup="GrupoRegistro" runat="server"></asp:RequiredFieldValidator>
                </div>
                <div class="col-4 mb-3">
                    <asp:Label ID="lblClave" CssClass="form-label alert-link accordion-button" runat="server">Contraseña:<span style="color: red;">*</span></asp:Label>
                    <asp:TextBox ID="tbxClave" placeholder="Contraseña" TextMode="Password" CssClass="form-control bg-light" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvClave" ControlToValidate="tbxClave" ValidationGroup="GrupoRegistro" runat="server"></asp:RequiredFieldValidator>
                </div>
                <div class="col-4 mb-3">
                    <asp:Label ID="lblClave2" CssClass="form-label alert-link accordion-button" runat="server">Repita la contraseña:<span style="color: red;">*</span></asp:Label>
                    <asp:TextBox ID="tbxClave2" placeholder="Contraseña" CssClass="form-control bg-light" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvClave2" ControlToValidate="tbxClave2" ValidationGroup="GrupoRegistro" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row align-items-start">
                <div class="col-4 mb-3">
                    <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server">Ingrese el Email:<span style="color: red;">*</span></asp:Label>
                    <asp:TextBox ID="tbxEmail" CssClass="form-control bg-light" placeholder="Email" TextMode="Email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="tbxEmail" ValidationGroup="GrupoRegistro" runat="server"></asp:RequiredFieldValidator>
                </div>
                <div class="col-4 mb-3">
                    <asp:Label ID="lblEmail2" CssClass="form-label alert-link accordion-button" runat="server">Repita el Email: <span style="color: red;">*</span></asp:Label>
                    <asp:TextBox ID="tbxEmail2" CssClass="form-control bg-light" placeholder="Email" TextMode="Email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail2" ControlToValidate="tbxEmail2" ValidationGroup="GrupoRegistro" runat="server"></asp:RequiredFieldValidator>
                </div>
                <div class="col-4 mb-3">
                    <asp:Label ID="lblDNI" CssClass="form-label alert-link accordion-button" runat="server">Ingrese el DNI:<span style="color: red;">*</span></asp:Label>
                    <asp:TextBox ID="tbxDNI" CssClass="form-control bg-light" placeholder="DNI" TextMode="Number" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDNI" ControlToValidate="tbxDNI" ValidationGroup="GrupoRegistro" runat="server"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row align-items-start">
                <div class="col-4 mb-3" style="margin-top: 35px">
                    <hr />
                </div>
                <div class="col-4 mb-3" style="right: 40px">
                    <asp:Label ID="lblTipoUsuario" CssClass="form-label alert-link accordion-button" Text="Tipo de usuario:" runat="server"></asp:Label>
                    <asp:DropDownList ID="ddlTipoUsuario" CssClass="form-control bg-light" runat="server"></asp:DropDownList>
                </div>
                <div class="col-4 mb-3" style="margin-top: 35px">
                    <hr />
                </div>
            </div>
            <br />
            <div class="container text-center">
                <asp:Label ID="lblOK" Visible="false" CssClass="form-label alert-link accordion-button" runat="server" Text="Usuario agregado correctamente"></asp:Label>
                <asp:Label ID="lblNOK" Visible="false" CssClass="form-label alert-link accordion-button" runat="server" Text="La contraseña o el email no coinciden"></asp:Label>
            </div>
            <div class="align-items-start text-center">
                <div class="mb-3">
                    <asp:Button ID="btnAceptar" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" runat="server" Text="Registrarse" OnClick="btnAceptar_Click" CausesValidation="true" ValidationGroup="GrupoRegistro" />
                    <asp:Button ID="btnVolver" CssClass="btn btn-info text-white w-20 fw-semibold shadow-sm" runat="server" Text="Cancelar" OnClick="btnVolver_Click" />
                </div>
            </div>
            <div class="d-flex gap-1 justify-content-center mt-1">
                <div>¿Ya tenes cuenta?</div>
                <a href="Login.aspx" class="text-decoration-none text-info fw-semibold">Inicia sesion</a>
            </div>
        </div>
    </div>



    <%--<h1>Registrarse</h1>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblUsuario" CssClass="form-label alert-link accordion-button" runat="server" Text="Ingrese el Usuario:"></asp:Label>
                    <asp:TextBox ID="tbxUsuario" placeholder="Usuario" CssClass="form-control" TextMode="SingleLine" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblClave" CssClass="form-label alert-link accordion-button" runat="server" Text="Ingrese la contraseña:"></asp:Label>
                    <asp:TextBox ID="tbxClave" placeholder="Contraseña" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblClave2" CssClass="form-label alert-link accordion-button" runat="server" Text="Repita la contraseña:"></asp:Label>
                    <asp:TextBox ID="tbxClave2" placeholder="Contraseña" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblEmail" CssClass="form-label alert-link accordion-button" runat="server" Text="Ingrese el Email:"></asp:Label>
                    <asp:TextBox ID="tbxEmail" CssClass="form-control" placeholder="Email" TextMode="Email" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblEmail2" CssClass="form-label alert-link accordion-button" runat="server" Text="Repita el Email:"></asp:Label>
                    <asp:TextBox ID="tbxEmail2" CssClass="form-control" placeholder="Email" TextMode="Email" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblDNI" CssClass="form-label alert-link accordion-button" runat="server" Text="Ingrese el DNI:"></asp:Label>
                    <asp:TextBox ID="tbxDNI" CssClass="form-control" placeholder="DNI" TextMode="Number" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Label ID="lblTipoUsuario" CssClass="form-label alert-link accordion-button" runat="server" Text="Seleccione el tipo de usuario:"></asp:Label>
                    <asp:DropDownList ID="ddlTipoUsuario" CssClass="btn btn-secondary dropdown-toggle" runat="server"></asp:DropDownList>
                </div>
            </div>    
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <asp:Button ID="btnAceptar" CssClass="btn btn-primary"  runat="server" Text="Registrarse"  OnClick="btnAceptar_Click" />
                    <asp:Button ID="btnVolver" CssClass="btn btn-primary" runat="server" Text="Cancelar"  OnClick="btnVolver_Click" />
                </div>
            </div>    
        </div>
    </div>
    <asp:Label ID="lblOK" Visible="false" CssClass="form-label alert-link accordion-button" runat="server" Text="Usuario agregado correctamente"></asp:Label>
    <asp:Label ID="lblNOK" Visible="false" CssClass="form-label alert-link accordion-button" runat="server" Text="La contraseña o el email no coinciden"></asp:Label>--%>
</asp:Content>
