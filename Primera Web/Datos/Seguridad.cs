using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Datos
{
    public static class Seguridad
    {
        public static bool Validar(object user)
        {
            Usuario usuario = user != null ? (Usuario)user : null;
            if (usuario != null && usuario.Id != 0)
                return true;
            else
                return false;
        }
        public static bool ValidarAdmin(object admin)
        {
            Usuario usuario = admin != null ? (Usuario)admin : null;
            return usuario != null ? usuario.TipoUsuario : false;
        }
    }
}
