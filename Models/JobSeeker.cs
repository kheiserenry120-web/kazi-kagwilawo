namespace KaziKagwilawo.Models
{
    public class JobSeeker
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string ProfessionalSummary { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        
        public string CvFilePath { get; set; } = string.Empty;

        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
