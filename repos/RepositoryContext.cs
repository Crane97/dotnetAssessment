using FinalAssessmentDotNet.model;
using Microsoft.EntityFrameworkCore;

namespace FinalAssessmentDotNet.repos
{
    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Vehicles> Vehicles { get; set; }

        public DbSet<Owners> Owners { get; set; }

        public DbSet<Claims> Claims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claims>()
                .HasOne<Vehicles>()
                .WithMany()
                .HasForeignKey(p => p.Vehicle_Id);

            modelBuilder.Entity<Vehicles>()
                .HasOne<Owners>()
                .WithMany()
                .HasForeignKey(p => p.Owner_Id);
        }
    }
}
