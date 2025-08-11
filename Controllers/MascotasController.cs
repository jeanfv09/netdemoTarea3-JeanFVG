using Microsoft.AspNetCore.Mvc;
using netdemoTarea3.Models;

namespace netdemoTarea3.Controllers
{
    public class MascotasController : Controller
    {
        private static List<Mascota> listaMascotas = new List<Mascota>();

        public IActionResult Index()
        {
            return View(listaMascotas);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                mascota.Id = listaMascotas.Count + 1;
                listaMascotas.Add(mascota);
                return RedirectToAction("Index");
            }
            return View(mascota);
        }
    }
}
