using Microsoft.EntityFrameworkCore;
using RepositoryPractice4.Models;

namespace RepositoryPractice4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblCustomer> tblCustomer { get; set; }
        public DbSet<tblIssue> tblIssue { get; set; }

        public DbSet<View_CustomerWithIssue> View_CustomerWithIssue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<View_CustomerWithIssue>(Entity =>
            {
                Entity.HasNoKey().ToView("View_CustomerWithIssue");
                Entity.Property(e => e.CustomerId).HasColumnName("CustomerId");
                Entity.Property(e => e.CustomerName).HasMaxLength(50).HasColumnName("CustomerName");
                Entity.Property(e => e.IssueId).HasColumnName("IssueId");
                Entity.Property(e => e.Issue).HasMaxLength(50).HasColumnName("Issue");
                Entity.Property(e => e.CarMake).HasMaxLength(15).HasColumnName("CarMake");
                Entity.Property(e => e.CarModel).HasMaxLength(20).HasColumnName("CarModel");
                Entity.Property(e => e.CarRego).HasMaxLength(15).HasColumnName("CarRego");
                Entity.Property(e => e.Description).HasMaxLength(200).HasColumnName("Description");
                
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
