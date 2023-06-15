using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EspecialidadesNegocio
    {
        public List<Especialidades> ListarEspecialidades()
        {
            List<Especialidades> lista = new List<Especialidades>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Nombre from Especialidad");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Especialidades obj = new Especialidades();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre= (string)datos.Lector["Nombre"];

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
