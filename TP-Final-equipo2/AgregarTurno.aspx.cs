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
                    lblResultado.Text = "Cliente no encontrado";
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
    }
}