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

            MedicoNegocio Negocio = new MedicoNegocio();
            List<Medico> listaMedicos = Negocio.BuscarMedicoxDNI(dni);

            if (listaMedicos.Count > 0)
            {
                lblNombre.Text = listaMedicos[0].Nombre;
                lblApellido.Text = listaMedicos[0].Apellido;
                lblError.Visible = false;
            }
            else
            {
                lblError.Text = "Médico no encontrado";
                lblError.Visible = true;
                lblNombre.Text = "";
                lblApellido.Text = "";

            }
        }
    }
}