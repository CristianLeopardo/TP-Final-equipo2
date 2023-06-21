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
        public int IdMedico { get; set; }


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
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            gvsespcialidades.DataSource = negocio.ListarEspecialidades();
            gvsespcialidades.DataBind();

        }
        protected void btcontinuar_Click(object sender, EventArgs e)
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
            lblmensaje.Visible = true;
            lblmensaje.Text = "Medico cargado exitosamente...";
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void gvsespcialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var algo = gvsespcialidades.SelectedRow.Cells[0].Text;
            var id = gvsespcialidades.SelectedDataKey.Value.ToString();
            MedicoNegocio Negmedico = new MedicoNegocio();
            EspecialidadesNegocio negocio = new EspecialidadesNegocio();
            negocio.cargarEspecialidades(Negmedico.UltimoIngreso(),id);
            lblEspecialidad.Visible = true;
            lblEspecialidad.Text = "Se agrego especialidad";
            btnaceptar.Visible = true;
        }

        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}