﻿using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace TP_Final_equipo2
{
	public partial class MenuMedicos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                int activos = 0;
                Session.Add("Activos", activos);
                ddlcampos.Items.Add("Especialidad");
                ddlcampos.Items.Add("DNI");
                ddlcampos.Items.Add("Nombre");
            }
			MedicoNegocio medicoNegocio = new MedicoNegocio();
			dgvMedicos.DataSource = medicoNegocio.ListarMedicosActivos();
			dgvMedicos.DataBind();
		}

        protected void dgvMedicos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void dgvMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
			int id = int.Parse(dgvMedicos.SelectedRow.Cells[0].Text);
			lblPrueba.Text = id.ToString();
			Response.Redirect("CargarMedico.aspx?ID=" + id, false);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CargarMedico.aspx", false);
        }

        protected void btnActivos_Click(object sender, EventArgs e)
        {
            int activos = Convert.ToInt32(Session["Activos"]);
            if (activos == 0)
            {
                MedicoNegocio medicoNegocio = new MedicoNegocio();
                dgvMedicos.DataSource = medicoNegocio.ListarMedicos();
                dgvMedicos.DataBind();
                activos = 1;
                Session.Add("Activos", activos);
                btnActivos.Text = "Mostrar Activos";
            }
            else 
            {
                MedicoNegocio medicoNegocio = new MedicoNegocio();
                dgvMedicos.DataSource = medicoNegocio.ListarMedicosActivos();
                dgvMedicos.DataBind();
                activos = 0;
                Session.Add("Activos", activos);
                btnActivos.Text = "Mostrar Inactivos";
            }
            
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            string seleccionar = txtfiltro.Text;
            MedicoNegocio negocio = new MedicoNegocio();
            List<Medico> listafiltrada = new List<Medico>();
            try
            {
                if(seleccionar != null || seleccionar != "")
                {
                    listafiltrada = negocio.BuscarMedicoxApellido(seleccionar);
                }
                else
                {
                    listafiltrada = negocio.ListarMedicosActivos();
                }
                    dgvMedicos.DataSource = listafiltrada;
                    dgvMedicos.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}