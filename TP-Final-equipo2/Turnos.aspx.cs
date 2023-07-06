using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace TP_Final_equipo2
{
    public partial class Turnos : System.Web.UI.Page
    {
        public int IdPaciente { get; set; }
        public int IDmedico { get; set; }
        public int IDespecialidad { get; set; }

        //private void EnviarMensajeError(string login, string mensajeError)
        //{
        //    Session["MensajeError"] = mensajeError;
        //    Response.Redirect(login);
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["usuario"] == null)
            //{
            //    string MensajeError = "Debe iniciar sesion para acceder a la pagina";
            //    EnviarMensajeError("Login.aspx", MensajeError);
            //}
            if (!IsPostBack)
            {
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                ddlEspecialidad.DataSource = negocio.ListarEspecialidades();
                ddlEspecialidad.DataValueField = "ID";
                ddlEspecialidad.DataTextField = "Nombre";
                ddlEspecialidad.DataBind();
            }
        }

        protected void btnbuscardni_Click(object sender, EventArgs e)
        {
            PacientesNegocio negocio = new PacientesNegocio();
            int dni = int.Parse(txtDNIpaciente.Text);
            IdPaciente = negocio.BuscarID(dni);
            if( IdPaciente < 0)
            {
                lblincorrecto.Text = "Cliente no encontrado";
                lblincorrecto.Visible = true;
            }
        }

        protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDespecialidad = int.Parse(ddlEspecialidad.SelectedValue);
            EspecialidadNegocio negocio = new EspecialidadNegocio();
            ddldoctores.DataSource = negocio.ListaFiltradaEspecialidades(IDespecialidad);
            ddldoctores.DataValueField = "ID";
            ddldoctores.DataTextField = "Apellido";
            ddldoctores.DataBind();
        }

        protected void ddldoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            HorarioNegocio negocio = new HorarioNegocio();
            IDmedico = int.Parse(ddldoctores.SelectedValue);
            dgvHorarios.DataSource = negocio.listaparaturno(IDmedico);
            dgvHorarios.DataBind();
        }
    }
}