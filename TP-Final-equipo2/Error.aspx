<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TP_Final_equipo2.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-80" style="margin: 20px">
        <div class="bg-white p-3 rounded-5 text-secondary shadow w-75">
            <div class="container text-center">
                <h1 class="text-danger"><i class="bi bi-exclamation-octagon"></i> Hubo un problema <i class="bi bi-exclamation-octagon"></i></h1>
                <div>
                    <hr />
                </div>
                <i class="bi bi-arrow-right"></i> <asp:Label ID="lblMensaje" CssClass="m-2" Font-Size="X-Large" runat="server" Text=""></asp:Label> <i class="bi bi-arrow-left"></i>
            </div>
        </div>
    </div>
</asp:Content>
