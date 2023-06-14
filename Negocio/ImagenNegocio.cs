using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Reflection;
using System.Globalization;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listarimagenes(int a = 0)
        {
            List<Imagen> lista = new List<Imagen>();
            Conexion datos = new Conexion();
            try
            {
                if (a == 0)
                {
                    datos.SetearConsulta("select i.id as Identificacion, a.Id, i.ImagenUrl from ARTICULOS a left join IMAGENES i on i.IdArticulo = a.Id");
                }
                else
                {
                    datos.SetearConsulta("select i.id, a.Id, i.ImagenUrl from ARTICULOS a inner join IMAGENES i on i.IdArticulo = a.Id where a.Id = @a");
                    datos.setearParametro("@a", a);
                }

                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Imagen obj = new Imagen();
                    obj.Idarticulo = (int)datos.Lector["Id"];
                    obj.Id = (int)datos.Lector["id"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        obj.URLImagen = (string)datos.Lector["ImagenUrl"];
                    else
                        obj.URLImagen = "";

                    
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



        public void Agregar(Imagen nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@Id, @URL)");
                datos.setearParametro("@Id", nuevo.Id);
                datos.setearParametro("@URL", nuevo.URLImagen);
                datos.ejecutarAccion();
                datos.Cerraconexion();

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
        public void Eliminar(int a)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.setearParametro("@Id", a);
                datos.SetearConsulta("delete from IMAGENES where Id = @Id");
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
        public void Modificar(Imagen modif)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update IMAGENES set ImagenUrl = @URL  where Id = @Id");
                datos.setearParametro("@URL", modif.URLImagen);
                datos.setearParametro("@Id", modif.Id);
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
