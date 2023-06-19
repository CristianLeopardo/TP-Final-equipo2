using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medico
    {
        public int ID { get; set; }

        public int Legajo { get; set; }
        public Persona apellido { get; set; }
        public Persona nombre { get; set; }
        public Persona dni { get; set; }

        public List<Especialidad> Especialidades { get; set; }
    }
}
