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
        public List<Especialidad> ListarEspecialidades()
        {
            List<Especialidad> lista = new List<Especialidad>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Nombre from Especialidad");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Especialidad obj = new Especialidad();
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
        public void cargarEspecialidades(int Idmedico, string Idespecialidad)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("insert into Medico_x_Especialidad (IdMedico, IDEspecialidad) VALUES (@Idmedico, @Idespecialidad)");
                datos.setearParametro("@Idmedico", Idmedico);
                datos.setearParametro("@Idespecialidad", Idespecialidad);
                datos.ejecutarAccion();
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
