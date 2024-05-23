namespace BE_Healthcare.Models
{
    public class CreateRatingModel : RatingModel
    {
        public Guid IdDoctor { get; set; }
        public int IdAppointment { get; set; }
    }
}
