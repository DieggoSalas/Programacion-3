using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Datos
{
    public class CategoriaDatos
    {
        List<Categoria> lista = new List<Categoria>();
        AccesoDatos datos = new AccesoDatos();
        public List<Categoria> listar()
        {            
            try
            {
                datos.ConsultarSP("ListarCategorias");
                datos.LeerDatos();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
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
        public void agregar(Categoria nuevo)
        {
            try
            {
                datos.ConsultarSP("NuevaCategoria");
                datos.SetearParametros("@Descripcion", nuevo.Descripcion);
                datos.InsertarDatos();
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
        public void eliminar(int id)
        {
            try
            {
                datos.ConsultarSP("EliminarMarca");
                datos.SetearParametros("@Id", id);
                datos.InsertarDatos();
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
    }
}
