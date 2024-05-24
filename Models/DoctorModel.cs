using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models
{
    public class DoctorModel
    {
        public Guid IdDoctor { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public string? Avatar { get; set; } = null!;

        public string MedicalSpecialty { get; set; } = null!;
        public double? Price { get; set; }
        public string? Address { get; set; } = null!;
        public int? YearExperience { get; set; }
        public double? RateAverage { get; set; }
        public int? NumberOfComment { get; set; }


    }
}
