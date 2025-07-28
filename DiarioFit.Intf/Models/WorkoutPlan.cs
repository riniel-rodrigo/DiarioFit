using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiarioFit.Intf.Models
{
    [Table("WorkoutPlan")]
    public class WorkoutPlan
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
