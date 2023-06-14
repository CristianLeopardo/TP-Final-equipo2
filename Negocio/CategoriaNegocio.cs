using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarMarcas()
        {
            List<Categoria> lista = new List<Categoria>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Categoria obj = new Categoria();
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
        public void AgregarCategoria(Categoria categoria)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.SetearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                conexion.setearParametro("@Descripcion", categoria.Descripcion);
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

        public void EliminarCat(int a)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.setearParametro("@Id", a);
                datos.SetearConsulta("delete from CATEGORIAS where Id = @Id");
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
        public void ModificarCat(Categoria nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update CATEGORIAS set Descripcion = @Desc where Id = @Id");
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
