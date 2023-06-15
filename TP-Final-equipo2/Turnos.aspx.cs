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
        protected void Page_Load(object sender, EventArgs e)
        {
            EspecialidadesNegocio especialidadesNegocio = new EspecialidadesNegocio();
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
    }
}