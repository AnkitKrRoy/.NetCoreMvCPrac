using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCorePrac.Models
{
    public partial class BindGridDBContext : DbContext
    {
        public BindGridDBContext()
        {
        }

        public BindGridDBContext(DbContextOptions<BindGridDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eno)
                    .HasName("PK__employee__D9507B87997D464A");

                entity.ToTable("employee");

                entity.Property(e => e.Eno)
                    .ValueGeneratedNever()
                    .HasColumnName("eno");

                entity.Property(e => e.Comm).HasColumnName("comm");

                entity.Property(e => e.Dno).HasColumnName("dno");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Gender)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
