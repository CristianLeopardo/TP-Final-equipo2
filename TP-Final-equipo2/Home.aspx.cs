using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class Home : System.Web.UI.Page
    {

        //private void EnviarMensajeError(string login, string mensajeError)
        //{
        //    Session["MensajeError"] = mensajeError;
        //    Response.Redirect(login);
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debe iniciar sesion para acceder a la pagina"); 
                Response.Redirect("Error.aspx", false);
            }
              
                
                if (Session["msj"] != null)
            {
                msj.Visible = true;
                msj.Text = Session["msj"].ToString();

            }
        }

        protected void btnnewPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPacientes.aspx",false);
        }

        protected void btnnewMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuMedicos.aspx", false);
        }

        protected void btnnewTurno_Click(object sender, EventArgs e)
        {
            Response.Redirect("Turnos.aspx", false);
        }


        protected void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuEspecialidades.aspx", false);
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsignacionEspecialidades.aspx", false);
        }

        protected void btnJornada_Click(object sender, EventArgs e)
        {
            Response.Redirect("Jornada.aspx", false);
        }

        protected void btnTurnosxmedicos_Click(object sender, EventArgs e)
        {
            Response.Redirect("TurnosxMedicos.aspx",false);
        }

        protected void btnTurnoPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("TurnosxPaciente.aspx", false);
        }
    }
}