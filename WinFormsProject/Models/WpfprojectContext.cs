using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WinFormsProject.Models
{
    public class WpfprojectContext : DbContext
    {
        private string connectString = "Server=localhost;Database=wpfproject;Trusted_Connection=True;";
        public WpfprojectContext()
        {
        }

        public WpfprojectContext(DbContextOptions<WpfprojectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Wfrole> Wfroles { get; set; }
        public virtual DbSet<Wfuser> Wfusers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wfrole>(entity =>
            {
                entity.ToTable("WFRoles");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wfuser>(entity =>
            {
                entity.ToTable("WFUser");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Password");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("datetime")
                    .HasColumnName("Birth_day");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_time");

                entity.Property(e => e.FisrtName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("First_name"); 
                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Last_name");


                entity.Property(e => e.RoleId).HasColumnName("Role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Wfusers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__WFUser__Role_id__2B3F6F97");
            });
        }


    }
}
