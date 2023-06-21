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
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }

        public string Sexo { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
        public DateTime fechanacimiento { get; set; }
        public DateTime fechaingreso { get; set; }
        public bool Estado { get; set; }

        public List<Especialidad> Especialidades { get; set; }
    }
}
