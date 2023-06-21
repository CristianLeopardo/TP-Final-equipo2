using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MedicoNegocio
    {
        public void Agregar(Medico nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("insert into Medicos (Apellido, Nombre, DNI, Sexo, Telefono, Celular, Email, FechaIngreso, FechaNacimiento) values (@Apellido, @Nombre, @DNI, @Sexo, @Telefono, @Celular, @Email, @FechaIngreso, @FechaNacimiento)");
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@DNI", nuevo.Dni);
                datos.setearParametro("@Sexo", nuevo.Sexo);
                datos.setearParametro("@Telefono", nuevo.Telefono);
                datos.setearParametro("@Celular", nuevo.Celular);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@FechaNacimiento", nuevo.fechanacimiento);
                datos.setearParametro("@FechaIngreso", nuevo.fechaingreso);
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
        public int UltimoIngreso()
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("SELECT top 1 ID FROM Medicos ORDER BY ID DESC");
                return datos.ejecutarAccionScalar();
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
