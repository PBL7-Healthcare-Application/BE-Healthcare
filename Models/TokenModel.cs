namespace BE_Healthcare.Models
{
    public class TokenModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public string? Role { get; set; } = null;

    }
}
