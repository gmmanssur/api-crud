using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integration.Entity
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Required]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string? Name { get; set; }

        [Required]
        [Column("email")]
        public string? Email { get; set; }

        [Required]
        [Column("password_hash")]
        public string? PasswordHash { get; set; }
    }
}
