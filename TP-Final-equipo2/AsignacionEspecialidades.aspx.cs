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
    public partial class AsignacionEspecialidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {          
            if (!IsPostBack)
            {
                EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
                dgvEspecialidadesMedico.DataSource = especialidadNegocio.ListarEspecialidadesMedico(int.Parse(Request.QueryString["ID"]));
                dgvEspecialidadesMedico.DataBind();
                ddlEspecialidades.DataSource = especialidadNegocio.ListarEspecialidades();
                ddlEspecialidades.DataTextField = "Nombre";
                ddlEspecialidades.DataValueField = "ID";
                ddlEspecialidades.DataBind();
                List<Especialidad> especialidad = new List<Especialidad>();
                List<Especialidad> aux = new List<Especialidad>();
                especialidad = especialidadNegocio.ListarEspecialidades();
            } 
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            foreach (GridViewRow row in dgvEspecialidadesMedico.Rows)
            {
                if (row.Cells[0].Text == ddlEspecialidades.SelectedItem.Text)
                {
                    existe = true;
                }
            }
            if (existe)
            {
                lblMensaje.Text = "Ya existe esta especialidad para este médico";
                lblMensaje.Visible = true;
            }
            else
            {
                EspecialidadNegocio Neg = new EspecialidadNegocio();
                Neg.AsignarEspecialidad(int.Parse(Request.QueryString["ID"]), int.Parse(ddlEspecialidades.SelectedValue));
                lblMensaje.Text = "Especialidad asignada correctamente";
                lblMensaje.Visible = true;
                //Response.Redirect("CargarMedico.aspx?ID=" + int.Parse(Request.QueryString["ID"]), false);
            }
        }

        protected void ddlMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void dgvEspecialidadesMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEspecialidadesMedico.SelectedDataKey.Value.ToString());
            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
            especialidadNegocio.DesasignarEspecialidad(int.Parse(Request.QueryString["ID"]), id);
            lblMensaje.Text = "Especialidad eliminada correctamente";
            lblMensaje.Visible = true;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuMedicos.aspx", false);
        }
    }
}