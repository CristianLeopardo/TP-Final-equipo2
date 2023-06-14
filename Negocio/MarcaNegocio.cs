using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select Id, Descripcion from MARCAS");
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Marca obj = new Marca();
                    obj.Id = (int)datos.Lector["Id"];
                    obj.Descripcion = (string)datos.Lector["Descripcion"];

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
        public void AgregarMarca(Marca marca)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.SetearConsulta("insert into MARCAS (Descripcion) values (@Descripcion)");
                conexion.setearParametro("@Descripcion", marca.Descripcion);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerraconexion();
            }
        }

        public void EliminarMarca(int a)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.setearParametro("@Id", a);
                datos.SetearConsulta("delete from MARCAS where Id = @Id");
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

        public void ModificarMarca(Marca nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update MARCAS set Descripcion = @Desc where Id = @Id");
                datos.setearParametro("@Id", nuevo.Id);
                datos.setearParametro("@Desc", nuevo.Descripcion);
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
