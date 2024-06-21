namespace BE_Healthcare.Models
{
    public class TokenModel : RenewTokenModel
    {
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;

    }
}
