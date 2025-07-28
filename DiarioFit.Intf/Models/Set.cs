using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiarioFit.Intf.Models
{
    [Table("Set")]
    public class Set
    {
        [Key]
        public int Id { get; set; }
        public int Repetitions { get; set; }
        public double Weigth { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutsId { get; set; }

        [ForeignKey("Exercice")]
        public int ExerciceId { get; set; }
    }
}
