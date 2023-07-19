using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class AgregarTurno : System.Web.UI.Page
    {
        public int IDmedico { get; set; }
        public int IDespecialidad { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debe iniciar sesion para acceder a la pagina");
                Response.Redirect("Error.aspx", false);
            }
            if (!(Session["usuario"] != null && (((Dominio.Usuario)Session["usuario"]).TipoUsuario != Dominio.TipoUsuario.Medico )))
            {
                Session.Add("error", "No tiene permisos para ingresar a esta pagina");
                Response.Redirect("Error.aspx", false);
            }


            if (!IsPostBack)
            {
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                ddlEspecialidades.DataSource = negocio.ListarEspecialidades();
                ddlEspecialidades.DataValueField = "ID";
                ddlEspecialidades.DataTextField = "Nombre";
                ddlEspecialidades.DataBind();
                ddlJornada.Items.Add("Mañana");
                ddlJornada.Items.Add("Tarde");
                ddlJornada.Items.Add("Noche");
                if (Request.QueryString["ID"] != null)
                {
                    TurnoNegocio turnoNegocio = new TurnoNegocio();
                    Turno este = turnoNegocio.BuscarTurno(int.Parse(Request.QueryString["ID"]));                 
                    PacientesNegocio neg = new PacientesNegocio();
                    List<Paciente> pacientes = new List<Paciente>();
                    pacientes = neg.BuscarPaciente(este.IDPaciente);
                    Session.Add("IDPaciente", este.IDPaciente);
                    tbxDNI.Text = pacientes[0].Dni.ToString();
                    tbxDNI.ReadOnly = true;
                    lblResultado.Text = pacientes[0].Nombre + " " + pacientes[0].Apellido;
                    lblResultado.Visible = true;
                    btnAgregar.Visible = false;
                    ddlEspecialidades.SelectedValue = este.IDEspecialidad.ToString();
                    if (este.Fecha.Hour >= 8 && este.Fecha.Hour <= 16) ddlJornada.SelectedValue = ("Mañana");
                    if (este.Fecha.Hour >= 17 && este.Fecha.Hour <= 24) ddlJornada.SelectedValue = ("Tarde");
                    if (este.Fecha.Hour >= 1 && este.Fecha.Hour <= 7) ddlJornada.SelectedValue = ("Noche");
                    ddlMedicos.DataSource = negocio.ListarMedicosTurno(int.Parse(ddlEspecialidades.SelectedValue), ddlJornada.SelectedValue);
                    ddlMedicos.DataValueField = "IDMedico";
                    ddlMedicos.DataTextField = "NombreMedico";
                    ddlMedicos.DataBind();
                    ddlMedicos.SelectedValue = este.IDMedico.ToString();
                    ddlEspecialidades.Visible = true;
                    ddlJornada.Visible = true;
                    ddlMedicos.Visible = true;
                    tbxFecha.Text = este.Fecha.ToString("yyyy-MM-dd");
                    btnNovino.Visible = true;
                    btnReprogramar.Visible = true;
                    btnCancelar.Visible = true;
                } 
                else if (Request.QueryString["IDPaciente"] != null)
                {
                    PacientesNegocio neg = new PacientesNegocio();
                    List<Paciente> pacientes = new List<Paciente>();
                    Session.Add("IDPaciente", int.Parse(Request.QueryString["IDPaciente"]));
                    pacientes = neg.BuscarPaciente(int.Parse(Request.QueryString["IDPaciente"]));
                    tbxDNI.Text = pacientes[0].Dni.ToString();
                    tbxDNI.ReadOnly = true;
                    lblResultado.Text = pacientes[0].Nombre + " " + pacientes[0].Apellido;
                    lblResultado.Visible = true;
                }
                else
                {
                    Session.Add("IDPaciente", -1);
                }
                
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            PacientesNegocio negocio = new PacientesNegocio();
            Paciente paciente = new Paciente();
            if(tbxDNI.Text == "")
            {
                lblResultado.Text = "Ingrese un DNI para buscar";
                lblResultado.Visible = true;
            }
            else
            {
                paciente = negocio.BuscarPacientexDNI2(int.Parse(tbxDNI.Text));
                if (paciente.Nombre == null)
                {
                    lblResultado.Text = "Paciente no encontrado";
                    lblResultado.Visible = true;
                }
                else
                {
                    lblResultado.Text = paciente.Nombre.ToString() + " " + paciente.Apellido.ToString();
                    lblResultado.Visible = true;
                    Session.Add("IDPaciente", paciente.ID);
                }
            }            
        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)Session["IDPaciente"] == -1)
            {
                lblResultado.Text = "Primero seleccione un paciente";
            }
            else
            {
                ddlJornada.Visible = true;
                lblJornada.Visible = true;
            }
            
        }

        protected void ddlJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
            ddlMedicos.DataSource = especialidadNegocio.ListarMedicosTurno(int.Parse(ddlEspecialidades.SelectedValue), ddlJornada.SelectedValue);
            ddlMedicos.DataValueField = "IDMedico";
            ddlMedicos.DataTextField = "NombreMedico";
            ddlMedicos.DataBind();
            lblMedicos.Visible = true;
            ddlMedicos.Visible = true;
        }
        protected void ddlMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void calDia_SelectionChanged(object sender, EventArgs e)
        {
            int horaInicial;
            lblHorarios.Visible = true;
            ddlHorarios.Visible = true;
            string fecha = tbxFecha.Text.ToString();
            List<Hora> lista = new List<Hora>();
            Hora hora = new Hora();
            TurnoNegocio turnoNeg = new TurnoNegocio();
            List<Turno> turnos = new List<Turno>();
            if (ddlMedicos.SelectedValue != ""  && ddlEspecialidades.SelectedValue != "")
            {
                turnos = turnoNeg.BuscarHorario(int.Parse(ddlMedicos.SelectedValue), int.Parse(ddlEspecialidades.SelectedValue), (int)Session["IDPaciente"], fecha);
                if (ddlJornada.SelectedValue == "Mañana")
                {
                    horaInicial = 8;
                }
                else if (ddlJornada.SelectedValue == "Tarde")
                {
                    horaInicial = 17;
                }
                else
                {
                    horaInicial = 1;
                }
                bool encontre = false;
                for (int i = 0; i <= 8; i++)
                {
                    foreach (var v in turnos)
                    {
                        if (int.Parse(v.Fecha.ToString("HH")) == horaInicial)
                        {
                            encontre = true;
                        }
                    }
                    if (encontre == false)
                    {
                        Hora hora2 = new Hora();
                        hora2.Horario = horaInicial.ToString() + ":00";
                        lista.Add(hora2);
                    }
                    horaInicial++;
                    encontre = false;
                }
                ddlHorarios.DataSource = lista;
                ddlHorarios.DataTextField = "Horario";
                ddlHorarios.DataBind();
                lblBuscar.Visible = false;
            }
            else
            {
                // MENSAJE DE ERROR POR NO  SELECCIONAR  ESPECIALDIADS NI MEDICOS
                lblBuscar.Visible = true;
                lblHorarios.Visible = false;
                ddlHorarios.Visible = false;
            }
        }

        protected void ddlMedicos_Load(object sender, EventArgs e)
        {
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();   
        }

        protected void Agregar()
        {
            string asd = "";
            Turno turno = new Turno();
            turno.IDPaciente = (int)Session["IDPaciente"];
            if (ddlMedicos.SelectedValue != "")
            {
                turno.IDMedico = int.Parse(ddlMedicos.SelectedValue);
                turno.Estado = estado.Activo;
                asd = tbxFecha.Text.ToString() + " " + ddlHorarios.SelectedValue.ToString() + ":00";
                if (ddlHorarios.SelectedValue.ToString() == "" )
                {
                    Session["AlertaMensaje"] = "Seleccione un horario";  // NO SE MUESTRA
                }
                else
                {
                    turno.Fecha = DateTime.Parse(asd);
                    turno.IDEspecialidad = int.Parse(ddlEspecialidades.SelectedValue);
                    TurnoNegocio turnoNegocio = new TurnoNegocio();
                    turnoNegocio.AgregarTurno(turno);
                    lblNoMedico.Visible = false;
                    Session["AlertaMensaje"] = "Turno asignado";
                }
               
            }
            else
            {
                //MENSAJE DE ERROR POR NO SELECCIONAR medico
                lblNoMedico.Visible = true;
            }
        }

        protected void btnBuscar2_Click(object sender, EventArgs e)
        {
            int horaInicial;
            lblHorarios.Visible = true;
            ddlHorarios.Visible = true;
            if (tbxFecha.Text != "")
            {
                string fecha = tbxFecha.Text.ToString();
                List<Hora> lista = new List<Hora>();
                Hora hora = new Hora();
                TurnoNegocio turnoNeg = new TurnoNegocio();
                List<Turno> turnos = new List<Turno>();
                if (ddlMedicos.SelectedValue != "" && ddlEspecialidades.SelectedValue != "")
                {
                    turnos = turnoNeg.BuscarHorario(int.Parse(ddlMedicos.SelectedValue), int.Parse(ddlEspecialidades.SelectedValue), (int)Session["IDPaciente"], fecha);
                    if (ddlJornada.SelectedValue == "Mañana")
                    {
                        horaInicial = 8;
                    }
                    else if (ddlJornada.SelectedValue == "Tarde")
                    {
                        horaInicial = 16;
                    }
                    else
                    {
                        horaInicial = 0;
                    }
                    bool encontre = false;
                    for (int i = 0; i <= 8; i++)
                    {
                        foreach (var v in turnos)
                        {
                            if (int.Parse(v.Fecha.ToString("HH")) == horaInicial)
                            {
                                encontre = true;
                            }
                        }
                        if (encontre == false)
                        {
                            Hora hora2 = new Hora();
                            hora2.Horario = horaInicial.ToString() + ":00";
                            lista.Add(hora2);
                        }
                        horaInicial++;
                        encontre = false;
                    }
                    ddlHorarios.DataSource = lista;
                    ddlHorarios.DataTextField = "Horario";
                    ddlHorarios.DataBind();
                    lblBuscar.Visible = false;
                    lblFecha.Visible = false;
                }
                else
                {
                    // MENSAJE DE ERROR POR NO  SELECCIONAR  ESPECIALDIADS NI MEDICOS
                    lblBuscar.Visible = true;
                    lblHorarios.Visible = false;
                    ddlHorarios.Visible = false;
                }
            }
            else
            {
                // MENSAJE  DE  ERROR  POR  NO  SELECCIONAR FECHA
                lblFecha.Visible = true;
                lblHorarios.Visible = false;
                ddlHorarios.Visible = false;
            }
            
            
        }

        protected void btnReprogramar_Click(object sender, EventArgs e)
        {
            TurnoNegocio turnoNeg = new TurnoNegocio();
            turnoNeg.Modificarturno(int.Parse(Request.QueryString["ID"]), 3);
            Agregar();
            Session["AlertaMensaje"] = "Turno reprogramado";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            TurnoNegocio turnoNeg = new TurnoNegocio();
            turnoNeg.Modificarturno(int.Parse(Request.QueryString["ID"]), 2);
            Session["AlertaMensaje"] = "Turno cancelado";
        }

        protected void btnNovino_Click(object sender, EventArgs e)
        {
            TurnoNegocio turnoNeg = new TurnoNegocio();
            turnoNeg.Modificarturno(int.Parse(Request.QueryString["ID"]), 4);
        }
    }
    }
