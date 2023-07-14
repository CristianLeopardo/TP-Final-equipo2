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
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                TurnoNegocio turnoNegocio = new TurnoNegocio();
                Session.Add("ListaTurnos", turnoNegocio.ListarTurnos());
                dgvTurnos.DataSource = Session["ListaTurnos"];
                dgvTurnos.DataBind();           
        }


        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarTurno.aspx", false);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Turno> turnos = (List<Turno>)Session["ListaTurnos"];
            List<Turno> turnosfiltrada = turnos.FindAll(x => x.NombreMedico.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.NombrePaciente.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            dgvTurnos.DataSource = turnosfiltrada;
            dgvTurnos.DataBind();
        }
    }
}