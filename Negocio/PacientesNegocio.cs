using Dominio;
using System;
using System.Collections.Generic;

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
                datos.SetearConsulta("select ID, Nombre, Apellido, Sexo, DNI, Telefono, Celular, Email, Domicilio, Localidad, Provincia, FechaNacimiento, Estado from Pacientes");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Paciente obj = new Paciente();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];
                    obj.Sexo = (string)datos.Lector["Sexo"];
                    obj.Dni = (int)datos.Lector["DNI"];
                    obj.Telefono = (int)datos.Lector["Telefono"];
                    obj.Celular = (int)datos.Lector["Celular"];
                    obj.Domicilio = (string)datos.Lector["Domicilio"];
                    obj.Localidad = (string)datos.Lector["Localidad"];
                    obj.Provincia = (string)datos.Lector["Provincia"];
                    obj.Email= (string)datos.Lector["Email"];
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

        public List<Paciente> BuscarPaciente(int id)


        {
            List<Paciente> lista = new List<Paciente>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Nombre, Apellido, Sexo, DNI, Telefono, Celular, Email, Domicilio, Localidad, Provincia, FechaNacimiento, Estado from Pacientes where ID =" + id);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Paciente obj = new Paciente();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];
                    obj.Sexo = (string)datos.Lector["Sexo"];
                    obj.Dni = (int)datos.Lector["DNI"];
                    obj.Telefono = (int)datos.Lector["Telefono"];
                    obj.Celular = (int)datos.Lector["Celular"];
                    obj.Domicilio = (string)datos.Lector["Domicilio"];
                    obj.Localidad = (string)datos.Lector["Localidad"];
                    obj.Provincia = (string)datos.Lector["Provincia"];
                    obj.Email = (string)datos.Lector["Email"];
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

        public void Eliminar(int id)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update Pacientes set Estado = 0 where ID =" + id);
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

        public void Modificar(Paciente nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update Pacientes set Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Sexo = @Sexo, Telefono = @Telefono, Celular = @Celular, Email = @Email, Domicilio = @Domicilio, Localidad = @Localidad, Provincia = @Provincia, FechaNacimiento = @FechaNacimiento where ID = @ID");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Sexo", nuevo.Sexo);
                datos.setearParametro("@DNI", nuevo.Dni);
                datos.setearParametro("@Telefono", nuevo.Telefono);
                datos.setearParametro("@Celular", nuevo.Celular);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@Domicilio", nuevo.Domicilio);
                datos.setearParametro("@Localidad", nuevo.Localidad);
                datos.setearParametro("@Provincia", nuevo.Provincia);
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

        public void Agregar(Paciente nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("insert into Pacientes (Apellido, Nombre, DNI, Sexo, Telefono, Celular, Email, Domicilio, Localidad, Provincia, FechaNacimiento) values (@Apellido, @Nombre, @DNI, @Sexo, @Telefono, @Celular, @Email, @Domicilio, @Localidad, @Provincia, @FechaNacimiento)");
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@DNI", nuevo.Dni);
                datos.setearParametro("@Sexo", nuevo.Sexo);
                datos.setearParametro("@Telefono", nuevo.Telefono);
                datos.setearParametro("@Celular", nuevo.Celular);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@Domicilio", nuevo.Domicilio);
                datos.setearParametro("@Localidad", nuevo.Localidad);
                datos.setearParametro("@Provincia", nuevo.Provincia);
                datos.setearParametro("@FechaNacimiento", nuevo.fechanacimiento);
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
        public int BuscarID(int dni)
        {
            Conexion datos = new Conexion();
            
            try
            {
                datos.SetearConsulta("SELECT id FROM Pacientes WHERE dni= @dni");
                datos.setearParametro("@dni",dni);

                return datos.ejecutarAccionScalar();
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
    }
}
