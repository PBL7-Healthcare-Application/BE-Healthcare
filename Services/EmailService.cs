using BE_Healthcare.Models.EmailModel;
using System.Net.Mail;
using System.Net;
using MimeKit;
//using MimeKit;
//using MailKit.Net.Smtp;
//using MailKit.Security;

namespace BE_Healthcare.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfiguration _emailConfig;

        public EmailService(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public void SendEmail(MessageModel message)
        {
            var emailMessage = CreateEmailMessage(message);

            var smtpClient = new SmtpClient("smtp.gmail.com")   //config smtp client
            {
                Port = 587,
                Credentials = new NetworkCredential(_emailConfig.From, _emailConfig.FromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(emailMessage);
        }

        private MailMessage CreateEmailMessage(MessageModel message)
        {

            MailMessage _message = new MailMessage();
            _message.From = new MailAddress(_emailConfig.From);
            _message.Subject = message.Subject;
            foreach (var toAddress in message.To)
            {
                _message.To.Add(new MailAddress(toAddress.Address));
            }
            _message.Body = message.Content;
            _message.IsBodyHtml = true;
            return _message;


        }
    }
}
