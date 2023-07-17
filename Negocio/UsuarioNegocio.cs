using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool Login(Usuario usuario)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.SetearConsulta("select ID, TipoUsuario from Usuarios where Usuario = @user AND Clave = @pass");
                conexion.setearParametro("@user", usuario.User);
                conexion.setearParametro("@pass", usuario.Clave);

                conexion.Ejecutarconsulta();
                while (conexion.Lector.Read())
                {
                    usuario.Id = (int)conexion.Lector["ID"];
                    int TipoUsuario = (int)conexion.Lector["TipoUsuario"];
                    switch (TipoUsuario)
                    {
                        case 1:
                            usuario.TipoUsuario = Dominio.TipoUsuario.Admin;
                            break;
                        case 2:
                            usuario.TipoUsuario = Dominio.TipoUsuario.Recepcion;
                            break;
                        case 3:
                            usuario.TipoUsuario = Dominio.TipoUsuario.Medico;
                            break;
                        case 4:
                            usuario.TipoUsuario = Dominio.TipoUsuario.Paciente;
                            break;
                        default:
                            break;
                    }
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
                conexion.Cerraconexion();
            }
        }
        public void Agregar(Usuario usuario)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.SetearConsulta("insert into Usuarios (Usuario, Clave, Email, TipoUsuario) VALUES (@Usuario, @Clave, @Email, @TipoUsuario)");
                conexion.setearParametro("@Usuario", usuario.User);
                conexion.setearParametro("@Clave", usuario.Clave);
                conexion.setearParametro("@Email", usuario.Email.ToUpper());
                conexion.setearParametro("@TipoUsuario", usuario.TipoUsuario);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Cerraconexion();
            }
        }

        public string BuscarCorreo(string email)
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.SetearConsulta("select Email, Clave from Usuarios where Email = @Email");
                conexion.setearParametro("@Email", email);
                conexion.Ejecutarconsulta();
                while (conexion.Lector.Read())
                {
                    string aux = (string)conexion.Lector["Email"];
                    if (aux == email)
                    {
                        return (string)conexion.Lector["Clave"];
                    }
                }
                return "";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Cerraconexion();
            }
        }

        public string BuscarEmail(string usuario)
        {
            string email = "";
            Conexion conexion = new Conexion();
            conexion.SetearConsulta("select ID, Email, TipoUsuario from Usuarios where Usuario = @user");
            conexion.setearParametro("@user", usuario);
            conexion.Ejecutarconsulta();
            while (conexion.Lector.Read())
                {
                email = (string)conexion.Lector["Email"];
            }     
            return email;
        }

    }
}
