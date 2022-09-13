using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Clases;

namespace Practica_Web
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> articulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            articulos = datos.listarSP();
        }
    }
}