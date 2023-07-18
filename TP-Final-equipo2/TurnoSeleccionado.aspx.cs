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
    public partial class TurnoSeleccionado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"].ToString());

                TurnoNegocio negocio = new TurnoNegocio();
                List<Turno> temporal = negocio.ListarTurnos();
                Turno elegido = temporal.Find(x => x.ID == id);
                lblFechamuestra.Text = elegido.Fecha.ToString("dd/MM/yyyy HH:mm") + " Hs";
                lblespecialidadmuestra.Text = elegido.NombreEspecialidad;
                lbldoctormuestra.Text = elegido.NombreMedico.ToString();
                lblEstadoTurno.Text = elegido.Estado.ToString();

                PacientesNegocio negociopaciente = new PacientesNegocio();
                List<Paciente> lisTemporal = negociopaciente.BuscarPaciente(elegido.IDPaciente);
                Paciente actual = lisTemporal.Find(x=> x.ID == elegido.IDPaciente);
                lblApellidocliente.Text = actual.Apellido;
                lblNombrePac.Text = actual.Nombre;
                lblDNImuestra.Text = actual.Dni.ToString();
                lblsexpaciente.Text = actual.Sexo;

                ObservacionesNegocio tiene = new ObservacionesNegocio();
                string estado = elegido.Estado.ToString();
                if (estado == "Cancelado")
                {
                    List<Observaciones> listaobs = tiene.BuscarObs(elegido.ID);
                    Observaciones obj = listaobs.Find(x=> x.IDTurno == elegido.ID);
                    //txtobservaciones.Text = obj.Descripcion;
                }
            }
        }

        protected void btnvolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("TurnosxMedicos.aspx",false);
        }

        protected void btncancelarturno_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Request.QueryString["ID"].ToString());
                TurnoNegocio negocio = new TurnoNegocio();
                List<Turno> temporal = negocio.ListarTurnos();
                Turno elegido = temporal.Find(x => x.ID == id);
                int estado = 2;
                negocio.Modificarturno(elegido.ID, estado);
                //Turno cancelado
                Response.Redirect("TurnosxMedicos.aspx", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                int estado = 2;
                string obs=txtobservaciones.Text;
                if (obs != "")
                {
                    int id = int.Parse(Request.QueryString["ID"].ToString());
                    TurnoNegocio negocio = new TurnoNegocio();
                    List<Turno> temporal = negocio.ListarTurnos();
                    Turno elegido = temporal.Find(x => x.ID == id);

                    ObservacionesNegocio negocio1 = new ObservacionesNegocio();
                    negocio1.insertarObservacion(elegido.ID, obs);

                    negocio.Modificarturno(elegido.ID, estado);

                    Response.Redirect("TurnosxMedicos.aspx", false);
                }
                ///Aviso de carga en las obs
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}