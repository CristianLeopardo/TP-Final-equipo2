<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargarMedico.aspx.cs" Inherits="TP_Final_equipo2.CargarMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cargar... </h2>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Apellido</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Nombre</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">DNI</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Telefono</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Celular</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Email</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div>
            <label for="exampleInputPassword1" class="form-label">Especialidades</label>
        </div>
        <div>
            <asp:DropDownList ID="ddlEspecialidades" CssClass="btn btn-secondary dropdown-toggle" runat="server"></asp:DropDownList>
        </div>
    </div>
</asp:Content>
