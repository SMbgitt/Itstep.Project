using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Diary.Entities
{
    public class Schedule
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int DayId { get; set; }
        public int AffairsId { get; set; }

        [ForeignKey(nameof(AffairsId))]
        public virtual ICollection<Affairs> affairs { get; set; } = null!;

        [ForeignKey(nameof(DayId))]
        
        public virtual Day day { get; set; } = null!;
    }
}
