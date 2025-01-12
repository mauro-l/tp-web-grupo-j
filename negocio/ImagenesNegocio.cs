using datos;
using domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    internal class ImagenesNegocio
    {
        public List<Imagenes> Listar(int id)
        {
            List<Imagenes> listaImagenes = new List<Imagenes>();
            Datos datos = new Datos();

            try
            {
                datos.SetearDatos("select Id, ImagenUrl from IMAGENES where IdArticulo = @idarticulo");
                datos.SetearParametros("@idarticulo", id);
                datos.EjecutarDatos();
                while (datos.Reader.Read())
                {
                    Imagenes img = new Imagenes();

                    img.Id = (int)datos.Reader["Id"];
                    img.UrlImagen = (string)datos.Reader["ImagenUrl"];
                    listaImagenes.Add(img);
                }
                return listaImagenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
