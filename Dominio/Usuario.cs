using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoUsuario
    {
        Cliente = 4,
        Medico = 3,
        Recepcion = 2,
        Admin = 1
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
