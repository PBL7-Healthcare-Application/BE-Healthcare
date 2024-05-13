using BE_Healthcare.Constant;

namespace BE_Healthcare.Models
{
    public class UserSearchCriteriaModel
    {
        public string? search { get; set; } = null;
        public int? role { get; set; } = null!;
        public bool? status { get; set; } = null!; // 0 -> Active; 1 -> Lock
        public int page { get; set; } = 1;

    }
}
