using InfinityStore.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfinityStore.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productoBL = new ProductosBL();

            var listadeProducto = productoBL.ObtenerProductosActivos();

            ViewBag.adminWebSiteUrl = ConfigurationManager.AppSettings["adminWebSiteUrl"];
            return View(listadeProducto);
        }
    }
}