using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Datos
{
    public class UsuarioDatos
    {
        private AccesoDatos datos = new AccesoDatos();
        public int registrar(Usuario nuevo)
        {
            try
            {
                datos.ConsultarSP("NuevoUsuario");
                datos.SetearParametros("@correo", nuevo.User);
                datos.SetearParametros("@contra", nuevo.Pass);
                return datos.InsertarDatosScaler();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public bool loguear(Usuario usuario)
        {
            try
            {
                datos.Consultar("Select Id, TipoUsuario from USUARIOS where Correo = @user AND Contraseña = @pass");
                datos.SetearParametros("@user", usuario.User);
                datos.SetearParametros("@pass", usuario.Pass);
                datos.LeerDatos();
                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.TipoUsuario = (bool)datos.Lector["TipoUsuario"];
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
                datos.CerrarConexion();
            }   
        }
        public void verificar(Usuario usuario)
        {
            
        }
    }
}
