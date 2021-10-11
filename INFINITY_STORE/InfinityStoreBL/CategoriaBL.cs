using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityStore.BL
{
    public class CategoriaBL
    {
        Contexto _contexto;
        public List<Categoria> ListadeCategoria { get; set; }

        public CategoriaBL()
        {
            _contexto = new Contexto();

            ListadeCategoria = new List<Categoria>();
        }

        public List<Categoria> ObtenerCategorias()
        {

            ListadeCategoria=_contexto.Categorias.ToList();
            return ListadeCategoria;
        }

        public void GuardarCategoria(Categoria categoria)
        {
            if (categoria.Id== 0)
            {
                _contexto.Categorias.Add(categoria);
            }
            else
            {
                var CategoriaExistente = _contexto.Categorias.Find(categoria.Id);
                CategoriaExistente.Descripcion = categoria.Descripcion;
            }

            _contexto.SaveChanges();
        }

        public Categoria ObtenerCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);

            return categoria;
        }

        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);

            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }

    }
}
