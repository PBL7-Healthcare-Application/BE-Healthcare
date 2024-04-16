using System.ComponentModel.DataAnnotations;

namespace API_Login.Models
{
    public class LoginModel
    {
        [Required]
        [MaxLength(250)]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
    }
}
