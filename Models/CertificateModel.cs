﻿using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models
{
    public class CertificateModel
    {
        public int IdCertificate { get; set; }
        public string Name { get; set; } = null!;
        public int? Year { get; set; }
        public string Image { get; set; } = null!;
    }
}
