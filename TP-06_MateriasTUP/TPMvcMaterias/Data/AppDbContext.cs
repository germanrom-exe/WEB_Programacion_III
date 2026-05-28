using Microsoft.EntityFrameworkCore;
using TPMvcMaterias.Models;

namespace TPMvcMaterias.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}