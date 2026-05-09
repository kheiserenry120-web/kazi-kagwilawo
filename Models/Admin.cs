namespace KaziKagwilawo.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        
        public string Department { get; set; } = string.Empty;
    }
}
