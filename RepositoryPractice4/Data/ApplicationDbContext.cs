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

    }
}
