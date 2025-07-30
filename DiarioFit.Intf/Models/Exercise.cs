using DiarioFit.Intf.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiarioFit.Intf.Models
{
    [Table("Exercise")]
    public class Exercise
    {
        [Key]
        public int Id{ get; set; }
        public required string Nickname { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
