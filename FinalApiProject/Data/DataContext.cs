using FinalApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalApiProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<GraduateTrainee> GraduateTrainees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add relationships for Degree and GraduateTrainee
            modelBuilder.Entity<Degree>()
                .HasMany(d => d.GraduateTrainees)
                .WithOne(g => g.Degree)
                .HasForeignKey(g => g.DegreeId)
                .IsRequired();
        }
    }
}
