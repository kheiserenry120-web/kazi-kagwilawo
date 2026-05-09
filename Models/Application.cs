using System.ComponentModel.DataAnnotations;

namespace KaziKagwilawo.Models
{
    public class Application
    {
        public int Id { get; set; }

        public int JobId { get; set; }
        public virtual Job Job { get; set; }

        public int JobSeekerId { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }

        public DateTime AppliedDate { get; set; } = DateTime.UtcNow;
        
        public string Status { get; set; } = "Pending"; // Pending, Shortlisted, Rejected, Hired
        
        public string CoverLetter { get; set; } = string.Empty;
        
        public string CvFilePath { get; set; } = string.Empty; // Snapshot or custom CV for this application
    }
}
