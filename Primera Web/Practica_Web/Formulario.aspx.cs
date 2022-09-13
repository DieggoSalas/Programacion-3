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
    public partial class Formulario : System.Web.UI.Page
    {
        public bool confEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            confEliminacion = false;
            MarcaDatos marca = new MarcaDatos();            
            CategoriaDatos categoria = new CategoriaDatos();
            try
            {
                if (!IsPostBack)
                {
                    ddlMarca.DataSource = marca.listar();
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataBind();
                    ddlCategoria.DataSource = categoria.listar();
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataTextField = "Descripcion";
                    ddlCategoria.DataBind();
                }
                string id = Request.QueryString["Id"] != null ? Request.QueryString["Id"].ToString() : "";
                if (id != "" && !IsPostBack)
                {
                    ArticuloDatos datos = new ArticuloDatos();
                    Articulo seleccionado = (datos.listar(id))[0];
                    txtId.Text = seleccionado.Id.ToString();
                    txtCodigo.Text = seleccionado.Codigo;
                    txtNombre.Text = seleccionado.Nombre;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    ddlMarca.SelectedValue = seleccionado.Marca.Id.ToString();
                    ddlCategoria.SelectedValue = seleccionado.Categoria.Id.ToString();
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtImagen.Text = seleccionado.ImagenUrl;
                    txtImagen_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {
            imgUrl.ImageUrl = txtImagen.Text;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloDatos datos = new ArticuloDatos();
                Articulo art = new Articulo();
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Marca = new Marca();
                art.Marca.Id = int.Parse(ddlMarca.SelectedValue);
                art.Categoria = new Categoria();
                art.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                art.Precio = decimal.Parse(txtPrecio.Text);
                art.ImagenUrl = txtImagen.Text;
                if (Request.QueryString["Id"] != null)
                {
                    art.Id = int.Parse(txtId.Text);
                    datos.modificar(art);
                }
                else
                    datos.agregar(art);
                Response.Redirect("ListaProducto.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confEliminacion = true;
        }

        protected void btnConfirmarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChbxConfirmarEliminar.Checked)
                {
                    ArticuloDatos datos = new ArticuloDatos();
                    datos.eliminar(int.Parse(txtId.Text));
                    Response.Redirect("ListaProducto.aspx", false);
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