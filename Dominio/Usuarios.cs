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
        Cliente = 1,
        Medico = 2,
        Recepcion = 3,
        Admin = 4
    }

    public class Usuarios
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
