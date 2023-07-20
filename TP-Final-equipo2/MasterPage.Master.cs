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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx",false);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx", false);
        }

        protected void btnTurnos_Click(object sender, EventArgs e)
        {

        }
    }
}