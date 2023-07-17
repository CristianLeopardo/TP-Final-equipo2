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
    public partial class TurnosxPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Add("usuario", "charly168");  // reemplazar  por la sesion  verdadera
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Paciente id;
            string mensaje;
            EmailService emailService = new EmailService();
            PacientesNegocio pa =  new PacientesNegocio();
            UsuarioNegocio us  = new UsuarioNegocio();
            if (Session["usuario"] != null)
            {
                id = pa.BuscarIDxEmail(us.BuscarEmail((string)Session["usuario"])); 
                if (tbxDescripccion.Text.Length > 50)
                {
                    mensaje = "El Paciente: " + id.Apellido + " " + id.Nombre + " DNI: " + id.Dni + " Correo: " + id.Email + " realiza la siguiente solicitud: " + tbxDescripccion.Text;
                    emailService.ArmarCorreo("TecnoClinicaProgramacion@gmail.com", "Solicitud de turno", mensaje);
                }
                else
                {
                    // mensaje de error de solicitud de pocos caracteres
                }
            }
            else
            {
                // mensaje  de error
            }
            
        }

        protected void btnSolicitud_Click(object sender, EventArgs e)
        {
            lblDescripcion.Visible = true;
            tbxDescripccion.Visible = true;
            btnEnviar.Visible = true;
        }

        protected void btnMenuTurnos_Click(object sender, EventArgs e)
        {
            Paciente id;
            PacientesNegocio pa = new PacientesNegocio();
            UsuarioNegocio us = new UsuarioNegocio();
            id = pa.BuscarIDxEmail(us.BuscarEmail((string)Session["usuario"]));
            Response.Redirect("AgregarTurno.aspx?IDPaciente=" + id.ID, false);
        }
    }
}