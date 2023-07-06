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
    public partial class MenuPacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int activos = 0;
                Session.Add("ActivosP", activos);
                ddlcampos.Items.Add("Nombre");
                ddlcampos.Items.Add("Apellido");
                ddlcampos.Items.Add("DNI"); 
                PacientesNegocio pacienteNegocio = new PacientesNegocio();
                Session.Add("ListaPacientes", pacienteNegocio.ListarPacientes());
                dgvPacientes.DataSource = Session["ListaPacientes"];
                dgvPacientes.DataBind();
            }
        }

        protected void dgvPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPacientes.SelectedDataKey.Value.ToString());
            Response.Redirect("CargaPaciente.aspx?ID=" + id, false);
        }

        protected void dgvPacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CargaPaciente.aspx", false);
        }

        protected void btnActivos_Click(object sender, EventArgs e)
        {
            int activos = Convert.ToInt32(Session["ActivosP"]);
            if (activos == 0)
            {
                List<Paciente> lista = (List<Paciente>)Session["ListaPacientes"];
                List<Paciente> listafiltrada = lista.FindAll(x => x.Estado == true);
                dgvPacientes.DataSource = listafiltrada;
                dgvPacientes.DataBind();
                activos = 1;
                Session.Add("ActivosP", activos);
                btnActivos.Text = "Mostrar todos";
            }
            else
            {
                List<Paciente> lista = (List<Paciente>)Session["ListaPacientes"];
                dgvPacientes.DataSource = lista;
                dgvPacientes.DataBind();
                activos = 0;
                Session.Add("ActivosP", activos);
                btnActivos.Text = "Mostrar Activos";
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnfiltrar_Click(object sender, EventArgs e)
        {
            PacientesNegocio negocio = new PacientesNegocio();
            string campo = ddlcampos.SelectedItem.Text;
            string dato = txtcriterio.Text.ToString();
            dgvPacientes.DataSource = negocio.BuscarPacienteCriterio(campo, dato);
            dgvPacientes.DataBind();
        }

        protected void ddlcampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string campo = ddlcampos.SelectedItem.Text;
                if (campo == "Apellido")
                {
                    if (campo != "DNI")
                    {
                        lblcriterio.Text = "Nombre: ";
                    }
                    else
                    {
                        lblcriterio.Text = "DNI: ";
                    }
                }
                else
                {
                    lblcriterio.Text = "Apellido: ";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}