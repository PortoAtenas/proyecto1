using proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> listaCliente = null;

            using (var bd = new proyectoSEntities1())
            {
                listaCliente = (from Client in bd.Cliente
                                select new ClienteCLS
                                {
                                    icedula = Client.cedula,
                                    inombreC = Client.nombreC,
                                    iapellidosC = Client.apellidos,
                                    idireccion = Client.direccion,
                                    icelular = Client.celular,
                                    itelefono = Client.telefono
                                }).ToList();
            }


            return View(listaCliente);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Agregar(ClienteCLS oClienteCLS) 
        {
            if (!ModelState.IsValid)
            {
                return View(oClienteCLS);
            }
            else 
            {
                using (var bd = new proyectoSEntities1())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.cedula = oClienteCLS.icedula;
                    oCliente.nombreC = oClienteCLS.inombreC;
                    oCliente.apellidos = oClienteCLS.iapellidosC;
                    oCliente.direccion = oClienteCLS.idireccion;
                    oCliente.celular = oClienteCLS.icelular;
                    oCliente.telefono = oClienteCLS.itelefono;
                    bd.Cliente.Add(oCliente);
                    bd.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
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

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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
