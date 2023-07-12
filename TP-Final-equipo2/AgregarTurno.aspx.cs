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
                Session.Add("IDPaciente", 0 );
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Turnos.aspx", false);
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
            if ((int)Session["IDPaciente"] == 0)
            {
                lblResultado.Text = "Primero seleccione un paciente";
            }
            else
            {
                ddlJornada.Visible = true;   
            }
            
        }

        protected void ddlJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
            ddlMedicos.DataSource = especialidadNegocio.ListarMedicosTurno(int.Parse(ddlEspecialidades.SelectedValue), ddlJornada.SelectedValue);
            ddlMedicos.DataValueField = "IDMedico";
            ddlMedicos.DataTextField = "NombreMedico";
            ddlMedicos.DataBind();
            ddlMedicos.Visible = true;
        }
        protected void ddlMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            calDia.Visible = true;
        }

        protected void calDia_SelectionChanged(object sender, EventArgs e)
        {
            int horaInicial;
            ddlHorarios.Visible = true;
            string fecha = calDia.SelectedDate.ToString("yyyy-MM-dd");
            List<Hora> lista = new List<Hora>();
            Hora hora = new Hora();
            TurnoNegocio turnoNeg = new TurnoNegocio();
            List<Turno> turnos = new List<Turno>();
            if (ddlMedicos.SelectedValue != ""  && ddlEspecialidades.SelectedValue !="")
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
                    horaInicial = 24;
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
            }
            else
            {
                // MENSAJE DE ERROR POR NO  SELECCIONAR  ESPECIALDIADS NI MEDICOS
            }
        }

        protected void ddlMedicos_Load(object sender, EventArgs e)
        {
            calDia.Visible = true;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string asd;
            Turno turno = new Turno();
            turno.IDPaciente = (int)Session["IDPaciente"];
            if (ddlMedicos.SelectedValue != "")
            {
                turno.IDMedico = int.Parse(ddlMedicos.SelectedValue);
                turno.Estado = 1;
                //lblLeyenda.Text = calDia.SelectedDate.ToString("yyyy-MM-dd") + " " + ddlHorarios.SelectedValue.ToString() + ":00";
                asd = calDia.SelectedDate.ToString("yyyy-MM-dd") + " " + ddlHorarios.SelectedValue.ToString() + ":00";
                turno.Fecha = DateTime.Parse(asd);
                turno.IDEspecialidad = int.Parse(ddlEspecialidades.SelectedValue);
                TurnoNegocio turnoNegocio = new TurnoNegocio();
                turnoNegocio.AgregarTurno(turno);
            }
            else 
            {
                //MENSAJE DE ERROR POR NO SELECCIONAR FECHA NI HORARIO
            }

            
        }
    }
}