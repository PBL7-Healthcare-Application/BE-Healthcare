namespace BE_Healthcare.Models
{
    public class UpdateProfileModel
    {
        public string? Name { get; set; } = null!;

        public DateTime? DOB { get; set; } = null!;

        public string? PhoneNumber { get; set; } = null!;

        public string? Address { get; set; } = null!;
        public string? Latitude { get; set; } = null!;
        public string? Longtitude { get; set; } = null!;

        public string? Avatar { get; set; } = null!;

        public bool? Gender { get; set; } = null!;
    }
}
