using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Diary.Entities
{
    public class Day
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [MaxLength(155)]
        public string Name { get; set; } = String.Empty;
    }
}
