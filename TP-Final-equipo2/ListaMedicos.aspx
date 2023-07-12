<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListaMedicos.aspx.cs" Inherits="TP_Final_equipo2.ListaMedicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Medicos..</h1>
    <div>
        <asp:Label ID="lblEspecialidades" runat="server" Text="Especialidades"></asp:Label>
        <asp:DropDownList ID="ddlEspecialidades" runat="server" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged"></asp:DropDownList>

        <asp:Label ID="lbldni" runat="server" Text="DNI"></asp:Label>
        <asp:TextBox ID="txtdni" runat="server"></asp:TextBox>

        <asp:Label ID="lblapellido" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>

        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
    </div>
    <asp:GridView ID="gvListaMedicos" cssclass="table  Home vstack text-opacity-75" AutoGenerateColumns="false" OnSelectedIndexChanged="gvListaMedicos_SelectedIndexChanged" DataKeyNames="ID" runat="server">
        <Columns>
            <asp:BoundField headertext="Apellido" DataField="Apellido"/>
            <asp:BoundField headertext="Nombre" DataField="Nombre"/>
            <asp:BoundField headertext="DNI" DataField="Dni"/>
            <asp:BoundField headertext="Telefono" DataField="Telefono"/>
            <asp:BoundField headertext="Celular" DataField="Celular"/>
            <asp:BoundField headertext="Email" DataField="Email"/>
            <asp:CommandField ShowSelectButton="true" SelectText="Especialidades.." HeaderText="Especialidades" />
            <asp:CommandField ShowSelectButton="true" SelectText="⭕" HeaderText="Modificar" />
            <asp:CommandField ShowSelectButton="true" SelectText="❌" HeaderText="Eliminar" />
        </Columns>
    </asp:GridView>
</asp:Content>
