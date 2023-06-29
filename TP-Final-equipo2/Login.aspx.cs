using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Final_equipo2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["usuario"] == null)
            //{
            //    if (Session["MensajeError"] != null)
            //    {
            //        lblMensajeError.Text = Session["MensajeError"].ToString();
            //        lblMensajeError.Visible = true;
            //        Session.Remove("MensajeError");
            //    }
            //}
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioNegocio userNegocio = new UsuarioNegocio();

            try
            {

                usuario.User = tbxUsuario.Text;
                usuario.Clave = tbxClave.Text;
                if (userNegocio.Login(usuario))
                {
                    Session.Add("usuario", usuario);
                    Response.Redirect("Home.Aspx", false);
                }
                else
                {
                    Session.Add("error", "Usuario o contraseña incorrectos");
                    lblMensajeError.Text = "Credenciales incorrectas. Inténtelo nuevamente.";
                    lblMensajeError.Visible = true;
                    //Response.Redirect("Login.aspx", false);
                }
                
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx", false);
        }
    }
}