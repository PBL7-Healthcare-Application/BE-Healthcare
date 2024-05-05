using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Models.Authentication.Login
{
    public class LoginModel
    {
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
