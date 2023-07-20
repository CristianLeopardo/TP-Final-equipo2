﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Dominio;
using Negocio;

namespace TP_Final_equipo2
{
    public partial class CargaPaciente : System.Web.UI.Page
    {
        //private void EnviarMensajeError(string login, string mensajeError)
        //{
        //    Session["MensajeError"] = mensajeError;
        //    Response.Redirect(login);
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debe iniciar sesion para acceder a la pagina");
                Response.Redirect("Error.aspx", false);
            }
            if (!(Session["usuario"] != null && (((Dominio.Usuario)Session["usuario"]).TipoUsuario != Dominio.TipoUsuario.Medico)))
            {
                Session.Add("error", "No tiene permisos para ingresar a esta pagina");
                Response.Redirect("Error.aspx", false);
            }


            if (!IsPostBack)
            {
                ddlSexo.Items.Add("Masculino");
                ddlSexo.Items.Add("Femenino");
                ddlSexo.Items.Add("Otro");
                ListItem Activo = new ListItem("Activo", "1");
                ddlEstado.Items.Add(Activo);
                ListItem Inactivo = new ListItem("Inactivo", "0");
                ddlEstado.Items.Add(Inactivo);
                if (Request.QueryString["ID"] != null)
                {
                    ModificarPaciente(int.Parse(Request.QueryString["ID"]));
                    lblTitulo.Text = "Modificando paciente <i class='bi bi-person-gear'></i>";
                }
                if (Request.QueryString["Nuevo"] != null)
                {
                    tbxEmail.Text = ((Dominio.Usuario)Session["usuario"]).Email;
                    tbxEmail.Enabled = false;
                    tbxDni.Text = Request.QueryString["Nuevo"];
                    tbxDni.Enabled = false;
                }
            }
        }
        public void ModificarPaciente(int id)
        {
            PacientesNegocio Negocio = new PacientesNegocio();
            List<Paciente> paciente = new List<Paciente>();
            paciente = Negocio.BuscarPaciente(id);
            tbxApellido.Text = paciente[0].Apellido;
            tbxNombre.Text = paciente[0].Nombre;
            tbxDni.Text = paciente[0].Dni.ToString();
            tbxCelular.Text = paciente[0].Celular.ToString();
            tbxTelefono.Text = paciente[0].Telefono.ToString();
            tbxEmail.Text = paciente[0].Email;
            FechaNacimiento.Text = paciente[0].fechanacimiento.ToString("yyyy-MM-dd");
            tbxDomicilio.Text = paciente[0].Domicilio;
            tbxLocalidad.Text = paciente[0].Localidad;
            tbxProvincia.Text = paciente[0].Provincia;
            ddlSexo.SelectedValue = paciente[0].Sexo;
            if (paciente[0].Estado == true)
            {
                ddlEstado.SelectedIndex = 0;
            }
            else
            {
                ddlEstado.SelectedIndex = 1;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesNegocio negocio = new PacientesNegocio();
                Paciente nuevo = new Paciente();
                //if (ValidarVacio() == true)
                //{
                if (solonumemros() == true)
                {
                    nuevo.Apellido = tbxApellido.Text;
                    nuevo.Nombre = tbxNombre.Text;
                    nuevo.Dni = int.Parse(tbxDni.Text);
                    nuevo.Sexo = ddlSexo.SelectedValue.ToString();
                    nuevo.Telefono = int.Parse(tbxTelefono.Text);
                    nuevo.Celular = int.Parse(tbxCelular.Text);
                    nuevo.Email = tbxEmail.Text;
                    nuevo.Domicilio = tbxDomicilio.Text;
                    nuevo.Localidad = tbxLocalidad.Text;
                    nuevo.Provincia = tbxProvincia.Text;
                    nuevo.fechanacimiento = DateTime.Parse(FechaNacimiento.Text);
                    if (int.Parse(ddlEstado.SelectedValue) == 1)
                    {
                        nuevo.Estado = true;
                    }
                    else
                    {
                        nuevo.Estado = false;
                    }
                    if (Request.QueryString["ID"] != null)
                    {
                        nuevo.ID = int.Parse(Request.QueryString["ID"]);
                        negocio.Modificar(nuevo);
                        lblmensaje.Visible = false;
                    }
                    else
                    {
                        if (ValidarDNI(int.Parse(tbxDni.Text)) == true && ValidarEmail(tbxEmail.Text) == true)
                        {
                            negocio.Agregar(nuevo);
                            Session["AlertaMensajeok"] = "Paciente cargado";
                            lblmensaje.Visible = false;
                        }

                        //<<<<<<< HEAD
                        //}
                        else
                        {
                            // VER PORQUE NO SALE EL MENSAJE EN EL MODAL
                            Session["AlertaMensaje"] = "Complete todos los campos";
                            lblmensaje.Visible = true;
                            lblmensaje.Text = "Complete todos los campos";
                        }
                        Session["AlertaMensaje"] = "Paciente cargado";
                    }
                    //else
                    //{
                    //    // VER PORQUE NO SALE EL MENSAJE EN EL MODAL
                    //    Session["AlertaMensaje"] = "Complete todos los campos";
                    //    //lblmensaje.Visible = true;
                    //    //lblmensaje.Text = "Complete todos los campos";
                    //}
                    //if (!int.TryParse(tbxDni.Text, out int dni))
                    //{
                    //    return;
                    //}
                    if (lblmensaje.Visible != true)
                    {
                        tbxApellido.Text = "";
                        tbxNombre.Text = "";
                        tbxDni.Text = "";
                        ddlSexo.SelectedIndex = 0;
                        tbxTelefono.Text = "";
                        tbxCelular.Text = "";
                        tbxEmail.Text = "";
                        tbxDomicilio.Text = "";
                        tbxLocalidad.Text = "";
                        tbxProvincia.Text = "";
                        FechaNacimiento.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected bool ValidarEmail(string email)
        {
            PacientesNegocio PacienteNegocio = new PacientesNegocio();
            if (PacienteNegocio.ValidarEmail(email) == true)
            {
                // VER PORQUE NO SALE EL MENSAJE EN EL MODAL
                Session["AlertaMensaje"] = "EMAIL EXISTENTE";
                lblmensaje.Visible = true;
                lblmensaje.Text = "EMAIL EXISTENTE";
                return false;
            }
            else
            { return true; }
        }

        protected bool ValidarDNI(int dni)
        {
            PacientesNegocio PacienteNegocio = new PacientesNegocio();
            if (PacienteNegocio.ValidarDNI(dni) == true)
            {
                // VER PORQUE NO SALE EL MENSAJE EN EL MODAL
                Session["AlertaMensaje"] = "DNI EXISTENTE";
                lblmensaje.Visible = true;
                lblmensaje.Text = "DNI EXISTENTE";
                return false;
            }
            else
            { return true; }
        }

        protected bool solonumemros()
        {
            string cadena = tbxTelefono.Text;

            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    lblmensaje.Visible = true;
                    lblmensaje.Text = "DEBE INGRESAR UN NUMERO EN EL TELEFONO";
                    return false;
                }
            }
            cadena = tbxCelular.Text;
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    lblmensaje.Visible = true;
                    lblmensaje.Text = "DEBE INGRESAR UN NUMERO EN EL CELULAR";
                    return false;
                }
            }
            return true;
        }

        //protected bool ValidarVacio()
        //{
        //    if (tbxApellido.Text == "" || tbxLocalidad.Text == "" || tbxProvincia.Text == "" || tbxNombre.Text == "" || tbxDni.Text == "" || tbxCelular.Text == "" || tbxTelefono.Text == "" || tbxEmail.Text == "" || tbxDomicilio.Text == "" || FechaNacimiento.Text == "")
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void calFechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void btnAceptar2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}