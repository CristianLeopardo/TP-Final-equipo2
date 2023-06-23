<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TP_Final_equipo2.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            background-color: #f2f2f2;
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 400px;
            margin: 0 auto;
            padding: 20px;
        }

        .welcome {
            text-align: center;
            font-size: 42px;
            color: #333;
        }

        .button-container {
            display: grid;
            grid-template-columns: repeat(1, 2fr);
            grid-gap: 10px;
            margin-top: 20px;
        }

            .button-container .btn {
                width: 100%;
                padding: 12px;
                font-size: 18px;
                background-color: #333;
                color: #fff;
                border: none;
                cursor: pointer;
                transition: background-color 0.3s ease;
            }

                .button-container .btn:hover {
                    background-color: #555;
                }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="welcome">Bienvenido al HOME...</h1>
        <asp:Label ID="msj" runat="server" Text="" Visible="false"></asp:Label>
        <div class="button-container">
            <asp:Button runat="server" CssClass="btn" ID="btnnewPaciente" OnClick="btnnewPaciente_Click" Text="Cargar nuevo paciente" />
            <asp:Button runat="server" CssClass="btn" ID="btnModificarPaciente" OnClick="btnModificarPaciente_Click" Text="Modificar Pacientes" />
            <asp:Button runat="server" CssClass="btn" ID="btnnewMedico" OnClick="btnnewMedico_Click" Text="Cargar nuevo medico" />
            <asp:Button runat="server" CssClass="btn" ID="btnModificarMedico" OnClick="btnModificarMedico_Click" Text="Modificar Medicos" />
            <asp:Button runat="server" CssClass="btn" ID="btnEspecialidades" OnClick="btnEspecialidades_Click" Text="Modificar Especialidades" />
            <hr />
            <asp:Button runat="server" CssClass="btn" ID="btnJornada" Text="Cargar jornada" />
            <asp:Button runat="server" CssClass="btn" ID="btnTurno" OnClick="btnnewTurno_Click" Text="Cargar Turno" />
        </div>
    </div>
</asp:Content>






