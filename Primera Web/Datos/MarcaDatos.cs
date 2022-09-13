using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Datos
{
    public class MarcaDatos
    {
        List<Marca> lista = new List<Marca>();
        AccesoDatos datos = new AccesoDatos();
        public List<Marca> listar()
        {
            try
            {
                datos.ConsultarSP("ListarMarcas");
                datos.LeerDatos();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
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
        public void agregar(Marca nuevo)
        {
            try
            {
                datos.ConsultarSP("NuevaMarca");
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
