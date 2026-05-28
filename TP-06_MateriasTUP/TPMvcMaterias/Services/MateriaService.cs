using Microsoft.EntityFrameworkCore;
using TPMvcMaterias.Data;
using TPMvcMaterias.Models;

namespace TPMvcMaterias.Services
{
    public class MateriaService
    {
        private readonly AppDbContext context;

        public MateriaService(AppDbContext context)
        {
            this.context = context;
        }

        public List<Materia> ObtenerMaterias()
        {
            return context.Materias
                .Include(m => m.Profesor)
                .Include(m => m.Alumnos)
                .ToList();
        }

        public Materia? ObtenerPorId(int id)
        {
            return context.Materias
                .Include(m => m.Profesor)
                .Include(m => m.Alumnos)
                .FirstOrDefault(m => m.Id == id);
        }
    }
}