using ComputeYourself.Models;
using Microsoft.EntityFrameworkCore;

namespace ComputeYourself.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CPU>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<CpuCooler>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Drive>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<GPU>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<MotherBoard>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PcCase>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PSU>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<RAM>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<PcCase_Media>().HasKey(pm => new
            {
                pm.PcCaseId,
                pm.MediaId
            });

            modelBuilder.Entity<PcCase_Media>()
                .HasOne(p => p.PcCase)
                .WithMany(pm => pm.PcCaseMedias)
                .HasForeignKey(p => p.PcCaseId);

            modelBuilder.Entity<PcCase_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.PcCaseMedias)
                .HasForeignKey(p => p.MediaId);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<CPU> Cpus { get; set; }
        public DbSet<CpuCooler> CpuCoolers { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<GPU> Gpus { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
        public DbSet<PcCase> PcCases { get; set; }
        public DbSet<PSU> Psus { get; set; }
        public DbSet<RAM> Rams { get; set; }

        // Relationships
        public DbSet<PcCase_Media> PcCaseMedias { get; set; }
        public DbSet<Media> Medias { get; set; }

    }
}
