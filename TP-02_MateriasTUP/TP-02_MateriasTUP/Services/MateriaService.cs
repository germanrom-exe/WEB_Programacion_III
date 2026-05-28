using TP_02_MateriasTUP.Models;

namespace TP_02_MateriasTUP.Services
{
    public class MateriaService
    {
        private List<Materia> materias;

        public MateriaService()
        {
            materias = new List<Materia>
            {
                new Materia
                {
                    Id = 1,
                    Nombre = "Programacion I",

                    Profesor = new Profesor
                    {
                        Id = 1,
                        Nombre = "Juan Perez"
                    },

                    Alumnos = new List<Alumno>
                    {
                        new Alumno
                        {
                            Id = 1,
                            Nombre = "Ana"
                        },

                        new Alumno
                        {
                            Id = 2,
                            Nombre = "Carlos"
                        }
                    }
                },

                new Materia
                {
                    Id = 2,
                    Nombre = "Base de Datos",

                    Profesor = new Profesor
                    {
                        Id = 2,
                        Nombre = "Maria Lopez"
                    },

                    Alumnos = new List<Alumno>
                    {
                        new Alumno
                        {
                            Id = 3,
                            Nombre = "Lucia"
                        },

                        new Alumno
                        {
                            Id = 4,
                            Nombre = "Pedro"
                        }
                    }
                }
            };
        }

        public List<Materia> ObtenerMaterias()
        {
            return materias;
        }

        public Materia? ObtenerPorId(int id)
        {
            return materias.FirstOrDefault(m => m.Id == id);
        }
    }
}