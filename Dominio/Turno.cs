using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int ID { get; set; }
        public Persona IDPaciente { get; set; }//Podriamos usar el DNI del paciente ya que seria unico
        public Medico IDMedico { get; set; }//Podriamos usar el Legajo del doc del paciente ya que seria unico
        public int IDEspecialidad { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
    }
}
