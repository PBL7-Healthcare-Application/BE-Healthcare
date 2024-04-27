using BE_Healthcare.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;

namespace BE_Healthcare.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region Dbset
        public DbSet<User> Users{ get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<TimeOff> TimeOffs { get; set; }
        public DbSet<TrainingProcess> TrainingProcesses { get; set; }
        public DbSet<WorkingProcess> WorkingProcesses { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne<Doctor>(e => e.Doctor)
            .WithOne(u => u.User)
            .HasForeignKey<Doctor>(u => u.IdUser).IsRequired();
        }
    }
}
