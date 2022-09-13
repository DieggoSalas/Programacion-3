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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                UsuarioDatos datos = new UsuarioDatos();
                usuario.User = txtCorreo.Text;
                usuario.Pass = txtContra.Text;
                if (Seguridad.Validar(Session["Logueado"]))
                {
                    datos.loguear(usuario);
                    Session.Add("Logueado", usuario);
                    Response.Redirect("Default.aspx", false);
                }
                else
                {
                    usuario.Id = datos.registrar(usuario);
                    Session.Add("Logueado", usuario);
                    Response.Redirect("Default.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}