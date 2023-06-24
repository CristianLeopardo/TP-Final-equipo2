using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PacientesNegocio pacientesNegocio = new PacientesNegocio();
            try
            {
                if(!IsPostBack)
                {
                    ddlSexo.Items.Add("Masculino");
                    ddlSexo.Items.Add("Femenino");
                    ddlSexo.Items.Add("Otro");

                    ddlPacientes.DataSource = pacientesNegocio.ListarPacientes();
                    ddlPacientes.DataTextField = "DNI";
                    ddlPacientes.DataValueField = "ID";
                    ddlPacientes.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
            }
        }
        private void CargarFormulario(int id)
        {
            PacientesNegocio busqueda = new PacientesNegocio();
            List<Paciente> lista = busqueda.BuscarPaciente(id);
            tbxApellido.Text = lista[0].Apellido;
            tbxNombre.Text = lista[0].Nombre;
            tbxDNI.Text = lista[0].Dni.ToString();
            tbxDNIN.Text = lista[0].Dni.ToString();
            tbxCelular.Text = lista[0].Celular.ToString();
            tbxTelefono.Text = lista[0].Telefono.ToString();
            tbxEmail.Text = lista[0].Email;
            ddlSexo.SelectedValue = lista[0].Sexo;
            tbxDomicilio.Text = lista[0].Domicilio;
            tbxLocalidad.Text = lista[0].Localidad;
            tbxProvincia.Text = lista[0].Provincia;
            FechaNacimiento.Text = lista[0].fechanacimiento.ToString();
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
            PacientesNegocio negocio = new PacientesNegocio();
            int id;
            if  (tbxDNI.Text != "")
            {
                 id = negocio.BuscarID(int.Parse(tbxDNI.Text));
            }
            else
            {
                id = int.Parse(ddlPacientes.SelectedValue);
            }
            
            CargarFormulario(id);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            PacientesNegocio nuevo = new PacientesNegocio();
            Paciente modificado = new Paciente();
            modificado.Nombre = tbxNombre.Text;
            modificado.Apellido = tbxApellido.Text;
            modificado.Dni = int.Parse(tbxDNIN.Text);
            modificado.Celular = int.Parse(tbxCelular.Text);
            modificado.Telefono = int.Parse(tbxTelefono.Text);
            modificado.Email = tbxEmail.Text;
            modificado.Sexo = ddlSexo.SelectedValue;
            modificado.Domicilio = tbxDomicilio.Text;
            modificado.Localidad = tbxLocalidad.Text;
            modificado.Provincia = tbxProvincia.Text;
            modificado.fechanacimiento = DateTime.Parse(FechaNacimiento.Text);
            modificado.Estado = true;
            modificado.ID = int.Parse(ddlPacientes.SelectedValue);
            nuevo.Modificar(modificado);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            PacientesNegocio eliminar = new PacientesNegocio();
            eliminar.Eliminar(int.Parse(ddlPacientes.SelectedValue));
        }

        protected void btnHome1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}