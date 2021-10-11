
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityStore.BL
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Categoria  Categoria { get; set; }
        public int Existencia{ get; set; }
        public bool Activo { get; set; }


        public Producto()
        {
            Activo = true;
        }
    }
}
