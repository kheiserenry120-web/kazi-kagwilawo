using System.ComponentModel.DataAnnotations;

namespace KaziKagwilawo.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string CompanyName { get; set; } = string.Empty;
        
        public string CompanyDescription { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
