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
                conexion.setearParametro("@Email", usuario.Email);
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
    }
}
