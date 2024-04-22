using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Models.Authentication.Login
{
    public class LoginModel
    {
        [Required]
        [MaxLength(250)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Password { get; set; } = null!;
    }
}
