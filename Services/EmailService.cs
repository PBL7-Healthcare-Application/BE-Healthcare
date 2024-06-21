using BE_Healthcare.Models.EmailModel;
using System.Net.Mail;
using System.Net;
using MimeKit;
using BE_Healthcare.Constant;
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


        private MailMessage? CreateEmailMessageHTML(int TypeMailHTML, 
            MessageHTMLForBookingSuccessfullyModel? messageBookSuccessfully = null, 
            MessageHTMLForCancellingAppointmentModel? messageCancelAppointment = null,
             MessageHTMLForApprovedApplicationModel? messageApprovedApplication = null,
             MessageHTMLForReschedulingAppointmentModel? messageRescheduleAppointment = null,
             MessageModel? messageModel = null)
        {
            //ForBookingSuccessfully
            if(TypeMailHTML == AppNumber.TYPEMAILHTML_FOR_BOOKING_SUCCESSFULLY && messageBookSuccessfully != null)
            {
                MailMessage _message = new MailMessage
                {
                    From = new MailAddress(_emailConfig.From),
                    Subject = messageBookSuccessfully.Subject,
                    IsBodyHtml = true
                };

                foreach (var toAddress in messageBookSuccessfully.To)
                {
                    _message.To.Add(new MailAddress(toAddress.Address));
                }

                string htmlContent = LoadHtmlTemplate("Template//EmailForBookingSuccessfully.html");
                _message.Body = ReplacePlaceholders(htmlContent, messageBookSuccessfully);

                return _message;
            }

            //ForCancellingAppointment
            if (TypeMailHTML == AppNumber.TYPEMAILHTML_FOR_CANCELLING_APPOINTMENT && messageCancelAppointment != null)
            {
                MailMessage _message = new MailMessage
                {
                    From = new MailAddress(_emailConfig.From),
                    Subject = messageCancelAppointment.Subject,
                    IsBodyHtml = true
                };

                foreach (var toAddress in messageCancelAppointment.To)
                {
                    _message.To.Add(new MailAddress(toAddress.Address));
                }
                string htmlContent = LoadHtmlTemplate("Template//EmailForCancellingAppointment.html");
                _message.Body = ReplacePlaceholdersForCancellingAppointment(htmlContent, messageCancelAppointment);

                return _message;

            }

            //ForApprovedApplication
            if (TypeMailHTML == AppNumber.TYPEMAILHTML_FOR_APPROVED_APPLICATION && messageApprovedApplication != null)
            {
                MailMessage _message = new MailMessage
                {
                    From = new MailAddress(_emailConfig.From),
                    Subject = messageApprovedApplication.Subject,
                    IsBodyHtml = true
                };

                foreach (var toAddress in messageApprovedApplication.To)
                {
                    _message.To.Add(new MailAddress(toAddress.Address));
                }
                string htmlContent = LoadHtmlTemplate("Template//EmailForApprovedApplication.html");
                _message.Body = ReplacePlaceholdersForApprovedApplication(htmlContent, messageApprovedApplication);

                return _message;

            }
            //ForReschedulingAppointment
            if (TypeMailHTML == AppNumber.TYPEMAILHTML_FOR_RESCHEDULING_APPOINTMENT && messageRescheduleAppointment != null)
            {
                MailMessage _message = new MailMessage
                {
                    From = new MailAddress(_emailConfig.From),
                    Subject = messageRescheduleAppointment.Subject,
                    IsBodyHtml = true
                };

                foreach (var toAddress in messageRescheduleAppointment.To)
                {
                    _message.To.Add(new MailAddress(toAddress.Address));
                }
                string htmlContent = LoadHtmlTemplate("Template//EmailForReschedulingAppointment.html");
                _message.Body = ReplacePlaceholdersForReschedulingAppointment(htmlContent, messageRescheduleAppointment);

                return _message;

            }
            if (TypeMailHTML == AppNumber.OTP && messageModel != null)
            {
                MailMessage _message = new MailMessage
                {
                    From = new MailAddress(_emailConfig.From),
                    Subject = messageModel.Subject,
                    IsBodyHtml = true
                };

                foreach (var toAddress in messageModel.To)
                {
                    _message.To.Add(new MailAddress(toAddress.Address));
                }
                string htmlContent = LoadHtmlTemplate("Template//OTP.html");
                _message.Body = ReplacePlaceholdersForOTP(htmlContent, messageModel);

                return _message;

            }

            return null;
        }
        public void SendEmailHTML(int TypeMailHTML,
            MessageHTMLForBookingSuccessfullyModel? messageBookSuccessfully = null,
            MessageHTMLForCancellingAppointmentModel? messageCancelAppointment = null,
            MessageHTMLForApprovedApplicationModel? messageApprovedApplication = null,
            MessageHTMLForReschedulingAppointmentModel? messageRescheduleAppointment = null,
            MessageModel? messageModel = null)
        {
            var emailMessage = CreateEmailMessageHTML(TypeMailHTML, messageBookSuccessfully, messageCancelAppointment, messageApprovedApplication,
                messageRescheduleAppointment,messageModel);

            using ( var smtpClient = new SmtpClient("smtp.gmail.com")) //config smtp client
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(_emailConfig.From, _emailConfig.FromPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(emailMessage);
            }
        }
        private string LoadHtmlTemplate(string filePath)
        {
            return File.ReadAllText(filePath);
        }
        private string ReplacePlaceholders(string template, MessageHTMLForBookingSuccessfullyModel message)
        {
            string formattedDate = DateTime.Parse(message.Date.ToString()).ToString("MMMM dd, yyyy");
            // Replace placeholders with actual values from the message
            template = template.Replace("[[${nameUser}]]", message.NameUser.ToString());
            template = template.Replace("[[${idAppointment}]]", message.IdAppointment.ToString());
            template = template.Replace("[[${startTime}]]", message.StartTime);
            template = template.Replace("[[${endTime}]]", message.EndTime);
            template = template.Replace("[[${date}]]", message.Date.ToString());
            template = template.Replace("[[${formattedDate}]]", formattedDate);
            template = template.Replace("[[${address}]]", message.Address);
            template = template.Replace("[[${nameDoctor}]]", message.NameDoctor);
            template = template.Replace("[[${price}]]", message.Price.ToString());

            template = template.Replace("[[${issue}]]", message.Issue);
            template = template.Replace("[[${emailUser}]]", message.EmailUser.ToString());
            template = template.Replace("[[${emailDoctor}]]", message.EmailDoctor.ToString());
            template = template.Replace("[[${nameClinic}]]", message.NameClinic.ToString());


            return template;
        }

        private string ReplacePlaceholdersForCancellingAppointment(string template, MessageHTMLForCancellingAppointmentModel message)
        {
            string formattedDate = DateTime.Parse(message.Date.ToString()).ToString("MMMM dd, yyyy");
            template = template.Replace("[[${nameUser}]]", message.NameUser.ToString());
            template = template.Replace("[[${idAppointment}]]", message.IdAppointment.ToString());
            template = template.Replace("[[${startTime}]]", message.StartTime);
            template = template.Replace("[[${endTime}]]", message.EndTime);
            template = template.Replace("[[${date}]]", message.Date.ToString());
            template = template.Replace("[[${formattedDate}]]", formattedDate);
            template = template.Replace("[[${address}]]", message.Address);
            template = template.Replace("[[${nameDoctor}]]", message.NameDoctor);

            template = template.Replace("[[${reason}]]", message.Reason.ToString());
            template = template.Replace("[[${emailUser}]]", message.EmailUser.ToString());
            template = template.Replace("[[${nameClinic}]]", message.NameClinic.ToString());

            return template;
        }

        private string ReplacePlaceholdersForApprovedApplication(string template, MessageHTMLForApprovedApplicationModel message)
        {
            template = template.Replace("[[${nameUser}]]", message.NameUser.ToString());
            template = template.Replace("[[${emailUser}]]", message.EmailUser.ToString());

            return template;
        }
        private string ReplacePlaceholdersForOTP(string template, MessageModel message)
        {
            template = template.Replace("[[${otp}]]", message.Content.ToString());
            return template;
        }
        private string ReplacePlaceholdersForReschedulingAppointment(string template, MessageHTMLForReschedulingAppointmentModel message)
        {
            string formattedDate = DateTime.Parse(message.Date.ToString()).ToString("MMMM dd, yyyy");
            template = template.Replace("[[${nameUser}]]", message.NameUser.ToString());
            template = template.Replace("[[${idAppointment}]]", message.IdAppointment.ToString());
            template = template.Replace("[[${startTime}]]", message.StartTime);
            template = template.Replace("[[${endTime}]]", message.EndTime);
            template = template.Replace("[[${date}]]", message.Date.ToString());
            template = template.Replace("[[${formattedDate}]]", formattedDate);
            template = template.Replace("[[${address}]]", message.Address);
            template = template.Replace("[[${nameDoctor}]]", message.NameDoctor);
            template = template.Replace("[[${price}]]", message.Price.ToString());

            template = template.Replace("[[${emailUser}]]", message.EmailUser.ToString());
            template = template.Replace("[[${emailDoctor}]]", message.EmailDoctor.ToString());
            template = template.Replace("[[${nameClinic}]]", message.NameClinic.ToString());

            return template;
        }
    }
}
