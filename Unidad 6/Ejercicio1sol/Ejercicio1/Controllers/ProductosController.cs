using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
