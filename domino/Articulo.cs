using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domino
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Marcas Marca { get; set; }
        public Categorias Categoria { get; set; }
        public Imagenes UrlImagen { get; set; }
        public List<Imagenes> UrlImagenes { get; set; } = new List<Imagenes>();

    }
}
