using System.Diagnostics;
using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using Ejercicio1.Models.Entities;


namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {

        private string saludos = "Prueba";
        private DateTime hora = DateTime.Now;
        Persona persona = new Persona("Juan", 30);


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (DateTime.Now.Hour < 12)
            {
                saludos = "Buenos días";
            }
            else if (DateTime.Now.Hour < 13)
            {
                saludos =  "Buenas tardes";
            }
            else
            {
                saludos = "Buenas noches";
            }
            ViewData["Saludos"] = saludos;
            ViewBag.Hora = hora;
            return View(persona);
        }
        public IActionResult listadoPersonas()
        { 
            return View(DAL.getPersonas());
        }

        public IActionResult listadoPersonasPosicion3()
        {
            return View(DAL.getPersonas());
        }

        public IActionResult EditarPersona()
        {
             return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
