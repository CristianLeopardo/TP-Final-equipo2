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
            EspecialidadNegocio especialidadesNegocio = new EspecialidadNegocio();
            ddlEspecialidades.DataSource = especialidadesNegocio.ListarEspecialidades();
            ddlEspecialidades.DataTextField = "Nombre";
            ddlEspecialidades.DataValueField = "ID";
            ddlEspecialidades.DataBind();
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(rbtEleccion.SelectedValue) == 1)
            {
                lblEspecialidades.Visible = true;
                tbxEspecialidad.Visible = true;
                ddlEspecialidades.Visible = false;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnAgregar.Visible = true;
                lblMensaje.Visible = false;
            }
            else if (int.Parse(rbtEleccion.SelectedValue) == 2)
            {
                lblEspecialidades.Visible = false;
                tbxEspecialidad.Visible = true;
                ddlEspecialidades.Visible = true;
                btnEliminar.Visible = false;
                btnAgregar.Visible = false;
                btnModificar.Visible = true;
                lblMensaje.Visible = false;
            }
            else
            {
                lblEspecialidades.Visible = false;
                tbxEspecialidad.Visible = false;
                ddlEspecialidades.Visible = true;
                btnEliminar.Visible = true;
                btnModificar.Visible = false;
                btnAgregar.Visible = false;
                lblMensaje.Visible = false;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio nuevo = new EspecialidadNegocio();
            try
            {
                nuevo.EliminarEspecialidad(int.Parse(ddlEspecialidades.SelectedValue));
                lblMensaje.Visible = true;
                lblMensaje.Text = "Especialidad eliminada exitosamente...";
            }
            catch (Exception ex)
            {
                throw ex;
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
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio nuevo = new EspecialidadNegocio();
            try
            {
                nuevo.ModificarEspecialidad(int.Parse(ddlEspecialidades.SelectedValue), tbxEspecialidad.Text);
                lblMensaje.Visible = true;
                lblMensaje.Text = "Especialidad modificada exitosamente...";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}