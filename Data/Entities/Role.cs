using System.ComponentModel.DataAnnotations;

namespace BE_Healthcare.Data.Entities
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<User> Users { get; set; } = null!;
    }
}
