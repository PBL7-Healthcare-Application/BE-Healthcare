namespace BE_Healthcare.Models.Certificate
{
    public class AddCertificateModel
    {
        public string? Name { get; set; } = null!;
        public int? Year { get; set; }
        public string? Image { get; set; } = null!;
        //public Guid? IdDoctor { get; set; }

    }
}
