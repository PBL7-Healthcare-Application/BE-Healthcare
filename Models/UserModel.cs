namespace BE_Healthcare.Models
{
    public class UserModel
    {
        public Guid IdUser { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? CreatedDate { get; set; } = null;
        public string? Role { get; set; } = null!;
        public bool? IsLocked { get; set; } = false;
    }
}
