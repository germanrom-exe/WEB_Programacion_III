namespace TP_02_MateriasTUP.Models
{
    public class Materia
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";

        public Profesor Profesor { get; set; } = new Profesor();

        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();
    }
}