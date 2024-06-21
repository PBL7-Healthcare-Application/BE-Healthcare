using MimeKit;
using System.Net.Mail;

namespace BE_Healthcare.Models.EmailModel
{
    public class MessageHTMLForCancellingAppointmentModel
    {
        public MessageHTMLForCancellingAppointmentModel(string subject, IEnumerable<string> to, string nameUser, int idAppointment, 
            string startTime, string endTime, DateTime date, string address, string nameDoctor, string reason, 
            string emailUser, string nameclinic)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress("email", x)));
            Subject = subject;
            NameUser = nameUser;
            IdAppointment = idAppointment;
            StartTime = startTime;
            EndTime = endTime;
            Date = date;
            Address = address;
            NameDoctor = nameDoctor;
            Reason = reason;
            EmailUser = emailUser;
            NameClinic = nameclinic;
        }

        public string Subject { get; set; }
        public List<MailboxAddress> To { get; set; }
        public string NameUser { get; set; }
        public int IdAppointment { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string NameDoctor { get; set; }
        public string Reason { get; set; }
        public string EmailUser { get; set; }
        public string NameClinic { get; set; }
    }
}
