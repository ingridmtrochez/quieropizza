
using InfinityStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfinityStore.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var productoBL = new ProductosBL();

            var listadeProducto = productoBL.ObtenerProductos();

            return View(listadeProducto);
        }
    }
}