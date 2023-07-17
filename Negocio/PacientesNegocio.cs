﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Net;

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
        public bool ValidarEmail(string Email)
        {
            List<Medico> lista = new List<Medico>();
            Conexion datos = new Conexion();
            bool encontre = false;
            try
            {
                datos.SetearConsulta("select ID, Nombre, Email from Pacientes where Email =  @Email");
                datos.setearParametro("@Email", Email);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    encontre = true;
                }
                if (encontre == true)
                {
                    return true;
                }
                else { return false; }
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


        public bool ValidarDNI(int DNI)
        {
            List<Medico> lista = new List<Medico>();
            Conexion datos = new Conexion();
            bool encontre = false;
            try
            {
                datos.SetearConsulta("select ID, Nombre, Apellido from Pacientes where dni = " + DNI);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    encontre = true;
                }
                if (encontre == true)
                {
                    return true;
                }
                else { return false; }
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
                datos.SetearConsulta("update Pacientes set Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Sexo = @Sexo, Telefono = @Telefono, Celular = @Celular, Email = @Email, Domicilio = @Domicilio, Localidad = @Localidad, Provincia = @Provincia, FechaNacimiento = @FechaNacimiento, Estado = @Estado where ID = @ID");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Apellido", nuevo.Apellido);
                datos.setearParametro("@Sexo", nuevo.Sexo);
                datos.setearParametro("@DNI", nuevo.Dni);
                datos.setearParametro("@Telefono", nuevo.Telefono);
                datos.setearParametro("@Celular", nuevo.Celular);
                datos.setearParametro("@Email", nuevo.Email.ToUpper());
                datos.setearParametro("@Domicilio", nuevo.Domicilio);
                datos.setearParametro("@Localidad", nuevo.Localidad);
                datos.setearParametro("@Provincia", nuevo.Provincia);
                datos.setearParametro("@FechaNacimiento", nuevo.fechanacimiento);
                datos.setearParametro("@ID", nuevo.ID);
                datos.setearParametro("@Estado", nuevo.Estado);
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
                datos.setearParametro("@Email", nuevo.Email.ToUpper());
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

                int valor = datos.ejecutarAccionScalar();
                if(valor != 0)
                {
                    return valor;
                }
                return -1;
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
        public List<Paciente> BuscarPacientexDNI(int DNI)
        {
            List<Paciente> lista = new List<Paciente>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Nombre, Apellido from Pacientes where dni = " + DNI);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Paciente obj = new Paciente();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];
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
        public Paciente BuscarPacientexDNI2(int DNI)
        {
            Paciente obj = new Paciente();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Nombre, Apellido from Pacientes where dni = " + DNI);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    obj.ID = (int)datos.Lector["ID"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Apellido = (string)datos.Lector["Apellido"];
                }
                return obj;
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
            public List<Paciente> BuscarPacienteCriterio(string campo, string dato)
        {
            List<Paciente> lista = new List<Paciente>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("Select ID, Nombre, Apellido, Sexo, DNI, Telefono, Celular, Email, FechaNacimiento, Domicilio, Localidad, Provincia, Estado from Pacientes where " + campo + " like '" + dato + "%'");
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
                    obj.Email = (string)datos.Lector["Email"];
                    obj.fechanacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    obj.Domicilio = (string)datos.Lector["Domicilio"];
                    obj.Localidad = (string)datos.Lector["Localidad"];
                    obj.Provincia = (string)datos.Lector["Provincia"];
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

        public Paciente BuscarIDxEmail(string email)
        {
            Conexion datos = new Conexion();
            Paciente obj = new Paciente();
            try
            {
                datos.SetearConsulta("SELECT ID,Nombre, Apellido, Sexo, DNI, Telefono, Celular, Domicilio, Localidad, Provincia, Email, FechaNacimiento, Estado FROM Pacientes WHERE Email= @Email");
                datos.setearParametro("@Email", email.ToUpper());
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
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
                }
                return obj;
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
