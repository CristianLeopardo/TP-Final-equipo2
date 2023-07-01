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
        public List<Medico> ListarMedicos()
        {
            List<Medico> lista = new List<Medico>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("Select ID, Nombre, Apellido, Sexo, DNI, Telefono, Celular, Email, FechaIngreso, FechaNacimiento, Estado from Medicos");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Medico obj = new Medico();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];
                    obj.Sexo = (string)datos.Lector["Sexo"];
                    obj.Dni = (int)datos.Lector["DNI"];
                    obj.Telefono = (int)datos.Lector["Telefono"];
                    obj.Celular = (int)datos.Lector["Celular"];
                    obj.Email = (string)datos.Lector["Email"];
                    obj.fechaingreso = (DateTime)datos.Lector["FechaIngreso"];
                    obj.fechanacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    obj.Estado = (bool)datos.Lector["Estado"];
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
        public List<Medico> ListarMedicosActivos()
        {
            List<Medico> lista = new List<Medico>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("Select ID, Nombre, Apellido, Sexo, DNI, Telefono, Celular, Email, FechaIngreso, FechaNacimiento, Estado from Medicos where Estado = 1");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Medico obj = new Medico();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];
                    obj.Sexo = (string)datos.Lector["Sexo"];
                    obj.Dni = (int)datos.Lector["DNI"];
                    obj.Telefono = (int)datos.Lector["Telefono"];
                    obj.Celular = (int)datos.Lector["Celular"];
                    obj.Email = (string)datos.Lector["Email"];
                    obj.fechaingreso = (DateTime)datos.Lector["FechaIngreso"];
                    obj.fechanacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    obj.Estado = (bool)datos.Lector["Estado"];
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

        public List<Medico> BuscarMedico(int id)
        {
            List<Medico> lista = new List<Medico>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("Select ID, Nombre, Apellido, Sexo, DNI, Telefono, Celular, Email, FechaIngreso, FechaNacimiento, Estado from Medicos where ID = " + id);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Medico obj = new Medico();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];
                    obj.Sexo = (string)datos.Lector["Sexo"];
                    obj.Dni = (int)datos.Lector["DNI"];
                    obj.Telefono = (int)datos.Lector["Telefono"];
                    obj.Celular = (int)datos.Lector["Celular"];
                    obj.Email = (string)datos.Lector["Email"];
                    obj.fechaingreso = (DateTime)datos.Lector["FechaIngreso"];
                    obj.fechanacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    obj.Estado = (bool)datos.Lector["Estado"];
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
        public void Modificar(Medico nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update Medicos set Nombre = @Nombre, Apellido = @Apellido, Sexo = @Sexo, DNI = @DNI, Telefono = @Telefono, Celular = @Celular, Email = @Email, FechaIngreso = @FechaIngreso, FechaNacimiento = @FechaNacimiento, Estado = 1 where ID = @ID");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Sexo", nuevo.Sexo);
                datos.setearParametro("@DNI", nuevo.Dni);
                datos.setearParametro("@Telefono", nuevo.Telefono);
                datos.setearParametro("@Celular", nuevo.Celular);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@FechaIngreso", nuevo.fechaingreso);
                datos.setearParametro("@FechaNacimiento", nuevo.fechanacimiento);
                datos.setearParametro("@ID", nuevo.ID);
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

        public void Eliminar(int id)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update Medicos set Estado = 0 where ID =" + id);
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
