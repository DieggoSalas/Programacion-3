using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    //public enum TipoUsuario
    //{
    //    ADMIN = 1,
    //    NORMAL = 2
    //}
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Imagen { get; set; }
        public bool TipoUsuario { get; set; }
    }
}
