using Org.BouncyCastle.Math.EC.Multiplier;
using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Models.Authentication.SignUp
{
    public class ConfirmMailModel : MailModel
    {
        [MaxLength(6)]
        public string otp { get; set; } = null!;

    }
}
