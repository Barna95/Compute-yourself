using API.Models;
using API.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<IdentityRole>()
        //    .HasData(
        //        new IdentityRole { Name = "Member", NormalizedName = "MEMBER"},
        //        new IdentityRole { Name = "Admin", NormalizedName = "ADMIN"});
    }
}