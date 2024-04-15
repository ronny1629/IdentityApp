using System.ComponentModel.DataAnnotations;

namespace IdentityApp.DTOs.Account
{
    public class RegisterDto
    {
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El nombre debe tener al menos {2} letras y maximo {1}")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El apellido debe tener al menos {2} letras y maximo {1}")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$", ErrorMessage = "Direccion de email Invalida")]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "La contraseña debe tener al menos {2} letras y maximo {1}")]
        public string Password { get; set; }
    }
}
