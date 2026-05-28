namespace TPMvcMaterias.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";

        public int MateriaId { get; set; }

        public Materia Materia { get; set; } = null!;
    }
}