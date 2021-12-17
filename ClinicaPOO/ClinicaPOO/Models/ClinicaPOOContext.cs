using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ClinicaPOO.Models
{
    public partial class ClinicaPOOContext : DbContext
    {
        public ClinicaPOOContext()
        {
        }

        public ClinicaPOOContext(DbContextOptions<ClinicaPOOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<Dentist> Dentists { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Method> Methods { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MONTANO; Database=ClinicaPOO; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("appointment_time");

                entity.Property(e => e.DentistId).HasColumnName("dentist_id");

                entity.Property(e => e.MethodId).HasColumnName("method_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.HasOne(d => d.Dentist)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DentistId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dentist_id");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.MethodId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_method_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_patient_id");
            });

            modelBuilder.Entity<Billing>(entity =>
            {
                entity.ToTable("billing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MedicineId).HasColumnName("medicine_id");

                entity.Property(e => e.MedicineQuantity).HasColumnName("medicine_quantity");

                entity.Property(e => e.MethodId).HasColumnName("method_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.Billings)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_billing_medicine_id");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.Billings)
                    .HasForeignKey(d => d.MethodId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_billing_method_id");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Billings)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_billing_patient_id");
            });

            modelBuilder.Entity<Dentist>(entity =>
            {
                entity.ToTable("dentist");

                entity.HasIndex(e => e.Email, "UNQ_dentist_email")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Specialty)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("specialty");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("inventory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Product)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("product");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Method>(entity =>
            {
                entity.ToTable("methods");

                entity.HasIndex(e => e.Name, "UNQ_methods_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.HasIndex(e => e.Email, "UNQ_email")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("birthdate");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_patient_user_id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Username, "UNQ_username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
