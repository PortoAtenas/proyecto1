using proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto1.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            List<ProductoCLS> listaProducto = null;

            using (var bd = new proyectoSEntities1())
            {
                listaProducto = (from product in bd.Producto
                                 select new ProductoCLS { 
                                    iidProducto = product.idProducto,
                                    nombreP = product.nombresP,
                                    precio = (double)product.precio,
                                    coste = (double)product.coste,
                                    descripcion = product.descripcion,
                                    cantidad = (int)product.cantidad,
                                    iidState = (int)product.idState
                                 }).ToList();
            }
                return View(listaProducto);
        }
    }
}