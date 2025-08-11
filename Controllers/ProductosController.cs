using Microsoft.AspNetCore.Mvc;
using netdemoTarea3.Models;

namespace netdemoTarea3.Controllers
{
    public class ProductosController : Controller
    {
        private static List<Producto> listaProductos = new List<Producto>
        {
            new Producto{ Id=1, Nombre="Collar", Precio=25, ImagenUrl="https://tecnopets.pe/wp-content/uploads/2020/10/WhatsApp-Image-2020-10-12-at-4.52.15-PM.jpeg" },
            new Producto{ Id=2, Nombre="Comida Premium", Precio=50, ImagenUrl="https://vitalcan.com/wp-content/uploads/2023/04/pack-premium-cordero.png" },
            new Producto{ Id=3, Nombre="Cama para Perro", Precio=80, ImagenUrl="https://casaideasperu.vtexassets.com/arquivos/ids/299096/3224598000045_1.jpg?v=638635067230470000" }
        };

        public IActionResult Index()
        {
            return View(listaProductos);
        }
    }
}

