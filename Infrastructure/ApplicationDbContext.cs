using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Projects)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Skills)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Educations)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Experiences)
                .WithOne(ex => ex.User)
                .HasForeignKey(ex => ex.UserID);
        }

    }
}
