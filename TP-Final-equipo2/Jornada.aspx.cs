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
    public partial class Jornada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {               
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                ddlEspecialidad.DataSource = negocio.ListarEspecialidades();
                ddlEspecialidad.DataValueField = "ID";
                ddlEspecialidad.DataTextField = "Nombre";
                ddlEspecialidad.DataBind();
                ddlTurno.Items.Add("Mañana");
                ddlTurno.Items.Add("Tarde");
                ddlTurno.Items.Add("Noche");
                //MedicoNegocio medicoNegocio = new MedicoNegocio();
                //Session.Add("ListaMedicos", medicoNegocio.ListarMedicos());
                //dgvMedicos.DataSource = Session["ListaMedicos"];
                //dgvMedicos.DataBind();
            }
        }

        protected void btnAgregarHora_Click(object sender, EventArgs e)
        {
            if (tbxDNI.Text.Length > 0 && tbxFecha.Text.Length > 0 && tbxHora.Text.Length > 0)
            {
                HorarioNegocio negocio = new HorarioNegocio();
                Horario nuevo = new Horario();

                int dni = int.Parse(tbxDNI.Text);

                MedicoNegocio medicoNegocio = new MedicoNegocio();
                List<Medico> listaMedicos = medicoNegocio.BuscarMedicoxDNI(dni);

                nuevo.Medico = listaMedicos[0];
                nuevo.Fecha = DateTime.Parse(tbxFecha.Text);

                string horaSeleccionada = tbxHora.Text;

                Hora hora = negocio.BuscarHora(horaSeleccionada);

                if (hora != null)
                {
                    nuevo.Hora = hora;
                }
                else
                {
                    lblErrorHora.Text = "Horario no aceptado";
                    lblErrorHora.Visible = true;
                }

                negocio.Agregar(nuevo);

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(tbxDNI.Text);

            PacientesNegocio Negocio = new PacientesNegocio();
            List<Paciente> listaPaciente = Negocio.BuscarPacientexDNI(dni);

            if (listaPaciente.Count > 0)
            {
                lblNombre.Text = listaPaciente[0].Nombre;
                lblApellido.Text = listaPaciente[0].Apellido;
                lblError.Visible = false;
            }
            else
            {
                lblError.Text = "Paciente no encontrado";
                lblError.Visible = true;
                lblNombre.Text = "";
                lblApellido.Text = "";

            }
        }

        protected void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            MedicoNegocio negocio = new MedicoNegocio();
            string especialidad = ddlEspecialidad.SelectedItem.Text;
            string turno = ddlTurno.SelectedValue.ToString();
            dgvTurnos.DataSource = negocio.BuscarMedicoxApellido(campo, dato);
            dgvTurnos.DataBind();




        }
    }
}