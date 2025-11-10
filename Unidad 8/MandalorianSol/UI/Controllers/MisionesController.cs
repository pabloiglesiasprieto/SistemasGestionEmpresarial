using Microsoft.AspNetCore.Mvc;
using Domain.DTOs;
using Domain.UseCases;
using Domain.Interfaces;

namespace UI.Controllers
{
    public class MisionesController : Controller
    {
        private readonly IMediaNocheUseCase _mediaNocheUseCase;

        public MisionesController(IMediaNocheUseCase mediaNocheUseCase)
        {
            _mediaNocheUseCase = mediaNocheUseCase;
        }

        // GET: Misiones
        [HttpGet]
        public IActionResult Index()
        {
            var dto = new ListadoWithMisionSeleccionadaDto
            {
                ListadoMisiones = _mediaNocheUseCase.getMisiones(),
                MisionSeleccionada = null
            };

            return View(dto);
        }

        // POST: Misiones (selección de misión)
        [HttpPost]
        public IActionResult Index(int id)
        {
            var listado = _mediaNocheUseCase.getMisiones();
            var seleccionada = listado.FirstOrDefault(m => m.Id == id);

            var dto = new ListadoWithMisionSeleccionadaDto
            {
                ListadoMisiones = listado,
                MisionSeleccionada = seleccionada
            };

            return View(dto);
        }
    }
}
