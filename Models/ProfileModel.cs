namespace BE_Healthcare.Models
{
    public class ProfileModel
    {
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? DOB { get; set; }
        public bool? Gender { get; set; }

        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }


    }
}
