using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente
    {
        public int ID { get; set; }
        public Persona apellido { get; set; }
        public Persona nombre { get; set; }
        public Persona dni { get; set; }
        public Persona telefono { get; set; }
        public Persona celular { get; set; }
        public Persona email { get; set; }
        //public Persona fechanacimiento { get; set; }
        //public Persona Barrio { get; set; }
        //public Persona Partido { get; set; }
    }
}
