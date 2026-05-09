using Microsoft.AspNetCore.Identity;

namespace KaziKagwilawo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual Employer Employer { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
