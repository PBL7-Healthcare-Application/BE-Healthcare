﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    public class Doctor
    {
        [Key]
        public Guid IdDoctor { get; set; }
        public int? YearExperience { get; set; }
        public double? Price { get; set; }

        public int? IdSpecialty { get; set; }

        [ForeignKey(nameof(IdSpecialty))]
        public MedicalSpecialty MedicalSpecialty{ get; set; } = null!;
        public ICollection<Certificate> Certificates { get; set; } = null!;

        public Guid IdUser { get; set; }
        public User User { get; set; } = null!;
        public string WorkingTimeStart { get; set; } = null!;
        public string WorkingTimeEnd { get; set; } = null!;
        public int? DurationPerAppointment { get; set; }

    }
}