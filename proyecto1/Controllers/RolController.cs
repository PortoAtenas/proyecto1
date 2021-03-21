using proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto1.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {

            List < RolCLS > listaRol= null;

            using (var bd = new proyectoSEntities1())
            {
                listaRol = (from r in bd.Rol
                            select new RolCLS
                            {
                                iidRol = r.idRol,
                                nombreR = r.nombreR
                            }).ToList();
            }
            return View(listaRol);
        }

        public ActionResult Agregar() {
            return View();
        
        }

        /*
        [HttpPost]
        public ActionResult Agregar() {
            return View();
        }*/

        // GET: Rol/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rol/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rol/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rol/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rol/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
