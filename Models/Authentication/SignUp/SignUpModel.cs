using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Models.Authentication.SignUp
{
    public class SignUpModel
    {
        [Required]
        [MaxLength(250)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(250)]
        public string Password { get; set; } = null!;

        [MaxLength(250)]
        public string Name { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
    }
}
