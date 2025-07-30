using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiarioFit.Intf.Models
{
    [Table("Workout")]
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public required String Title { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public required User User { get; set; }

    }
}
