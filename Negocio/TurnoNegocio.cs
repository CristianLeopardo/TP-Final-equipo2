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
                    obj.Estado = (int)datos.Lector["Estado"];
                    obj.NombrePaciente = (string)datos.Lector["NombreP"] + " " + (string)datos.Lector["ApellidoP"];
                    obj.NombreMedico = (string)datos.Lector["NombreM"] + " " + (string)datos.Lector["ApellidoM"];
                    obj.NombreEspecialidad = (string)datos.Lector["NombreE"];
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
