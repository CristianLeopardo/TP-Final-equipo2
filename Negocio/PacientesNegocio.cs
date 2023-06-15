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
        public List<Paciente> ListarPacientes()
        {

            List<Paciente> lista = new List<Paciente>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Nombre, Apellido from Pacientes");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Paciente obj = new Paciente();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.nombre.Nombre= (string)datos.Lector["Nombre"];
                    obj.apellido.Apellido = (string)datos.Lector["Apellido"];

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
