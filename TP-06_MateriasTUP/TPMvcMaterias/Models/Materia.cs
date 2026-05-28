namespace TPMvcMaterias.Models
{
    public class Materia
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";

        public int ProfesorId { get; set; }

        public Profesor Profesor { get; set; } = null!;

        public List<Alumno> Alumnos { get; set; } = new();
    }
}