using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Models.Authentication.SignUp
{
    public class MailModel
    {
        [MaxLength(250)]
        public string email { get; set; } = null!;

    }
}
