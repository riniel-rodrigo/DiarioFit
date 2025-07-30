using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiarioFit.Intf.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required String Name { get; set; }
        public required String Email { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
