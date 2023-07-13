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
    public partial class TurnosxMedicos : System.Web.UI.Page
    {
        public int Medicoactual { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            MedicoNegocio neg = new MedicoNegocio();
            Usuario actuall = (Usuario)Session["Usuario"];

            //Medicoactual = neg.BuscarProfesional(actuall.Email);
            Medicoactual = 19;
            if (!IsPostBack)
            {
                ddlcampo.Items.Add("Apellido");
                ddlcampo.Items.Add("DNI");
                TurnoNegocio negocio = new TurnoNegocio();
                dgvturnos.DataSource = negocio.listadgv(Medicoactual);
                dgvturnos.DataBind();
            }
        }

        protected void btnvolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx",false);
        }

        protected void btntodslosturnos_Click(object sender, EventArgs e)
        {
            try
            {
                TurnoNegocio negocio = new TurnoNegocio();
                dgvturnos.DataSource = negocio.listadgv(Medicoactual);
                dgvturnos.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void btnturnoshoy_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaactual = DateTime.Today;
                string dia = fechaactual.ToString("dd");
                string mes = fechaactual.ToString("MM");
                string anio = fechaactual.ToString("yyyy");
                TurnoNegocio negocio = new TurnoNegocio();
                dgvturnos.DataSource = negocio.BuscarTurnosHoy(dia,mes,anio, Medicoactual);
                dgvturnos.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void ddlcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = ddlcampo.SelectedValue;
            lblcriterio.Text = "Ingresar " + campo;
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = ddlcampo.SelectedValue;
                string criterio = txtcriterio.Text;
                TurnoNegocio negocio = new TurnoNegocio();
                dgvturnos.DataSource =negocio.buscarporCriterio(campo,criterio, Medicoactual);
                dgvturnos.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void txtcriterio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string campo = ddlcampo.SelectedValue;
                string criterio = txtcriterio.Text;
                TurnoNegocio negocio = new TurnoNegocio();
                dgvturnos.DataSource = negocio.buscarporCriterio(campo, criterio, Medicoactual);
                dgvturnos.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void dgvturnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var a = dgvturnos.SelectedRow.Cells[0].Text;
                var ID = dgvturnos.SelectedDataKey.Value.ToString();
                Response.Redirect("TurnoSeleccionado.aspx?ID="+ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}