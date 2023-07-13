using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EspecialidadNegocio
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
        public List<EspecialidadMedico> ListarMedicos(int IDespecialidad)
        {
            List<EspecialidadMedico> lista = new List<EspecialidadMedico>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select E.IdMedico, E.IDEspecialidad,M.Nombre, M.Apellido from Medico_x_Especialidad E inner join Medicos M on E.IdMedico = M.ID where E.IDEspecialidad =" + IDespecialidad);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    EspecialidadMedico obj = new EspecialidadMedico();
                    obj.IDEspecialdiad = (int)datos.Lector["IDEspecialidad"];
                    obj.IDMedico = (int)datos.Lector["IdMedico"];
                    obj.NombreMedico = (string)datos.Lector["Nombre"] + " " +(string)datos.Lector["Apellido"];

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
        public List<EspecialidadMedico> ListarMedicosTurno(int IDespecialidad, string jornada)
        {
            List<EspecialidadMedico> lista = new List<EspecialidadMedico>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select E.IdMedico, E.IDEspecialidad,M.Nombre, M.Apellido, M.Jornada from Medico_x_Especialidad E inner join Medicos M on E.IdMedico = M.ID where E.IDEspecialidad = @IDespecialidad and M.Jornada = @jornada");
                datos.setearParametro("@jornada", jornada);
                datos.setearParametro("@IDespecialidad", IDespecialidad);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    EspecialidadMedico obj = new EspecialidadMedico();
                    obj.IDEspecialdiad = (int)datos.Lector["IDEspecialidad"];
                    obj.IDMedico = (int)datos.Lector["IdMedico"];
                    obj.NombreMedico = (string)datos.Lector["Nombre"] + " " + (string)datos.Lector["Apellido"];

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
        public List<EspecialidadMedico> ListarEspecialidadesMedico(int IDmedico)
        {
            List<EspecialidadMedico> lista = new List<EspecialidadMedico>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select M.IdMedico, M.IDEspecialidad, E.Nombre from Medico_x_Especialidad M inner join Especialidad E on M.IDEspecialidad = E.ID where M.IdMedico =" + IDmedico);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    EspecialidadMedico obj = new EspecialidadMedico();
                    obj.IDEspecialdiad = (int)datos.Lector["IDEspecialidad"];
                    obj.IDMedico = (int)datos.Lector["IdMedico"];
                    obj.NombreEspecialidad = (string)datos.Lector["Nombre"];

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

        public List<Medico> ListaFiltradaEspecialidades(int idEspecialdad, string jornada = null)
        {
            List<Medico> listafiltrada = new List<Medico>();
            Conexion datos = new Conexion();
            try
            {
                string continuacion = " ";
                if (jornada!=null)
                    continuacion = " AND m.Jornada='" + jornada + "'";
                datos.SetearConsulta("SELECT distinct m.ID ,m.Apellido, m.Nombre, m.sexo, m.DNI, m.Telefono, m.Celular, m.Email, m.FechaIngreso, m.FechaNacimiento, m.Jornada, m.Estado from Medicos m INNER JOIN Medico_x_Especialidad me on m.ID=me.IdMedico WHERE me.IDEspecialidad=" + idEspecialdad + continuacion);
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
                    obj.JornadaLaboral = datos.Lector["Jornada"].ToString();
                    obj.Estado = (bool)datos.Lector["Estado"];
                    listafiltrada.Add(obj);
                }
                return listafiltrada;
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

        public void AsignarEspecialidad(int Idmedico, int Idespecialidad)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("insert into Medico_x_Especialidad(IdMedico, IDEspecialidad) VALUES (@IdMedico, @IDEspecialidad)");
                datos.setearParametro("@IdMedico", Idmedico); 
                datos.setearParametro("@IDEspecialidad", Idespecialidad);
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

        public void DesasignarEspecialidad(int Idmedico, int Idespecialidad)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("delete from Medico_x_Especialidad where IdMedico = @IdMedico and IDEspecialidad = @IDEspecialidad");
                datos.setearParametro("@IdMedico", Idmedico);
                datos.setearParametro("@IDEspecialidad", Idespecialidad);
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

        public void AgregarEspecialidad(string nombre)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("insert into Especialidad (Nombre) VALUES (@Nombre)");
                datos.setearParametro("@Nombre", nombre);
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

        public void EliminarEspecialidad(int id)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("delete from Especialidad where ID=@ID");
                datos.setearParametro("@ID", id);
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
        
        public void ModificarEspecialidad(int id, string nombre) 
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("update Especialidad set Nombre = @Nombre where ID = @ID");
                datos.setearParametro("@Nombre", nombre);
                datos.setearParametro("@ID", id);
                
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
