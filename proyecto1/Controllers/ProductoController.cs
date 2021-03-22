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

        public ActionResult Agregar() {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(ProductoCLS oProductoCLS) {
            if (!ModelState.IsValid)
            {
                return View(oProductoCLS);
            }
            else {
                using (var bd = new proyectoSEntities1())
                {
                    Producto oProducto = new Producto();
                    oProducto.nombresP = oProductoCLS.nombreP;
                    oProducto.precio = (decimal?)oProductoCLS.precio;
                    oProducto.coste = (decimal?)oProductoCLS.coste;
                    oProducto.descripcion = oProductoCLS.descripcion;
                    oProducto.cantidad = (int)oProductoCLS.cantidad;
                    oProducto.idState = (int)oProductoCLS.iidState;
                    bd.Producto.Add(oProducto);
                    bd.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }





    }
}