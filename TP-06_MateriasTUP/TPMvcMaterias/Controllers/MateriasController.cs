using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TPMvcMaterias.Services;

namespace TPMvcMaterias.Controllers
{
    [Authorize]
    public class MateriasController : Controller
    {
        private readonly MateriaService service;

        public MateriasController(MateriaService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var materias = service.ObtenerMaterias();

            return View(materias);
        }

        public IActionResult Details(int id)
        {
            var materia = service.ObtenerPorId(id);

            return View(materia);
        }
    }
}