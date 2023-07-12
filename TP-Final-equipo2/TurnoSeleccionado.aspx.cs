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
                List<Turnos> temporal =(List<Turnos>)Session["Turno"];
                //Turnos seleccionado = temporal.Find(x => x.ID = id);
                
            }
        }
    }
}