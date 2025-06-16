using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integration.Entity
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Required]
        public string? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required] 
        public string? Email { get; set; }

        [Required] 
        public string? Password { get; set; }
    }
}
