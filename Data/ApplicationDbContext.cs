using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KaziKagwilawo.Models;

namespace KaziKagwilawo.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employer> Employers { get; set; }
    public DbSet<JobSeeker> JobSeekers { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Admin> Admins { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configure relationships
        builder.Entity<ApplicationUser>()
            .HasOne(a => a.Employer)
            .WithOne(b => b.ApplicationUser)
            .HasForeignKey<Employer>(b => b.ApplicationUserId);

        builder.Entity<ApplicationUser>()
            .HasOne(a => a.JobSeeker)
            .WithOne(b => b.ApplicationUser)
            .HasForeignKey<JobSeeker>(b => b.ApplicationUserId);

        builder.Entity<ApplicationUser>()
            .HasOne(a => a.Admin)
            .WithOne(b => b.ApplicationUser)
            .HasForeignKey<Admin>(b => b.ApplicationUserId);
            
        builder.Entity<Application>()
            .HasOne(a => a.Job)
            .WithMany(j => j.Applications)
            .HasForeignKey(a => a.JobId)
            .OnDelete(DeleteBehavior.NoAction); // prevent cascade delete

        builder.Entity<Application>()
            .HasOne(a => a.JobSeeker)
            .WithMany(j => j.Applications)
            .HasForeignKey(a => a.JobSeekerId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
