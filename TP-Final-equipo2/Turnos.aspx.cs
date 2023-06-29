using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class Turnos : System.Web.UI.Page
    {
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

            EspecialidadNegocio especialidadesNegocio = new EspecialidadNegocio();
            PacientesNegocio pacientesNegocio = new PacientesNegocio();
            try
            {
                if(!IsPostBack)
                {
                    ddlEspecialidades.DataSource = especialidadesNegocio.ListarEspecialidades();
                    ddlEspecialidades.DataTextField = "Nombre";
                    ddlEspecialidades.DataValueField = "ID";
                    ddlEspecialidades.DataBind();
                    ddlPacientes.DataSource  = pacientesNegocio.ListarPacientes();
                    ddlPacientes.DataTextField = "Nombre";
                    ddlPacientes.DataValueField = "ID";
                    ddlPacientes.DataBind();
                    
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
            }


        }

        protected void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio especialidadesNegocio = new EspecialidadNegocio();
            try
            {
                ddlMedicos.DataSource = especialidadesNegocio.ListarMedicos(int.Parse(ddlEspecialidades.SelectedValue));
                ddlMedicos.DataTextField = "NombreMedico";
                ddlMedicos.DataValueField = "IDMedico";
                ddlMedicos.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
            }
        }
    }
}