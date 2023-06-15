<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargaPaciente.aspx.cs" Inherits="TP_Final_equipo2.CargaPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Login">
        <form>
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Apellido</label>
                <input type="text" class="form-control" id="txtapellido">
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Nombre</label>
                <input type="password" class="form-control" id="txtnombre">
            </div>
            <div class="mb-3">
                <label class="form-label">FechaNac</label>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">dni</label>
                <input type="password" class="form-control" id="txtvv">
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Tel</label>
                <input type="password" class="form-control" id="tbxClave">
            </div>
            <button type="submit" class="btn btn-primary" id="btnIngresar">Ingresar</button>
        </form>
    </div>
</asp:Content>
