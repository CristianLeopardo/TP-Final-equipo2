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
                ddlcampos.Items.Add("Nombre");
                ddlcampos.Items.Add("Apellido");
                ddlcampos.Items.Add("DNI");
                MedicoNegocio medicoNegocio = new MedicoNegocio();
                Session.Add("ListaMedicos", medicoNegocio.ListarMedicos());
                dgvMedicos.DataSource = Session["ListaMedicos"];
                dgvMedicos.DataBind();
            }           
        }

        protected void dgvMedicos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }

        protected void dgvMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMedicos.SelectedDataKey.Value.ToString());
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
                List<Medico> lista = (List<Medico>)Session["ListaMedicos"];
                List<Medico> listafiltrada = lista.FindAll(x => x.Estado == true);
                dgvMedicos.DataSource= listafiltrada;
                dgvMedicos.DataBind();
                activos = 1;
                Session.Add("Activos", activos);
                btnActivos.Text = "Mostrar todos";
            }
            else
            {
                List<Medico> lista = (List<Medico>)Session["ListaMedicos"];
                dgvMedicos.DataSource = lista;
                dgvMedicos.DataBind();
                activos = 0;
                Session.Add("Activos", activos);
                btnActivos.Text = "Mostrar Activos";
            }
        }

        protected void ddlcampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string campo = ddlcampos.SelectedItem.Text;
                if (campo == "Apellido")
                {
                    if (campo != "DNI")
                    {
                        lblcriterio.Text = "Nombre: ";
                    }
                    else
                    {
                        lblcriterio.Text = "DNI: ";
                    }
                }
                else
                {
                    lblcriterio.Text = "Apellido: ";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnfiltrar_Click(object sender, EventArgs e)
        {
            MedicoNegocio negocio = new MedicoNegocio();
            string campo = ddlcampos.SelectedItem.Text;
            string dato = txtcriterio.Text.ToString();
            dgvMedicos.DataSource = negocio.BuscarMedicoxApellido(campo, dato);
            dgvMedicos.DataBind();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}