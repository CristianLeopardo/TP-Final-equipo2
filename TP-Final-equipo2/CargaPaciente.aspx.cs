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
                nuevo.fechanacimiento = calFechaNacimiento.SelectedDate;

                negocio.Agregar(nuevo);
                lblMensaje.Visible = true;
                lblMensaje.Text = "Paciente cargado exitosamente...";
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
    }
}