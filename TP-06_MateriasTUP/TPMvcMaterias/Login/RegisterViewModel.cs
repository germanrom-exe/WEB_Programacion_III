using System.ComponentModel.DataAnnotations;

namespace TPMvcMaterias.Login
{
    public class RegisterViewModel
    {
        [Required]
        public string Nombre { get; set; } = "";

        [Required]
        public string Apellido { get; set; } = "";

        [Required]
        [RegularExpression(
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
            ErrorMessage = "Ingrese un correo válido"
        )]
        public string Correo { get; set; } = "";

        [Required]
        public int Legajo { get; set; }

        [Required]
        public string Password { get; set; } = "";

        [Required]
        [Compare("Password",
            ErrorMessage = "Las contraseñas no coinciden")]
        public string RepetirPassword { get; set; } = "";
    }
}