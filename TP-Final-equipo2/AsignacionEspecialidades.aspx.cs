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
                MedicoNegocio medicoNegocio = new MedicoNegocio();
                ddlMedicos.DataSource = medicoNegocio.ListarMedicos();
                ddlMedicos.DataValueField = "ID";
                ddlMedicos.DataTextField = "Dni";
                ddlMedicos.DataBind();
            }



        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EspecialidadesNegocio especialidadesNegocio = new EspecialidadesNegocio();
            especialidadesNegocio.DesasignarEspecialidad(int.Parse(ddlMedicos.SelectedValue), int.Parse(ddlEspecialidades.SelectedValue));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            EspecialidadesNegocio especialidadesNegocio = new EspecialidadesNegocio();
            especialidadesNegocio.AsignarEspecialidad(int.Parse(ddlMedicos.SelectedValue),int.Parse(ddlEspecialidades.SelectedValue) );
        }


        protected void rbtEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EspecialidadesNegocio especialidadesNegocio = new EspecialidadesNegocio();

            if (int.Parse(rbtEleccion.SelectedValue) == 1)
            {
                ddlEspecialidades.DataSource = especialidadesNegocio.ListarEspecialidades();
                ddlEspecialidades.DataValueField = "ID";
                ddlEspecialidades.DataTextField = "Nombre";
                ddlEspecialidades.DataBind();
                btnAgregar.Visible = true;
                btnEliminar.Visible = false;

            }
            else
            {
                ddlEspecialidades.DataSource = especialidadesNegocio.ListarEspecialidadesMedico(int.Parse(ddlMedicos.SelectedValue));
                ddlEspecialidades.DataTextField = "NombreEspecialidad";
                ddlEspecialidades.DataValueField = "IDEspecialdiad";
                ddlEspecialidades.DataBind();
                btnAgregar.Visible = false;
                btnEliminar.Visible = true;
            }


        }

        protected void ddlMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EspecialidadesNegocio especialidadesNegocio = new EspecialidadesNegocio();
            ddlEspecialidades.DataSource = especialidadesNegocio.ListarEspecialidadesMedico(int.Parse(ddlMedicos.SelectedValue));
            ddlEspecialidades.DataTextField = "NombreEspecialidad";
            ddlEspecialidades.DataValueField = "IDEspecialdiad";
            ddlEspecialidades.DataBind();


        }
    }
}