namespace BE_Healthcare.Models
{
    public class CancelAppointmentModel
    {
        public int idAppointment { get; set; }
        public string? Reason { get; set; } = null;

    }
}
