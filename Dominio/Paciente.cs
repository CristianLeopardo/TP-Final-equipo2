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
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }

        public string Sexo { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }

        public string Domicilio { get; set; }
        public DateTime fechanacimiento { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public bool Estado { get; set; }
    }
}
