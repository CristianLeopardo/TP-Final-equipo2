using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TP_Final_equipo2
{
    public partial class RecuperarClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string aux;
            EmailService emailService = new EmailService();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            aux = "Su contraseña es: " + usuarioNegocio.BuscarCorreo(tbxEmail.Text.ToUpper());

            if(aux != "")
            {
                emailService.ArmarCorreo(tbxEmail.Text,"Recupero de clave", aux);
            }
            else
            {
                lblMensaje.Text = "Email no existente";
                lblMensaje.Visible = true;
            }
            
        }
    }
}