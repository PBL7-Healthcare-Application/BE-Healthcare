namespace BE_Healthcare.Models
{
    public class AppointmentDetailOfAdminModel : AppointmentModel
    {
        public Guid IdUser { get; set; }
        public string NameUser { get; set; } = null!;
        public string? AvatarUser { get; set; } = null!;

    }
}
