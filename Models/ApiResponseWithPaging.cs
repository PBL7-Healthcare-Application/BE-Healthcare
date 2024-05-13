namespace BE_Healthcare.Models
{
    public class ApiResponseWithPaging : ApiResponse
    {
        //public PagingInfoModel? Paging { get; set; } = null;
        public PagingInfoModel? PagingInfo { get; set; }
    }
}
