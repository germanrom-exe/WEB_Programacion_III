namespace TPMvcMaterias.Models
{
    public class Profesor
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";

        public List<Materia> Materias { get; set; } = new();
    }
}