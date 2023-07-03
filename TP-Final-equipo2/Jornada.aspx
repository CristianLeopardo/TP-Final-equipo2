<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Jornada.aspx.cs" ClientIDMode="Static" Inherits="TP_Final_equipo2.Jornada" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <h1 style="text-align: center">CARGA DE HORARIO LABORAL</h1>
    </section>
    <div class="content">
        <div class="row">
            <div class="col-md-4">
                <div>
                    <h3>Datos del médico</h3>
                    <div>
                        <label>Nro. de Documento</label>
                        <div class="input-group">
                            <asp:TextBox ID="tbxDNI" CssClass="form-control" runat="server" />
                            <span class="input-group-btn">
                                <asp:Button ID="btnBuscar" OnClick="btnBuscar_Click" CssClass="btn btn-info" Text="Buscar" runat="server" />
                            </span>
                        </div>
                    </div>
                    <div>
                        <asp:Label ID="lblError" Text="" runat="server" Visible="false" />
                    </div>
                    <div>
                        <strong>Nombre: </strong>
                        <asp:Label ID="lblNombre" runat="server" Text="" />
                    </div>
                    <div>
                        <strong>Apellido: </strong>
                        <asp:Label ID="lblApellido" runat="server" Text="" />
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <div>
                    <h3>Horarios de Atención</h3>
                </div>
                <div style="text-align: center">
                    <button id="btnAgregar" type="button" class="btn btn-primary" data-bs-toggle="modal" text="Agregar Horario" data-bs-target="#AgregarHorario">
                        Agregar Horario
                    </button>
                    <div class="modal fade" id="AgregarHorario" data-bs-backdrop="static" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                        <div class="modal-dialog modal-open modal-dialog-centerl">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h3 class="modal-title"><i class="fade fa-clock-o"></i>Agregar Horario de Atencion</h3>
                                    <asp:Button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" runat="server" />
                                </div>
                                <div class="modal-body">
                                    <div class="input-group mb-3">
                                        <span class="input-group-text" id="basic-addon1">Fecha:</span>
                                        <asp:TextBox ID="tbxFecha" type="date" CssClass="form-control" aria-label="Fecha" aria-describedy="basic-addon1" runat="server" />
                                    </div>
                                    <div class="input-group">
                                        <span class="input-group-text" id="basic-addon2">Hora:</span>
                                        <asp:TextBox ID="tbxHora" type="time" CssClass="form-control" aria-label="Hora" aria-describedby="basic-addon2" runat="server" />
                                        <asp:Label ID="lblErrorHora" Text="" runat="server" Visible="false" />
                                    </div>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="btnAgregarHora" OnClick="btnAgregarHora_Click" type="button" class="btn btn-secondary" Text="Agregar" data-bs-dismiss="modal" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnGuardarHorario" Text="Guardar Horario" CssClass="btn btn-success" runat="server" />
                </div>
                <div>
                    <asp:GridView ID="dgvHorarios" AutoGenerateColumns="false" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="Fecha de atencion" DataField="Fecha" DataFormatString="{0:d}" />
                            <asp:BoundField HeaderText="Hora de atencion" DataField="Hora" DataFormatString="{0:t}" />
                            <asp:CommandField ShowSelectButton="true" SelectText="Editar" HeaderText="Edición"/>
                            <asp:CommandField ShowSelectButton="true" SelectText="Eliminar" HeaderText="Eliminación"/>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
