using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiarioFit.Intf.Models
{
    [Table("Exercice")]
    public class Exercise
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
    }
}
