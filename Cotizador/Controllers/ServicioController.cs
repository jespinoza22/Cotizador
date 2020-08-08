using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cotizador.Common;
using Cotizador.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotizador.Controllers
{
    public class ServicioController : Controller
    {
        // GET: ServicioController
        public ActionResult Index()
        {
            var listaRoles = new List<Rol>();
            listaRoles = Constantes.listaRol();
            ViewBag.CotVisible = false;
            ViewBag.listaRoles = listaRoles;
            ViewBag.listaServicio = Constantes.listaEquipoServicio();
            return View();
        }


        public ActionResult CambiarRol(string a)
        {
            var listaCategoria = new List<Categoria>();
            listaCategoria = Constantes.listaCategoria();
            return Json(listaCategoria);
        }



        // GET: ServicioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServicioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServicioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServicioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServicioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServicioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
