using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobTracker.API.Models
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string JobTitle { get; set; } = null!;

        [Required]
        public string Company { get; set; } = null!;

        [Required]
        public DateTime AppliedOn { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public string? Status { get; set; } = "Pending";
    }
}
