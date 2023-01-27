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
            
        }

        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<CpuCooler> CpuCoolers { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Gpu> Gpus { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
        public DbSet<PcCase> PcCases { get; set; }
        public DbSet<Psu> Psus { get; set; }
        public DbSet<Ram> Rams { get; set; }
    }
}