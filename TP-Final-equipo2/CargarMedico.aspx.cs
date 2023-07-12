using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

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
                ddlJornada.Items.Add("Mañana");
                ddlJornada.Items.Add("Tarde");
                ddlJornada.Items.Add("Noche");
                ListItem Activo = new ListItem("Activo", "1");
                ddlEstado.Items.Add(Activo);
                ListItem Inactivo = new ListItem("Inactivo", "0");
                ddlEstado.Items.Add(Inactivo);
                if (Request.QueryString["ID"] != null)
                {
                    ModificarMedico(int.Parse(Request.QueryString["ID"]));
                    lblTitulo.Text = "Modificando Médico";
                    btnEspecialidades.Visible = true;
                }
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                dgvEspcialidades.DataSource = negocio.ListarEspecialidades();
                dgvEspcialidades.DataBind();
                Session["AlertaMensaje"] = null;
            }
            
        }

        public void ModificarMedico(int id)
        {
            MedicoNegocio Negocio = new MedicoNegocio();
            List<Medico> medico = new List<Medico>();
            medico = Negocio.BuscarMedico(id);
            tbxApellido.Text = medico[0].Apellido;
            tbxNombre.Text = medico[0].Nombre;
            tbxDni.Text = medico[0].Dni.ToString();
            tbxCelular.Text = medico[0].Celular.ToString();
            tbxTelefono.Text = medico[0].Telefono.ToString();
            tbxEmail.Text = medico[0].Email;
            FechaIngreso.Text = medico[0].fechaingreso.ToString("yyyy-MM-dd");
            FechaNacimiento.Text = medico[0].fechanacimiento.ToString("yyyy-MM-dd");
            ddlSexo.SelectedValue = medico[0].Sexo;
            if (medico[0].Estado == true)
            {
                ddlEstado.SelectedIndex = 0;
            }
            else
            {
                ddlEstado.SelectedIndex = 1;
            }
        }

        protected void btcontinuar_Click(object sender, EventArgs e)
        {
            MedicoNegocio medicoNegocio = new MedicoNegocio();
            Medico nuevo = new Medico();
            if (ValidarVacio() == true)
            {
                nuevo.Apellido = tbxApellido.Text;
                nuevo.Nombre = tbxNombre.Text;
                nuevo.Dni = int.Parse(tbxDni.Text);
                nuevo.Celular = int.Parse(tbxCelular.Text);
                nuevo.Telefono = int.Parse(tbxTelefono.Text);
                nuevo.Email = tbxEmail.Text;
                nuevo.Sexo = ddlSexo.SelectedValue.ToString();
                nuevo.fechaingreso = DateTime.Parse(FechaIngreso.Text);
                nuevo.fechanacimiento = DateTime.Parse(FechaNacimiento.Text);
                nuevo.JornadaLaboral = ddlJornada.SelectedValue.ToString();
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
                    medicoNegocio.Modificar(nuevo);
                }
                else
                {
                    if (ValidarDNI(int.Parse(tbxDni.Text)) == true && ValidarEmail(tbxEmail.Text) == true)
                    {
                        medicoNegocio.Agregar(nuevo);
                    }
                    
                }
                lblmensaje.Visible = true;
            }
            else
            {
                // VER PORQUE NO SALE EL MENSAJE EN EL MODAL
                Session["AlertaMensaje"] = "Complete todos los campos";
                //lblmensaje.Visible = true;
                //lblmensaje.Text = "Complete todos los campos";
            }
        }

        protected bool ValidarEmail(string email)
        {
            MedicoNegocio medicoNegocio = new MedicoNegocio();
            if (medicoNegocio.ValidarEmail(email) == true)
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
            MedicoNegocio medicoNegocio = new MedicoNegocio();
            if(medicoNegocio.ValidarDNI(dni) == true)
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

        protected bool ValidarVacio()
        {
            if (tbxApellido.Text  == "" || tbxNombre.Text == "" || tbxDni.Text == "" || tbxCelular.Text == "" || tbxTelefono.Text == ""  ||  tbxEmail.Text == "" || FechaIngreso.Text ==  "" || FechaNacimiento.Text =="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuMedicos.aspx", false);
        }

        protected void gvsespcialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int id;
            int idEspecialdiad;
            if (Request.QueryString["ID"] != null)
            {
                id = int.Parse(Request.QueryString["ID"]);
            }
            else
            {
                MedicoNegocio Negmedico = new MedicoNegocio();
                id = Negmedico.UltimoIngreso();
            }
            foreach (GridViewRow row in dgvEspcialidades.Rows)
            {
                //CheckBox status = (row.Cells[1].FindControl("Checked") as CheckBox);
                CheckBox status = (CheckBox)row.FindControl("Checked");
                if (status.Checked)
                {
                    EspecialidadNegocio negocio = new EspecialidadNegocio();
                    idEspecialdiad = int.Parse(row.Cells[0].Text);
                    negocio.AsignarEspecialidad(id, idEspecialdiad);
                }
            }
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
        }

        protected void dgvEspcialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsignacionEspecialidades.aspx?ID=" + Request.QueryString["ID"], false);
        }
    }
}