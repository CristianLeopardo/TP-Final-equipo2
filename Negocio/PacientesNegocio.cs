using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                datos.SetearConsulta("select ID, Nombre, Apellido from Pacientes");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Paciente obj = new Paciente();
                    obj.ID = (int)datos.Lector["ID"];

                    //obj.nombre = new Persona();
                    //obj.nombre.Nombre= (string)datos.Lector["Nombre"];

                    //obj.apellido = new Persona();
                    //obj.apellido.Apellido = (string)datos.Lector["Apellido"];


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
    }
}
