using MimeKit;

namespace BE_Healthcare.Models.EmailModel
{
    public class MessageHTMLForReschedulingAppointmentModel
    {
        public MessageHTMLForReschedulingAppointmentModel(string subject, IEnumerable<string> to, string nameUser, int idAppointment,
    string startTime, string endTime, DateTime date, string address, string nameDoctor, double price, string issue,
    string emailUser, string emailDoctor, string nameclinic)
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
            Price = price;
            Issue = issue;
            EmailUser = emailUser;
            EmailDoctor = emailDoctor;
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
        public double Price { get; set; }
        public string Issue { get; set; }
        public string EmailUser { get; set; }
        public string EmailDoctor { get; set; }
        public string NameClinic { get; set; }
    }
}
