

using InfinityStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfinityStore.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {

        CategoriaBL _categoriaBL;

        public CategoriasController()
        {
            _categoriaBL = new CategoriaBL();
        }
        // GET: Categorias
        public ActionResult Index()
        {

            var ListadeCategorias = _categoriaBL.ObtenerCategorias();
            return View(ListadeCategorias);
        }

        public ActionResult Crear()
        {
            var nuevoCategoria = new Categoria();


            return View(nuevoCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La descripcion no debe contener espacios al incio o al final");
                    return View(categoria);
                }
                _categoriaBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Editar(int id)
        {
            var categoria = _categoriaBL.ObtenerCategoria(id);
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La descripcion no debe contener espacios al incio o al final");
                    return View(categoria);
                }
                _categoriaBL.GuardarCategoria(categoria);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Detalle(int id)
        {
            var categoria = _categoriaBL.ObtenerCategoria(id);
            return View(categoria);
        }

        public ActionResult Eliminar(int id)
        {
            var categoria = _categoriaBL.ObtenerCategoria(id);

            return View(categoria);
        }

        [HttpPost]

        public ActionResult Eliminar(Categoria categoria)
        {
            _categoriaBL.EliminarCategoria(categoria.Id);


            return RedirectToAction("Index");
        }
    }
}