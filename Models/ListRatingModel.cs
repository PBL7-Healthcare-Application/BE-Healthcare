namespace BE_Healthcare.Models
{
    public class ListRatingModel : RatingModel
    {
        public int IdRating { get; set; }
        public string? NameUserRating { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }


    }
}
