namespace BE_Healthcare.Models
{
    public class ChangePasswordModel
    {
        public string OldPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;

    }
}
