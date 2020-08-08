using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Cotizador.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotizador.Controllers
{
    public class EquipoController : Controller
    {
        // GET: EquipoController
        public ActionResult Index()
        {
            var listaEquipo = new List<Equipo>();

            var miembro = new Equipo()
            {
                Id = "2",
                NombreCompleto = "Junior Espinoza",
                UrlFoto = "https://media-exp1.licdn.com/dms/image/C4E03AQH12zg9jBfZlg/profile-displayphoto-shrink_400_400/0?e=1602115200&v=beta&t=aK-fzdUd0djkcvs0OmLS3rRReLVMKfUizk3XW07V4TQ",
                Descripcion = "Developer Net, angular, javasript, typescript",
                Nivel = "Semi Senior",
                Perfil = ".Net Developer",
                UrlLinkedin = "https://www.linkedin.com/in/junior-espinoza-lozano-19406b8a/"
            };
            listaEquipo.Add(miembro);

            miembro = new Equipo()
            {
                Id = "2",
                NombreCompleto = "Roy Carrazco",
                UrlFoto = "https://media-exp1.licdn.com/dms/image/C4E03AQEvGwL-Yb7m5w/profile-displayphoto-shrink_400_400/0?e=1602115200&v=beta&t=zar-jnH3TdPNxkhIjidYXke4zxIjNFmIYUWOzukdZao",
                Descripcion = "Developer Jr Java backend, servicios Rest, Soap",
                Nivel = "Semi Senior",
                Perfil = ".Java Developer",
                UrlLinkedin = "https://www.linkedin.com/in/roy-adonis-carrasco-huaman-3171b2156/"
            };
            listaEquipo.Add(miembro);

            miembro = new Equipo()
            {
                Id = "3",
                NombreCompleto = "Raul Gamio",
                UrlFoto = "https://media-exp1.licdn.com/dms/image/C4E03AQFVT91CCTEXFg/profile-displayphoto-shrink_400_400/0?e=1602115200&v=beta&t=BdxvgKjls-SFcuwUJM3D_xS5kP7Apz0mGDysJWnX1jI",
                Descripcion = "Scrum Master con manejo de equipos agiles",
                Nivel = "Senior",
                Perfil = "Scrum Master",
                UrlLinkedin = "https://www.linkedin.com/in/raulgamio/"
            };
            listaEquipo.Add(miembro);

            miembro = new Equipo()
            {
                Id = "4",
                NombreCompleto = "Cat. Vargas",
                UrlFoto = "https://media-exp1.licdn.com/dms/image/C5603AQEf36e9noQVog/profile-displayphoto-shrink_400_400/0?e=1602115200&v=beta&t=2LRWwNn69KrBQyqer-focN7qtdWqqLx6CtLpuuki1oI",
                Descripcion = "Analista funcional con manejo de equipso agiles",
                Nivel = "Semi Senior",
                Perfil = "Analista Funcional",
                UrlLinkedin = "https://www.linkedin.com/in/catherine-evelyn-vargas-salas-626159133/"
            };
            listaEquipo.Add(miembro);

            miembro = new Equipo()
            {
                Id = "5",
                NombreCompleto = "Jean Arteaga",
                UrlFoto = "https://media-exp1.licdn.com/dms/image/C5603AQGHDcw0QA4E8w/profile-displayphoto-shrink_400_400/0?e=1602115200&v=beta&t=uK9gicbeoziUX7lyH6qrsM3EjHQ8bkWAGCng6zdtXK0",
                Descripcion = "Developer Jr Java backend, servicios Rest, Soap",
                Nivel = "Semi Senior",
                Perfil = ".Net Developer",
                UrlLinkedin = "https://www.linkedin.com/in/jean-arteaga/"
            };

            listaEquipo.Add(miembro);
            return View(listaEquipo);
        }

        // GET: EquipoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EquipoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipoController/Create
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

        // GET: EquipoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EquipoController/Edit/5
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

        // GET: EquipoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EquipoController/Delete/5
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
