using ComputeYourself.Models;
using ComputeYourself.Models.Basket;
using ComputeYourself.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComputeYourself.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<IdentityRole>()
            //    .HasData(
            //        new IdentityRole { Name = "Member", NormalizedName = "MEMBER"},
            //        new IdentityRole { Name = "Admin", NormalizedName = "ADMIN"});
        }

        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<CpuCooler> CpuCoolers { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Gpu> Gpus { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
        public DbSet<PcCase> PcCases { get; set; }
        public DbSet<Psu> Psus { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}