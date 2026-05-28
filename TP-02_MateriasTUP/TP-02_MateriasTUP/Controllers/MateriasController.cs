using Microsoft.AspNetCore.Mvc;
using TP_02_MateriasTUP.Services;

namespace TP_02_MateriasTUP.Controllers
{
    public class MateriasController : Controller
    {
        private readonly MateriaService service;

        public MateriasController()
        {
            service = new MateriaService();
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