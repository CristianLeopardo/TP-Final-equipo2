using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Final_equipo2
{
    public partial class ListaMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MedicoNegocio negocio = new MedicoNegocio();
                gvListaMedicos.DataSource = negocio.ListarMedicos();
                gvListaMedicos.DataBind();
                EspecialidadNegocio NegocioEs= new EspecialidadNegocio();
                ddlEspecialidades.DataSource = NegocioEs.ListarEspecialidades();
                ddlEspecialidades.DataValueField = "ID";
                ddlEspecialidades.DataTextField = "Nombre";
                ddlEspecialidades.DataBind();
            }
        }

        protected void gvListaMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algo = gvListaMedicos.SelectedRow.Cells[0].Text;
            var id = gvListaMedicos.SelectedDataKey.Value.ToString();
            Response.Redirect("mostrarEspecialidades", false);
        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Idselecionado = int.Parse(ddlEspecialidades.SelectedValue);
            MedicoNegocio negocio = new MedicoNegocio();

            gvListaMedicos.DataSource= negocio.BuscarMedico(Idselecionado);
        }
    }
}