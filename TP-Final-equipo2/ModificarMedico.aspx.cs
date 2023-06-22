﻿using Dominio;
using Negocio;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MedicoNegocio medicoNegocio = new MedicoNegocio();
            if (!IsPostBack)
            {
                ddlSexo.Items.Add("Masculino");
                ddlSexo.Items.Add("Femenino");
                ddlSexo.Items.Add("Otro");
            }
            try
            {
                if(!IsPostBack)
                {
                    ddlMedicos.DataSource = medicoNegocio.ListarMedicos();
                    ddlMedicos.DataTextField = "DNI";
                    ddlMedicos.DataValueField = "ID";
                    ddlMedicos.DataBind();
                }
            }
            catch(Exception ex)
            {
                Session.Add("Error", ex);
            }
           

        }

        private void CargarFormulario(int id)
        {
            MedicoNegocio busqueda = new MedicoNegocio();
            List<Medico> lista = busqueda.BuscarMedico(id);
            tbxApellido.Text = lista[0].Apellido;
            tbxNombre.Text = lista[0].Nombre;
            tbxDNI.Text = lista[0].Dni.ToString();
            tbxDNINuevo.Text = lista[0].Dni.ToString();
            tbxCelular.Text = lista[0].Celular.ToString();
            tbxTelefono.Text = lista[0].Telefono.ToString();
            tbxEmail.Text = lista[0].Email;
            ddlSexo.SelectedValue = lista[0].Sexo;
            calFechaIngreso.SelectedDate = lista[0].fechaingreso;
            calFechaNacimiento.SelectedDate = lista[0].fechanacimiento;
            if (lista[0].Estado == true)
            {
                lblActivo.Visible = true;
                lblInactivo.Visible = false;
            }
            else
            {
                lblActivo.Visible = false;
                lblInactivo.Visible = true;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarFormulario(int.Parse(ddlMedicos.SelectedValue));
        }

        protected void btnVovler_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            MedicoNegocio nuevo = new MedicoNegocio();
            Medico modificado = new Medico();
            modificado.Nombre = tbxNombre.Text;
            modificado.Apellido = tbxApellido.Text;
            modificado.Dni = int.Parse(tbxDNINuevo.Text);
            modificado.Celular = int.Parse(tbxCelular.Text);
            modificado.Telefono = int.Parse(tbxTelefono.Text);
            modificado.Email = tbxEmail.Text;
            modificado.Sexo = ddlSexo.SelectedValue;
            modificado.fechaingreso = calFechaIngreso.SelectedDate;
            modificado.fechanacimiento = calFechaNacimiento.SelectedDate;
            modificado.Estado = true;
            modificado.ID = int.Parse(ddlMedicos.SelectedValue);
            nuevo.Modificar(modificado);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            MedicoNegocio eliminar = new MedicoNegocio();
            eliminar.Eliminar(int.Parse(ddlMedicos.SelectedValue));
        }
    }
}