using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        public int ID { get; set; }
        public int IDPaciente { get; set; }
        public int IDMedico { get; set; }
        public int IDEspecialidad { get; set; }
        public string Fecha { get; set; }
        public int Estado { get; set; }
    }
}
