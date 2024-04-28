using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        //[ForeignKey("Doctor")]
        public Guid IdUser{ get; set; }

        [Required]
        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public byte[] PasswordHash { get; set; } = null!;

        public byte[] PasswordSalt { get; set; } = null!;

        [MaxLength(250)]
        public string Name { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }
            
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? Avatar { get; set; }

        public bool? Gender { get; set; }

        public int idRole { get; set; }

        [ForeignKey(nameof(idRole))]
        public Role Role { get; set; } = null!;

        public string OTPVerification { get; set; } = null!;
        public DateTime? OTPCreatedAt { get; set; }

        public bool? IsVerified { get; set; } = false;

        public Doctor Doctor{ get; set; } = null!;


    }
}
