using ComputeYourself.Models;
using ComputeYourself.Models.CPU;
using ComputeYourself.Models.CpuCooler;
using ComputeYourself.Models.Drive;
using ComputeYourself.Models.GPU;
using ComputeYourself.Models.MotherBoard;
using ComputeYourself.Models.PcCase;
using ComputeYourself.Models.PSU;
using ComputeYourself.Models.RAM;
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

            modelBuilder.Entity<Cpu_Media>().HasKey(pm => new
            {
                pm.CpuId,
                pm.MediaId
            });

            modelBuilder.Entity<CpuCooler_Media>().HasKey(pm => new
            {
                pm.CpuCoolerId,
                pm.MediaId
            });

            modelBuilder.Entity<Drive_Media>().HasKey(pm => new
            {
                pm.DriveId,
                pm.MediaId
            });

            modelBuilder.Entity<Gpu_Media>().HasKey(pm => new
            {
                pm.GpuId,
                pm.MediaId
            });

            modelBuilder.Entity<MotherBoard_Media>().HasKey(pm => new
            {
                pm.MotherBoardId,
                pm.MediaId
            });

            modelBuilder.Entity<PcCase_Media>().HasKey(pm => new
            {
                pm.PcCaseId,
                pm.MediaId
            });

            modelBuilder.Entity<Psu_Media>().HasKey(pm => new
            {
                pm.PsuId,
                pm.MediaId
            });

            modelBuilder.Entity<Ram_Media>().HasKey(pm => new
            {
                pm.RamId,
                pm.MediaId
            });

            //CPU connection through table to media
            modelBuilder.Entity<Cpu_Media>()
                .HasOne(p => p.Cpu)
                .WithMany(pm => pm.Cpu_Medias)
                .HasForeignKey(p => p.CpuId);

            modelBuilder.Entity<Cpu_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.Cpu_Medias)
                .HasForeignKey(p => p.MediaId);

            // CpuCooler connection through table to media
            modelBuilder.Entity<CpuCooler_Media>()
                .HasOne(p => p.Cpucooler)
                .WithMany(pm => pm.CpuCooler_Medias)
                .HasForeignKey(p => p.CpuCoolerId);

            modelBuilder.Entity<CpuCooler_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.CpuCooler_Medias)
                .HasForeignKey(p => p.MediaId);

            //Drive connection through table to media
            modelBuilder.Entity<Drive_Media>()
                .HasOne(p => p.Drive)
                .WithMany(pm => pm.Drive_Medias)
                .HasForeignKey(p => p.DriveId);

            modelBuilder.Entity<Drive_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.Drive_Medias)
                .HasForeignKey(p => p.MediaId);

            //GPU connection through table to media
            modelBuilder.Entity<Gpu_Media>()
                .HasOne(p => p.Gpu)
                .WithMany(pm => pm.Gpu_Medias)
                .HasForeignKey(p => p.GpuId);

            modelBuilder.Entity<Gpu_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.Gpu_Medias)
                .HasForeignKey(p => p.MediaId);

            //MotherBoard connection through table to media
            modelBuilder.Entity<MotherBoard_Media>()
                .HasOne(p => p.MotherBoard)
                .WithMany(pm => pm.MotherBoard_Medias)
                .HasForeignKey(p => p.MotherBoardId);

            modelBuilder.Entity<MotherBoard_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.MotherBoard_Medias)
                .HasForeignKey(p => p.MediaId);

            //PcCase connection through table to media
            modelBuilder.Entity<PcCase_Media>()
                .HasOne(p => p.PcCase)
                .WithMany(pm => pm.PcCaseMedias)
                .HasForeignKey(p => p.PcCaseId);

            modelBuilder.Entity<PcCase_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.PcCaseMedias)
                .HasForeignKey(p => p.MediaId);

            //PSU connection through table to media
            modelBuilder.Entity<Psu_Media>()
                .HasOne(p => p.Psu)
                .WithMany(pm => pm.Psu_Medias)
                .HasForeignKey(p => p.PsuId);

            modelBuilder.Entity<Psu_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.Psu_Medias)
                .HasForeignKey(p => p.MediaId);

            //RAM connection through table to media
            modelBuilder.Entity<Ram_Media>()
                .HasOne(p => p.Ram)
                .WithMany(pm => pm.Ram_Medias)
                .HasForeignKey(p => p.RamId);

            modelBuilder.Entity<Ram_Media>()
                .HasOne(p => p.Media)
                .WithMany(pm => pm.Ram_Medias)
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
        public DbSet<Media> Medias { get; set; }
        public DbSet<Cpu_Media> CpuMedias { get; set; }
        public DbSet<CpuCooler_Media> CpuCoolerMedias { get; set; }
        public DbSet<Drive_Media> DriveMedias { get; set; }
        public DbSet<Gpu_Media> GpuMedias { get; set; }
        public DbSet<MotherBoard_Media> MotherBoardMedias { get; set; }
        public DbSet<PcCase_Media> PcCaseMedias { get; set; }
        public DbSet<Psu_Media> PsuMedias { get; set; }
        public DbSet<Ram_Media> RamMedias { get; set; }
    }
}