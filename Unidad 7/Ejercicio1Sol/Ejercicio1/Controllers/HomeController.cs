using System.Diagnostics;
using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using Ejercicio1.Models.Entities;


namespace Ejercicio1.Controllers
{
    /// <summary>
    /// Controlador principal del proyecto.
    /// </summary>
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

        /// <summary>
        /// Vista principal del proyecto.
        /// </summary>
        /// <returns>Vista principal del projecto</returns>
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
        /// <summary>
        /// ActionResult para mostrar el listado de personas.
        /// </summary>
        /// <returns>Vista con el listado de personas completa.</returns>
        public IActionResult listadoPersonas()
        { 
            return View(DAL.getPersonas());
        }

        /// <summary>
        /// ActionResult para mostrar el listado de personas en posición 3.
        /// </summary>
        /// <returns>Listado de personas con posición 3</returns>
        public IActionResult listadoPersonasPosicion3()
        {
            return View(DAL.getPersonas());
        }

        /// <summary>
        /// ActionResult para editar una persona aleatoria
        /// </summary>
        /// <returns>Vista a mostrar al usuario.</returns>
        public IActionResult EditarPersona()
        {
            Random rnd = new Random();
            List<Persona> pl = DAL.getPersonas();
            Persona p = pl[rnd.Next(0, pl.Count)];

            return View(p);
        }

        /// <summary>
        /// No se que hace.
        /// </summary>
        /// <returns></returns>
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
