<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CargaPaciente.aspx.cs" Inherits="TP_Final_equipo2.CargaPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Sexo</label>
                    <asp:DropDownList ID="ddlGenero" CssClass="list-group-item-action bg-dark-subtle " runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Partido</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Barrio</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder=".......">
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label alert-link accordion-button">Fechancimiento</label>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </div>
            </div>
        </div>
    </div>
    <div class="container text-center">
        <div class="row align-items-start">
            <div class="col">
                <div class="mb-3">
                    <div>
                        <asp:Button ID="Button1" runat="server" CssClass="btn-toolbar" Text="Volver" />
                    </div>
                    <div>
                        <asp:Button ID="Button2" runat="server" CssClass="btn-toolbar" Text="Aceptar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
