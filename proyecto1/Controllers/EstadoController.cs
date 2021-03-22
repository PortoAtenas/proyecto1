using proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto1.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado
        public ActionResult Index()
        {
            List<EstadoCLS> listaEstado = null;

            using (var bd = new proyectoSEntities1()) { 
                listaEstado = (from estate in bd.pState
                               select new EstadoCLS{ 
                               iidState = estate.idState,
                               nombreS = estate.nombreS
                               }).ToList();
            }

            return View(listaEstado);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(EstadoCLS oEstadoCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oEstadoCLS);
            }
            else {
                using (var bd = new proyectoSEntities1())
                {
                    pState oEstado = new pState();
                    oEstado.nombreS = oEstadoCLS.nombreS;
                    bd.pState.Add(oEstado);
                    bd.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        // GET: Estado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estado/Create
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

        // GET: Estado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estado/Edit/5
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

        // GET: Estado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estado/Delete/5
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
