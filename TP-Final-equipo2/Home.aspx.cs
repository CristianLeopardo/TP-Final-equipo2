﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Final_equipo2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnnewPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("CargaPaciente.aspx",false);
        }

        protected void btnnewMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("CargarMedico.aspx", false);
        }
    }
}