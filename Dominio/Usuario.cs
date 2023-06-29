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
        Paciente = 1,
        Medico = 2,
        Recepcion = 3,
        Admin = 4
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
