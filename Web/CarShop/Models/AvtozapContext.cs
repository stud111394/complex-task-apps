using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarShop.Models
{
    public partial class AvtozapContext : DbContext
    {
        public AvtozapContext()
        {
        }

        public AvtozapContext(DbContextOptions<AvtozapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarZap> CarZap { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Dolzhnost> Dolzhnost { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Postavshiki> Postavshiki { get; set; }
        public virtual DbSet<Prodazha> Prodazha { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudnik { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=Avtozap; User Id=postgres; Password=1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.IdCar)
                    .HasName("Car_pkey");

                entity.ToTable("car");

                entity.Property(e => e.IdCar)
                    .HasColumnName("idCar")
                    .ValueGeneratedNever();

                entity.Property(e => e.GodVypuska).HasColumnName("godVypuska");

                entity.Property(e => e.Marka)
                    .IsRequired()
                    .HasColumnName("marka");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model");
            });

            modelBuilder.Entity<CarZap>(entity =>
            {
                entity.HasKey(e => e.IdCarZap)
                    .HasName("carZap_pkey");

                entity.ToTable("carZap");

                entity.Property(e => e.IdCarZap)
                    .HasColumnName("idCarZap")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cena)
                    .HasColumnName("cena")
                    .HasColumnType("money");

                entity.Property(e => e.IdCar).HasColumnName("idCar");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.IdPostav).HasColumnName("idPostav");

                entity.Property(e => e.ImgLink).HasColumnName("imgLink");

                entity.Property(e => e.Nazvanie)
                    .IsRequired()
                    .HasColumnName("nazvanie");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasColumnName("cat_name");
            });

            modelBuilder.Entity<Dolzhnost>(entity =>
            {
                entity.HasKey(e => e.IdDolzhnost)
                    .HasName("dolzhnost_pkey");

                entity.ToTable("dolzhnost");

                entity.Property(e => e.IdDolzhnost)
                    .HasColumnName("idDolzhnost")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nazvanie)
                    .IsRequired()
                    .HasColumnName("nazvanie");
            });

            modelBuilder.Entity<Klient>(entity =>
            {
                entity.HasKey(e => e.IdKlient)
                    .HasName("klient_pkey");

                entity.ToTable("klient");

                entity.Property(e => e.IdKlient)
                    .HasColumnName("idKlient")
                    .ValueGeneratedNever();

                entity.Property(e => e.F)
                    .IsRequired()
                    .HasColumnName("f");

                entity.Property(e => e.I)
                    .IsRequired()
                    .HasColumnName("i");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Postavshiki>(entity =>
            {
                entity.HasKey(e => e.IdPostav)
                    .HasName("postavshiki_pkey");

                entity.ToTable("postavshiki");

                entity.Property(e => e.IdPostav)
                    .HasColumnName("idPostav")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnName("adress");

                entity.Property(e => e.NameOrgan)
                    .IsRequired()
                    .HasColumnName("nameOrgan");

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Prodazha>(entity =>
            {
                entity.HasKey(e => e.IdProdazhi)
                    .HasName("prodazha_pkey");

                entity.ToTable("prodazha");

                entity.Property(e => e.IdProdazhi)
                    .HasColumnName("idProdazhi")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataPokupki)
                    .HasColumnName("dataPokupki")
                    .HasColumnType("date");

                entity.Property(e => e.IdCarZap).HasColumnName("idCarZap");

                entity.Property(e => e.IdKlient).HasColumnName("idKlient");

                entity.Property(e => e.IdSotr).HasColumnName("idSotr");

                entity.Property(e => e.IdStatus).HasColumnName("idStatus");

                entity.Property(e => e.Kolichestvo).HasColumnName("kolichestvo");
            });

            modelBuilder.Entity<Sotrudnik>(entity =>
            {
                entity.HasKey(e => e.IdSotr)
                    .HasName("sotrudnik_pkey");

                entity.ToTable("sotrudnik");

                entity.Property(e => e.IdSotr)
                    .HasColumnName("idSotr")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdDolzhnost).HasColumnName("idDolzhnost");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Parol)
                    .IsRequired()
                    .HasColumnName("parol");

                entity.Property(e => e.PersInf)
                    .IsRequired()
                    .HasColumnName("persInf");

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("status_pkey");

                entity.ToTable("status");

                entity.Property(e => e.IdStatus)
                    .HasColumnName("idStatus")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nazvanie)
                    .IsRequired()
                    .HasColumnName("nazvanie");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
