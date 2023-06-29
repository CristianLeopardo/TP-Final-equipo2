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
                    nuevo.Email = tbxEmail.Text;
                    //nuevo.TipoUsuario = ddlTipoUsuario.SelectedValue;
                    usuario.Agregar(nuevo);
                    lblOK.Visible = true;
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