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
    public partial class MenuEspecialidades : System.Web.UI.Page
    {
        protected void CargarEspecialidades()
        {
            EspecialidadNegocio especialidadesNegocio = new EspecialidadNegocio();
            dgvEspecialidades.DataSource = especialidadesNegocio.ListarEspecialidades();
            dgvEspecialidades.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debe iniciar sesion para acceder a la pagina");
                Response.Redirect("Error.aspx", false);
            }
            if (!(Session["usuario"] != null && ((Dominio.Usuario)Session["usuario"]).TipoUsuario == Dominio.TipoUsuario.Admin))
            {
                Session.Add("error", "Debe ser un Administrador para ingresar a esta página");
                Response.Redirect("Error.aspx", false);
            }
            if (!IsPostBack)
            {
                CargarEspecialidades();
            }           
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio nuevo = new EspecialidadNegocio();
            try
            {
                nuevo.AgregarEspecialidad(tbxEspecialidad.Text);
                Session["AlertaMensaje"] = "Especialidad cargada";
                CargarEspecialidades();
                tbxEspecialidad.Text = "";
            }
            catch (Exception ex) 
            {
                throw ex;
            }           
        }


        protected void dgvEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEspecialidades.SelectedDataKey.Value.ToString());
            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
            especialidadNegocio.EliminarEspecialidad(id);
            Session["AlertaMensaje"] = "Especialidad eliminada";
            CargarEspecialidades();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}