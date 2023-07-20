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
    public partial class Registrarse : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"]!= null)
                {
                    Usuario actual = new Usuario();
                    actual = (Usuario)Session["usuario"];
                    tbxUsuario.Text = actual.User;
                    tbxClave.Text = actual.Clave;
                    tbxClave2.Text = actual.Clave;
                    tbxEmail.Text = actual.Email;
                    tbxEmail2.Text = actual.Email;
                    btnAceptar.Text = "Modificar";
                }
                ListItem Paciente = new ListItem("Paciente", "1");
                ddlTipoUsuario.Items.Add(Paciente);
                ListItem Medico = new ListItem("Medico", "2");
                ddlTipoUsuario.Items.Add(Medico);
                ListItem Recepcionista = new ListItem("Recepcionista", "3");
                ddlTipoUsuario.Items.Add(Recepcionista);
                ListItem Admin = new ListItem("Admin", "4");
                ddlTipoUsuario.Items.Add(Admin);
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((tbxClave.Text == tbxClave2.Text) && (tbxEmail.Text == tbxEmail2.Text))
            {
                try
                {
                    UsuarioNegocio usuario = new UsuarioNegocio();
                    Usuario nuevo = new Usuario();
                    nuevo.User = tbxUsuario.Text;
                    nuevo.Clave = tbxClave.Text;
                    nuevo.Email = tbxEmail.Text.ToUpper();
                    if (Session["usuario"]!=null)
                    {
                        usuario.Modificar(nuevo);
                        Session.Add("usuario", nuevo);
                        lblOK.Visible = true;
                        Response.Redirect("Home.aspx",false);
                    }
                    switch (int.Parse(ddlTipoUsuario.SelectedValue))
                    {
                        case 4:
                            nuevo.TipoUsuario = Dominio.TipoUsuario.Admin;
                            usuario.Agregar(nuevo);
                            break;
                        case 3:
                            nuevo.TipoUsuario = Dominio.TipoUsuario.Recepcion;
                            usuario.Agregar(nuevo);
                            break;
                        case 2:
                            nuevo.TipoUsuario = Dominio.TipoUsuario.Medico;
                            usuario.Agregar(nuevo);
                            Session.Add("usuario", nuevo);
                            lblOK.Visible = true;
                            Response.Redirect("CargarMedico.aspx?Nuevo=" + tbxDNI.Text, false);
                            break;
                        case 1:
                            nuevo.TipoUsuario = Dominio.TipoUsuario.Paciente;
                            usuario.Agregar(nuevo);
                            Session.Add("usuario", nuevo);
                            lblOK.Visible = true;
                            Response.Redirect("CargaPaciente.aspx?Nuevo=" + tbxDNI.Text, false);
                            break;
                        default:
                            break;
                    }
                    
                    lblOK.Visible = true;
                    tbxUsuario.Text = "";
                    tbxDNI.Text = "";
                    tbxEmail.Text = "";
                    tbxEmail2.Text = "";

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                lblNOK.Visible = true;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
        }
    }
}