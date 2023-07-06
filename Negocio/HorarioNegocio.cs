using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class HorarioNegocio
    {
        public void Agregar(Horario nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("insert into Horarios (IDMedico, IDHoraInicio, Fecha, Estado) values (@idMedico, @idHora, @Fecha, 1)");
                datos.setearParametro("@idMedico", nuevo.Medico.ID);
                datos.setearParametro("@idHora", nuevo.Hora.idHora);
                datos.setearParametro("@Fecha", nuevo.Fecha);
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

        public Hora BuscarHora(string horario)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("SELECT IdHora, Hora FROM Hora WHERE Hora = @Hora");
                datos.setearParametro("@Hora", horario);
                datos.Ejecutarconsulta();

                if (datos.Lector.Read())
                {
                    Hora hora = new Hora();
                    hora.idHora = (int)datos.Lector["IdHora"];
                    hora.Horario = (string)datos.Lector["Hora"];
                    return hora;
                }
                else
                {
                    return null;
                }
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
        public List<Horario> listaparaturno(int idmedico)
        {
            Conexion datos = new Conexion();
            List<Horario> listafiltrada = new List<Horario>();
            try
            {
                datos.SetearConsulta("SELECT hs.Fecha as Fecha, h.Hora as Hora FROM Horarios hs INNER JOIN Hora h on hs.IDHorario=h.IDHora WHERE hs.IDMedico = " + idmedico);
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Horario obj = new Horario();
                    obj.Fecha = (DateTime)datos.Lector["Fecha"];
                    obj.Hora.Horario = ((Hora)datos.Lector["Hora"]).ToString();

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
    }
}
