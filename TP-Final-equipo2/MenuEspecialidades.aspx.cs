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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                EspecialidadNegocio especialidadesNegocio = new EspecialidadNegocio();
                dgvEspecialidades.DataSource = especialidadesNegocio.ListarEspecialidades();
                dgvEspecialidades.DataBind();
            }           
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio nuevo = new EspecialidadNegocio();
            try
            {
                nuevo.AgregarEspecialidad(tbxEspecialidad.Text);
                lblMensaje.Visible = true;
                lblMensaje.Text = "Especialidad cargada exitosamente...";
                //Response.Redirect("Home.aspx", false);
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
            lblMensaje.Text = "Especialidad eliminada correctamente";
            lblMensaje.Visible = true;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}