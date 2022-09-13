using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace Practica_Web
{
    public partial class GranMaestro : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page is Perfil || Page is Favorito)
            {
                if (!(Seguridad.Validar(Session["Logueado"])))
                {
                    Response.Redirect("Login.aspx", false);
                }
            }
            else if (Page is ListaProducto)
            {
                if (!(Seguridad.ValidarAdmin(Session["Logueado"])))
                {
                    Session.Add("Error", "Debe tener permisos de Administrador para continuar.");
                    Response.Redirect("Error.aspx", false);
                }
            }            
        }
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx", false);
        }
    }
}