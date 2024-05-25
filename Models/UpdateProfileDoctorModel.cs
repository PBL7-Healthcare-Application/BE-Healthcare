namespace BE_Healthcare.Models
{
    public class UpdateProfileDoctorModel : UpdateProfileModel
    {
        public int? YearExperience { get; set; } = null!;
        public double? Price { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int? IdSpecialty { get; set; } = null!;
    }
}
