using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class CargarMedico : System.Web.UI.Page
    {
        //private void EnviarMensajeError(string login, string mensajeError)
        //{
        //    Session["MensajeError"] = mensajeError;
        //    Response.Redirect(login);
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlEspecialidades.Items.Add("MMMM");
            ddlEspecialidades.Items.Add("AAAA");
            ddlEspecialidades.Items.Add("ADADDA");

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
            MedicoNegocio medicoNegocio = new MedicoNegocio();
            Medico nuevo = new Medico();
            nuevo.Apellido = tbxApellido.Text;
            nuevo.Nombre = tbxNombre.Text;
            nuevo.Dni = int.Parse(tbxDni.Text);
            nuevo.Celular = int.Parse(tbxCelular.Text);
            nuevo.Telefono = int.Parse(tbxTelefono.Text);
            nuevo.Email = tbxEmail.Text;
            nuevo.Sexo = ddlSexo.SelectedValue.ToString();
            nuevo.fechaingreso = calFechaIngreso.SelectedDate;
            nuevo.fechanacimiento = calFechaNacimiento.SelectedDate;
            medicoNegocio.Agregar(nuevo);
            lblMensaje.Visible = true;
            lblMensaje.Text = "Medico cargado exitosamente...";
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}