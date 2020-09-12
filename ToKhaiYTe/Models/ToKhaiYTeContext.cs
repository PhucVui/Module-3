using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace ToKhaiYTe.Models
{
    public partial class ToKhaiYTeContext : DbContext
    {
        public ToKhaiYTeContext()
        {
        }

        public ToKhaiYTeContext(DbContextOptions<ToKhaiYTeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Days> Days { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Gates> Gates { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }
        public virtual DbSet<Years> Years { get; set; }
        public virtual DbSet<NguoiKhaiBao> NguoiKhaiBaos { get; set; }
        public virtual DbSet<DauHieu> DauHieus { get; set; }
        public virtual DbSet<PhoiNhiem> PhoiNhiems { get; set; }
        public virtual DbSet<ThongTinDiChuyen> ThongTinDiChuyens { get; set; }
        public virtual DbSet<ThongTinLienLac> ThongTinLienLacs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=ToKhaiYTe;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Days>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("days");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("district");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Prefix)
                    .HasColumnName("_prefix")
                    .HasMaxLength(20);

                entity.Property(e => e.ProvinceId).HasColumnName("_province_id");
            });

            modelBuilder.Entity<Gates>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gates");

                entity.Property(e => e.GateName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Months>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("months");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Month).HasColumnName("month");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("province");

                entity.Property(e => e.Code)
                    .HasColumnName("_code")
                    .HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ward");

                entity.Property(e => e.DistrictId).HasColumnName("_district_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Prefix)
                    .HasColumnName("_prefix")
                    .HasMaxLength(20);

                entity.Property(e => e.ProvinceId).HasColumnName("_province_id");
            });

            modelBuilder.Entity<Years>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("years");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Year).HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
