using System;
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
            //if (Session["usuario"] == null)
            //{
            //    string MensajeError = "Debe iniciar sesion para acceder a la pagina";
            //    EnviarMensajeError("Login.aspx", MensajeError);
            //}


            if (!IsPostBack)
            {
                ddlSexo.Items.Add("Masculino");
                ddlSexo.Items.Add("Femenino");
                ddlSexo.Items.Add("Otro");
                

            }
            


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesNegocio negocio = new PacientesNegocio();
                Paciente nuevo = new Paciente();
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


                //if (!int.TryParse(tbxDni.Text, out int dni))
                //{
                //    return;
                //}
                negocio.Agregar(nuevo);
                Session["AlertaMensaje"] = "Paciente cargado";
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

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