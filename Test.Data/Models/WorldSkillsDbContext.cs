using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Test.Data.Models
{
    public partial class WorldSkillsDbContext : DbContext
    {
        public WorldSkillsDbContext()
        {
        }

        public WorldSkillsDbContext(DbContextOptions<WorldSkillsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accountant> Accountants { get; set; }
        public virtual DbSet<AccountantsCheck> AccountantsChecks { get; set; }
        public virtual DbSet<AccountantsService> AccountantsServices { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Analyzer> Analyzers { get; set; }
        public virtual DbSet<AnalyzerReport> AnalyzerReports { get; set; }
        public virtual DbSet<Check> Checks { get; set; }
        public virtual DbSet<Laborant> Laborants { get; set; }
        public virtual DbSet<LaborantsService> LaborantsServices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServicesReport> ServicesReports { get; set; }
        public virtual DbSet<SocialType> SocialTypes { get; set; }
        public virtual DbSet<StrahCompany> StrahCompanies { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-2ISTTMJ\\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=WorldSkillsDb;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Accountant>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastEnterDate).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountantsCheck>(entity =>
            {
                entity.HasOne(d => d.Accountant)
                    .WithMany(p => p.AccountantsChecks)
                    .HasForeignKey(d => d.AccountantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accountan__Accou__6FE99F9F");

                entity.HasOne(d => d.Check)
                    .WithMany(p => p.AccountantsChecks)
                    .HasForeignKey(d => d.CheckId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accountan__Check__70DDC3D8");
            });

            modelBuilder.Entity<AccountantsService>(entity =>
            {
                entity.HasOne(d => d.Accountant)
                    .WithMany(p => p.AccountantsServices)
                    .HasForeignKey(d => d.AccountantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accountan__Accou__656C112C");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.AccountantsServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accountan__Servi__66603565");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Analyzer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<AnalyzerReport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Analyzer)
                    .WithMany()
                    .HasForeignKey(d => d.AnalyzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AnalyzerR__Analy__060DEAE8");
            });

            modelBuilder.Entity<Check>(entity =>
            {
                entity.Property(e => e.Summary).HasColumnType("money");

                entity.HasOne(d => d.StrahCompany)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.StrahCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Checks__StrahCom__6B24EA82");
            });

            modelBuilder.Entity<Laborant>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastEnterDate).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LaborantsService>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Laborant)
                    .WithMany()
                    .HasForeignKey(d => d.LaborantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborants__Labor__0BC6C43E");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Laborants__Servi__0CBAE877");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__OrderSta__5070F446");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__ServiceI__4F7CD00D");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Ein)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsuaranceAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InsuranceInn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PassportN)
                    .HasMaxLength(50)
                    .HasColumnName("Passport_N");

                entity.Property(e => e.PassportS)
                    .HasMaxLength(50)
                    .HasColumnName("Passport_S");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SocialSecNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.SocialType)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.SocialTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patients__Social__4222D4EF");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__Services__A25C5AA67F60ED59");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<ServicesReport>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Laborant)
                    .WithMany(p => p.ServicesReports)
                    .HasForeignKey(d => d.LaborantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ServicesR__Labor__5812160E");

                entity.HasOne(d => d.Services)
                    .WithMany(p => p.ServicesReports)
                    .HasForeignKey(d => d.ServicesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ServicesR__Servi__59063A47");
            });

            modelBuilder.Entity<SocialType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<StrahCompany>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Bik)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("BIK");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("INN");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Rs)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
