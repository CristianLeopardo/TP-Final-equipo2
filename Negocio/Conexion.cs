﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class Conexion
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public Conexion()
        {
<<<<<<< HEAD
            conexion = new SqlConnection("Server=.\\SQLEXPRESS; database=TP_FINAL; integrated security=true");
=======
            conexion = new SqlConnection("Server=.\\labo3; database=TP_FINAL; integrated security=true");
>>>>>>> 8765709ef85754fc4045c8c74cc66c19edacc596
            comando = new SqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void FiltrarBusqueda(string FBusqueda)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = FBusqueda;
        }

        public void Ejecutarconsulta()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ejecutarAccionScalar()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cerraconexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

    }
}
