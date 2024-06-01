using MimeKit;
using System.Net.Mail;

namespace BE_Healthcare.Models.EmailModel
{
    public class MessageHTMLForApprovedApplicationModel
    {
        public MessageHTMLForApprovedApplicationModel(string subject, IEnumerable<string> to, string nameUser, string emailUser)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress("email", x)));
            Subject = subject;
            NameUser = nameUser;
            EmailUser = emailUser;
        }

        public string Subject { get; set; }
        public List<MailboxAddress> To { get; set; }
        public string NameUser { get; set; }
        public string EmailUser { get; set; }

    }
}
