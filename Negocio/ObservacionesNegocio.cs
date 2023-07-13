using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ObservacionesNegocio
    {
        public List<Observaciones> BuscarObs (int IDturno)
        {
            Conexion datos = new Conexion();
            List<Observaciones> lista = new List<Observaciones>();
            try
            {
                datos.SetearConsulta("select ID ,IDTurno ,Observaciones from Observaciones where IDTurno="+IDturno);
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Observaciones obj = new Observaciones();
                    obj.Descripcion = datos.Lector["Observaciones"].ToString();
                    obj.ID = int.Parse(datos.Lector["ID"].ToString());
                    obj.IDTurno = int.Parse(datos.Lector["IDTurno"].ToString());
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.Cerraconexion();
            }
        }
        public void insertarObservacion(int idturno, String obs)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("Insert into Observaciones (IDTurno, Observaciones) VALUES ("+ idturno +",'"+ obs +"')");
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
