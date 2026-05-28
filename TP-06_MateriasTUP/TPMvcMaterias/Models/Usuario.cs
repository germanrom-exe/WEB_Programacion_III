using System.ComponentModel.DataAnnotations;

namespace TPMvcMaterias.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = "";

        [Required]
        public string Apellido { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Correo { get; set; } = "";

        [Required]
        public int Legajo { get; set; }

        [Required]
        public string Password { get; set; } = "";
    }
}