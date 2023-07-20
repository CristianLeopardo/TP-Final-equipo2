﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> ListarTurnos()
        {
            List<Turno> lista = new List<Turno>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select T.ID, T.IDPaciente, T.IDMedico, T.IDEspecialidad, T.Fecha, T.Estado, P.Nombre as NombreP, P.Apellido as ApellidoP, M.Nombre as NombreM, M.Apellido as ApellidoM, E.Nombre as NombreE from Turnos T inner join Pacientes P on P.ID = T.IDPaciente inner join Medicos M on M.ID = T.IDMedico inner join Especialidad E on E.ID = T.IDEspecialidad");
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Turno obj = new Turno();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.IDPaciente = (int)datos.Lector["IDPaciente"];
                    obj.IDMedico = (int)datos.Lector["IDMedico"];
                    obj.IDEspecialidad = (int)datos.Lector["IDEspecialidad"];
                    obj.Fecha = (DateTime)datos.Lector["Fecha"];
                    //obj.Estado = (int)datos.Lector["Estado"];
                    obj.NombrePaciente = (string)datos.Lector["NombreP"] + " " + (string)datos.Lector["ApellidoP"];
                    obj.NombreMedico = (string)datos.Lector["NombreM"] + " " + (string)datos.Lector["ApellidoM"];
                    obj.NombreEspecialidad = (string)datos.Lector["NombreE"];
                    int Estado = (int)datos.Lector["Estado"];
                    switch (Estado)
                    {
                        case 1:
                            obj.Estado = Dominio.estado.Activo;
                            break;
                        case 2:
                            obj.Estado = Dominio.estado.Cancelado;
                            break;
                        case 3:
                            obj.Estado = Dominio.estado.Reprogramado;
                            break;
                        case 4:
                            obj.Estado = Dominio.estado.Ausente;
                            break;
                        default:
                            break;
                    }
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

        public List<Turno> buscarporCriterio(string campo, string criterio, int idmedico)
        {
            Conexion datos = new Conexion();
            List<Turno> listafiltrada = new List<Turno>();
            try
            {
                datos.SetearConsulta("Select t.ID, t.Estado, t.Fecha, e.Nombre as Especialidad, p.Apellido, p.Nombre from Turnos t INNER JOIN Pacientes p on t.IDPaciente=p.ID INNER JOIN Especialidad e on e.ID=t.IDEspecialidad WHERE  p." + campo + " LIKE '" + criterio + "%' and t.IDMedico=" + idmedico);
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Turno obj = new Turno();
                    obj.ID = int.Parse(datos.Lector["ID"].ToString());
                    //obj.Estado = int.Parse(datos.Lector["Estado"].ToString());
                    obj.Fecha = DateTime.Parse(datos.Lector["Fecha"].ToString());
                    obj.NombreEspecialidad = datos.Lector["Especialidad"].ToString();
                    obj.NombrePaciente = datos.Lector["Apellido"].ToString() + " " + datos.Lector["Nombre"].ToString();
                    int Estado = (int)datos.Lector["Estado"];
                    switch (Estado)
                    {
                        case 1:
                            obj.Estado = Dominio.estado.Activo;
                            break;
                        case 2:
                            obj.Estado = Dominio.estado.Cancelado;
                            break;
                        case 3:
                            obj.Estado = Dominio.estado.Reprogramado;
                            break;
                        case 4:
                            obj.Estado = Dominio.estado.Ausente;
                            break;
                        default:
                            break;
                    }

                    listafiltrada.Add(obj);
                }

                return listafiltrada;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Turno> BuscarTurnosHoy(string dia, string mes, string anio, int idmedico)
        {
            Conexion datos = new Conexion();
            List<Turno> Lista = new List<Turno>();
            try
            {
                datos.SetearConsulta("Select t.ID, t.Estado, t.Fecha, e.Nombre as Especialidad, p.Apellido, p.Nombre from Turnos t INNER JOIN Especialidad e on t.IDEspecialidad=e.ID INNER JOIN Pacientes p ON t.IDPaciente=p.ID WHERE YEAR(Fecha)=" + anio + " AND MONTH(Fecha)=" + mes + " AND DAY(Fecha)=" + dia + " AND t.IDMedico=" + idmedico + " ORDER BY Fecha asc");
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Turno obj = new Turno();
                    obj.ID = int.Parse(datos.Lector["ID"].ToString());
                    //obj.Estado = int.Parse(datos.Lector["Estado"].ToString());
                    obj.Fecha = DateTime.Parse(datos.Lector["Fecha"].ToString());
                    obj.NombreEspecialidad = datos.Lector["Especialidad"].ToString();
                    obj.NombrePaciente = datos.Lector["Apellido"].ToString() + " " + datos.Lector["Nombre"].ToString();
                    int Estado = (int)datos.Lector["Estado"];
                    switch (Estado)
                    {
                        case 1:
                            obj.Estado = Dominio.estado.Activo;
                            break;
                        case 2:
                            obj.Estado = Dominio.estado.Cancelado;
                            break;
                        case 3:
                            obj.Estado = Dominio.estado.Reprogramado;
                            break;
                        case 4:
                            obj.Estado = Dominio.estado.Ausente;
                            break;
                        default:
                            break;
                    }

                    Lista.Add(obj);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Turno BuscarTurno(int id)
        {
            Turno obj = new Turno();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Fecha, IDPaciente, IDMedico, IDEspecialidad, Estado from Turnos where ID =" + id);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {

                    obj.ID = (int)datos.Lector["ID"];
                    obj.IDPaciente = (int)datos.Lector["IDPaciente"];
                    obj.IDMedico = (int)datos.Lector["IDMedico"];
                    obj.IDEspecialidad = (int)datos.Lector["IDEspecialidad"];
                    obj.Fecha = (DateTime)datos.Lector["Fecha"];
                    int Estado = (int)datos.Lector["Estado"];
                    switch (Estado)
                    {
                        case 1:
                            obj.Estado = Dominio.estado.Activo;
                            break;
                        case 2:
                            obj.Estado = Dominio.estado.Cancelado;
                            break;
                        case 3:
                            obj.Estado = Dominio.estado.Reprogramado;
                            break;
                        case 4:
                            obj.Estado = Dominio.estado.Ausente;
                            break;
                        default:
                            break;
                    }
                    //obj.Estado = (int)datos.Lector["Estado"];
                    //obj.NombrePaciente = (string)datos.Lector["NombreP"] + " " + (string)datos.Lector["ApellidoP"];
                    //obj.NombreMedico = (string)datos.Lector["NombreM"] + " " + (string)datos.Lector["ApellidoM"];
                    //obj.NombreEspecialidad = (string)datos.Lector["NombreE"];

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
        public List<Turno> BuscarHorario(int IDMedico, int IDEspecialidad, int IDPaciente, string Fecha)
        {
            List<Turno> lista = new List<Turno>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID,Fecha from Turnos where convert(date, Fecha) = '" + Fecha + "' and  IDMedico = @IDMedico and IDEspecialidad = @IDEspecialidad or (convert(date, Fecha) = '" + Fecha + "' and IDPaciente = @IDPaciente) and Estado = 1");
                datos.setearParametro("@Fecha", Fecha);
                datos.setearParametro("@IDEspecialidad", IDEspecialidad);
                datos.setearParametro("@IDMedico", IDMedico);
                datos.setearParametro("@IDPaciente", IDPaciente);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Turno obj = new Turno();
                    obj.Fecha = (DateTime)datos.Lector["Fecha"];
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

        public bool PoseeMismoTurno(int iDEspecialidad, int iDPaciente)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select ID, Fecha, IDPaciente, IDMedico, IDEspecialidad, Estado from Turnos where IDEspecialidad ="+ iDEspecialidad +"  AND IDPaciente= "+iDPaciente+" and Estado=1");
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    return true;
                }
                return false;
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

        public void AgregarTurno(Turno nuevo)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("insert into Turnos (IDPaciente, IDMedico, IDEspecialidad, Fecha, Estado) values (@IDPaciente, @IDMedico, @IDEspecialidad, @Fecha, @Estado)");
                datos.setearParametro("@IDPaciente", nuevo.IDPaciente);
                datos.setearParametro("@IDMedico", nuevo.IDMedico);
                datos.setearParametro("@IDEspecialidad", nuevo.IDEspecialidad);
                datos.setearParametro("@Fecha", nuevo.Fecha);
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
        public List<Turno> listadgv(int idmedico)
        {
            Conexion datos = new Conexion();
            List<Turno> lista = new List<Turno>();
            try
            {
                datos.SetearConsulta("Select T.ID, t.Estado, t.Fecha, e.Nombre as Especialidad, p.Apellido, p.Nombre from Turnos t INNER JOIN Especialidad e on t.IDEspecialidad=e.ID inner join Pacientes p on t.IDPaciente=p.ID WHERE t.IDMedico=" + idmedico);
                datos.Ejecutarconsulta();

                while (datos.Lector.Read())
                {
                    Turno obj = new Turno();
                    obj.ID = int.Parse(datos.Lector["ID"].ToString());
                    //obj.Estado = int.Parse(datos.Lector["Estado"].ToString());
                    obj.Fecha = DateTime.Parse(datos.Lector["Fecha"].ToString());
                    obj.NombreEspecialidad = datos.Lector["Especialidad"].ToString();
                    obj.NombrePaciente = datos.Lector["Apellido"].ToString() + " " + datos.Lector["Nombre"].ToString();
                    int Estado = (int)datos.Lector["Estado"];
                    switch (Estado)
                    {
                        case 1:
                            obj.Estado = Dominio.estado.Activo;
                            break;
                        case 2:
                            obj.Estado = Dominio.estado.Cancelado;
                            break;
                        case 3:
                            obj.Estado = Dominio.estado.Reprogramado;
                            break;
                        case 4:
                            obj.Estado = Dominio.estado.Ausente;
                            break;
                        default:
                            break;
                    }

                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Modificarturno(int iD, int estado)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("UPDATE Turnos set Estado=" + estado + " where ID=" + iD);
                datos.Ejecutarconsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Turno> ListarTurnos(int idPaciente)
        {
            List<Turno> lista = new List<Turno>();
            Conexion datos = new Conexion();
            try
            {
                datos.SetearConsulta("select T.ID, T.IDPaciente, T.IDMedico, T.IDEspecialidad, T.Fecha, T.Estado, P.Nombre as NombreP, P.Apellido as ApellidoP, M.Nombre as NombreM, M.Apellido as ApellidoM, E.Nombre as NombreE from Turnos T inner join Pacientes P on P.ID = T.IDPaciente inner join Medicos M on M.ID = T.IDMedico inner join Especialidad E on E.ID = T.IDEspecialidad where P.ID =" + idPaciente);
                datos.Ejecutarconsulta();
                while (datos.Lector.Read())
                {
                    Turno obj = new Turno();
                    obj.ID = (int)datos.Lector["ID"];
                    obj.IDPaciente = (int)datos.Lector["IDPaciente"];
                    obj.IDMedico = (int)datos.Lector["IDMedico"];
                    obj.IDEspecialidad = (int)datos.Lector["IDEspecialidad"];
                    obj.Fecha = (DateTime)datos.Lector["Fecha"];
                    //obj.Estado = (int)datos.Lector["Estado"];
                    obj.NombrePaciente = (string)datos.Lector["NombreP"] + " " + (string)datos.Lector["ApellidoP"];
                    obj.NombreMedico = (string)datos.Lector["NombreM"] + " " + (string)datos.Lector["ApellidoM"];
                    obj.NombreEspecialidad = (string)datos.Lector["NombreE"];
                    int Estado = (int)datos.Lector["Estado"];
                    switch (Estado)
                    {
                        case 1:
                            obj.Estado = Dominio.estado.Activo;
                            break;
                        case 2:
                            obj.Estado = Dominio.estado.Cancelado;
                            break;
                        case 3:
                            obj.Estado = Dominio.estado.Reprogramado;
                            break;
                        case 4:
                            obj.Estado = Dominio.estado.Ausente;
                            break;
                        default:
                            break;
                    }
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
    }
}
