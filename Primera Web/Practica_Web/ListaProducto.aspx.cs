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
    public partial class ListaProducto : System.Web.UI.Page
    {
        public bool FiltroAvz { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            FiltroAvz = chkFiltroAvanzado.Checked;
            if (!IsPostBack)
            {
                ArticuloDatos datos = new ArticuloDatos();
                Session.Add("ListaArt", datos.listarSP());
                gvProductos.DataSource = Session["ListaArt"];
                gvProductos.DataBind();
            }
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvProductos.SelectedDataKey.Value.ToString();
            Response.Redirect("Formulario.aspx?Id=" + id, false);
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                List<Articulo> listaFiltrada = ((List<Articulo>)Session["ListaArt"]).FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                gvProductos.DataSource = listaFiltrada;
                gvProductos.DataBind();
            }
            else
            {
                gvProductos.DataSource = Session["ListaArt"];
                gvProductos.DataBind();
            }
            //gvProductos.DataSource = null;
            //gvProductos.DataSource = Session["ListaArt"];
            //gvProductos.DataBind();
        }
        protected void chkFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro.Enabled = !FiltroAvz;
        }
        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterio.Items.Clear();
            if (ddlCampo.SelectedItem.ToString() == "Precio")
            {
                ddlCriterio.Items.Add("Igual a...");
                ddlCriterio.Items.Add("Mayor a...");
                ddlCriterio.Items.Add("Menor a...");
            }
            else
            {
                ddlCriterio.Items.Add("Contiene...");
                ddlCriterio.Items.Add("Empieza con...");
                ddlCriterio.Items.Add("Termina con...");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloDatos datos = new ArticuloDatos();               
                gvProductos.DataSource = datos.filtar(ddlCampo.Text.ToString(), ddlCriterio.Text.ToString(), txtReferencia.Text);
                gvProductos.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
    }
}