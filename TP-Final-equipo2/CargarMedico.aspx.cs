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
                ddlSexo.Items.Add("Otro");
                ddlSexo.Items.Add("Masculino");
                ddlSexo.Items.Add("Femenino");
                
            }

            EspecialidadNegocio negocio = new EspecialidadNegocio();
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
            nuevo.fechaingreso = DateTime.Parse(FechaIngreso.Text);
            nuevo.fechanacimiento = DateTime.Parse(FechaNacimiento.Text);
            medicoNegocio.Agregar(nuevo);
            Session["AlertaMensaje"] = "Medico cargado";
            tbxApellido.Text = "";
            tbxNombre.Text = "";
            tbxDni.Text = "";
            ddlSexo.SelectedIndex = 0;
            tbxTelefono.Text = "";
            tbxCelular.Text = "";
            tbxEmail.Text = "";
            FechaIngreso.Text = "";
            FechaNacimiento.Text = "";

            lblmensaje.Visible = true;
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
            EspecialidadNegocio negocio = new EspecialidadNegocio();
            negocio.cargarEspecialidades(Negmedico.UltimoIngreso(),id);
            lblEspecialidad.Visible = true;
            lblEspecialidad.Text = "Se agrego especialidad";

        }

        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}