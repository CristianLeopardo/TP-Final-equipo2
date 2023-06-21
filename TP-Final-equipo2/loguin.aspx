<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="loguin.aspx.cs" Inherits="TP_Final_equipo2.loguin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Este es el loguin</h1>
    <div class="loguin">
        <form>
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Usuario</label>
                <input type="text" class="form-control" id="tbxUsuario">
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Contraseña</label>
                <input type="password" class="form-control" id="tbxClave">
            </div>
            <div>
                <a href="RecuperarClave.aspx">Olvide mi contraseña</a>
            </div>
            <a href="Default.aspx"  class="btn btn-primary">Volver</a>
            <button type="submit" class="btn btn-primary" id="btnIngresar">Ingresar</button>            
        </form>
    </div>
</asp:Content>
