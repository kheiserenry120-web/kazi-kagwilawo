using System.ComponentModel.DataAnnotations;

namespace KaziKagwilawo.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int EmployerId { get; set; }
        public virtual Employer Employer { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public string Description { get; set; } = string.Empty;
        
        public string Requirements { get; set; } = string.Empty;
        
        public string Location { get; set; } = string.Empty;
        public string JobType { get; set; } = "Full-time"; // Full-time, Part-time, Contract, etc.
        public decimal? Salary { get; set; }

        public DateTime PostedDate { get; set; } = DateTime.UtcNow;
        public DateTime? Deadline { get; set; }
        
        public bool IsActive { get; set; } = true;

        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
