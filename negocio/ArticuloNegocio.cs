using datos;
using domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        private Datos datos;
        public ArticuloNegocio()
        {
            datos = new Datos();
        }

        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.SetearDatos("select A.Id, Codigo, Nombre, A.Descripcion, M.Id IdMarca, M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria, Precio, I.ImagenUrl UrlImagen from ARTICULOS A inner join MARCAS M on IdMarca = M.Id inner join CATEGORIAS C on A.IdCategoria = C.Id inner join IMAGENES I on A.Id = I.Id");
                datos.EjecutarDatos();

                while (datos.Reader.Read())
                {
                    Articulo art = new Articulo();

                    art.Id = (int)datos.Reader["Id"];
                    art.Codigo = (string)datos.Reader["Codigo"];
                    art.Nombre = (string)datos.Reader["Nombre"];
                    art.Descripcion = (string)datos.Reader["Descripcion"];
                    art.Precio = (decimal)datos.Reader["Precio"];

                    art.Marca = new Marcas();
                    art.Marca.Id = (int)datos.Reader["IdMarca"];
                    art.Marca.Descripcion = (string)datos.Reader["Marca"];

                    art.Categoria = new Categorias();
                    art.Categoria.Id = (int)datos.Reader["IdCategoria"];
                    art.Categoria.Descripcion = (string)datos.Reader["Categoria"];

                    if (!(datos.Reader["UrlImagen"] is DBNull))
                    {
                        art.UrlImagen = new Imagenes();
                        art.UrlImagen.UrlImagen = (string)datos.Reader["UrlImagen"];
                    }

                    lista.Add(art);
                }

                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
