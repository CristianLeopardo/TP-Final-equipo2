using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        //public string Sexo { get; set; }
        //public DateTime FechaNacimiento { get; set; }
        //public string Barrio { get; set; } para que sea completo el formulario
        //public string Partido { get; set; }
        public override string ToString()
        {
            return Apellido;
        }
    }
}
