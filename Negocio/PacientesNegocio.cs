using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PacientesNegocio
    {
        public List<Pacientes> ListarPacientes()
        {
            List<Pacientes> lista = new List<Pacientes>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Nombre, Apellido from Pacientes");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Pacientes obj = new Pacientes();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];

                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.Cerraconexion();
            }
        }
    }
}
