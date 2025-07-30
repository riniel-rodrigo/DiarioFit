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
        public double Weight { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }

        [ForeignKey("Exercice")]
        public int ExerciseId { get; set; }
        public required Workout Workout { get; set; }
        public required Exercise Exercise { get; set; }
    }
}
