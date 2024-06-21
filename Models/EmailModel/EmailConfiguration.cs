using System.Security;

namespace BE_Healthcare.Models.EmailModel
{
    public class EmailConfiguration
    {
        public string From { get; set; } = null!;
        public string FromPassword { get; set; } = null!;
        public string SmtpServer { get; set; } = null!;
        public int Port { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
