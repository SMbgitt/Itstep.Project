using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Diary.Entities
{
    public class Affairs
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [MaxLength(155)]
        public string Name { get; set; } = String.Empty;

        public string Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
