namespace BE_Healthcare.Models
{
    public class ApiResponseWithPagingAndTableRating : ApiResponseWithPaging
    {
        public StatisticalTableOfRatingModel? StatisticalTableOfRating { get; set; }

    }
}
