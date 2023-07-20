using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class MisTurnos : System.Web.UI.Page
    {
        protected void CargarTurnos()
        {
            PacientesNegocio pacientesNegocio = new PacientesNegocio();
            UsuarioNegocio us = new UsuarioNegocio();
            Paciente este = pacientesNegocio.BuscarIDxEmail(us.BuscarEmail(((Dominio.Usuario)Session["usuario"]).User));
            EspecialidadNegocio negocio = new EspecialidadNegocio();
            TurnoNegocio turnoNegocio = new TurnoNegocio();
            Session.Add("ListaTurnos", turnoNegocio.ListarTurnos(este.ID));
            dgvTurnos.DataSource = Session["ListaTurnos"];
            dgvTurnos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debe iniciar sesion para acceder a la pagina");
                Response.Redirect("Error.aspx", false);
            }
            if (!(Session["usuario"] != null && (((Dominio.Usuario)Session["usuario"]).TipoUsuario == Dominio.TipoUsuario.Paciente)))
            {
                Session.Add("error", "No tiene permisos para ingresar a esta pagina");
                Response.Redirect("Error.aspx", false);
            }
            if (!IsPostBack)
            {
                PacientesNegocio pacientesNegocio = new PacientesNegocio();
                UsuarioNegocio us = new UsuarioNegocio();
                Paciente este = pacientesNegocio.BuscarIDxEmail(us.BuscarEmail(((Dominio.Usuario)Session["usuario"]).User));
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                TurnoNegocio turnoNegocio = new TurnoNegocio();
                Session.Add("ListaTurnos", turnoNegocio.ListarTurnos(este.ID));
                dgvTurnos.DataSource = Session["ListaTurnos"];
                dgvTurnos.DataBind();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("TurnosxPaciente.aspx", false);
        }

        protected void dgvTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TurnoNegocio turnoNegocio = new TurnoNegocio();
            Turno seleccionado = turnoNegocio.BuscarTurno(int.Parse(dgvTurnos.SelectedDataKey.Value.ToString()));
            if (seleccionado.Estado == Dominio.estado.Activo)
            {
                // AGREGAR  CARTEL DE CONFIRMACION
                
                turnoNegocio.Modificarturno(int.Parse(dgvTurnos.SelectedDataKey.Value.ToString()), 3);
                Response.Redirect("TurnosxPaciente.aspx", false);
                Session["AlertaMensaje"] = "Turno";
                CargarTurnos();
            }
            else
            {
                //  MENSAJE  DE ERROR POR  NO PODER  REPROGRAMAR  UN TURNO CANCELADO, AUSENTE, ETC.
                Session["AlertaMensaje"] = "Error";
            }
        }

        protected void dgvTurnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "CancelarTurno")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int id = Convert.ToInt32(dgvTurnos.DataKeys[index].Value);
                TurnoNegocio turnoNegocio = new TurnoNegocio();
                Turno seleccionado = turnoNegocio.BuscarTurno(id);
                if (seleccionado.Estado == Dominio.estado.Activo)
                {
                    // AGREGAR  CARTEL DE CONFIRMACION
                    turnoNegocio.Modificarturno(id, 2);
                    Session["AlertaMensaje"] = "Turno";
                    CargarTurnos();
                }
                else
                {
                    //  MENSAJE  DE ERROR POR  NO PODER  CANCELAR  UN TURNO REPROGRAMADO, AUSENTE, ETC.
                    Session["AlertaMensaje"] = "Error";
                }
            }
        
        }
    }
}