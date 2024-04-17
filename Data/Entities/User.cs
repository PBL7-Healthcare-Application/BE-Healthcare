using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid Id_User{ get; set; }

        [Required]
        [MaxLength(250)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? Avatar { get; set; }

        public bool Gender { get; set; }

        public int id_Role { get; set; }

        [ForeignKey(nameof(id_Role))]
        public Role Role { get; set; }

    }
}
