using ComputeYourself.Data;
using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.CpuCooler;
using ComputeYourself.Data.Services.Drive;
using ComputeYourself.Data.Services.GPU;
using ComputeYourself.Data.Services.MotherBoard;
using ComputeYourself.Data.Services.PcCase;
using ComputeYourself.Data.Services.PSU;
using ComputeYourself.Data.Services.RAM;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ComputeYourself
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AppDbContext>(options => options
                .UseSqlServer(builder.Configuration
                    .GetConnectionString("DefaultConnectionString")));
            builder.Host.UseSerilog((ctx, lc) => lc
                .WriteTo.Console()
                // if you want everything, change Warning() to Information()
                .WriteTo.File("D:\\ComputeLogs\\log.txt").MinimumLevel.Information()
                .WriteTo.File("D:\\ComputeLogs\\structuredLog.json").MinimumLevel.Information());
            // Service config
            builder.Services.AddScoped<IPcCaseService, PcCaseService>();
            builder.Services.AddScoped<IGPUService, GPUService>();
            builder.Services.AddScoped<IDriveService, DriveService>();
            builder.Services.AddScoped<IMotherBoardService, MotherBoardService>();
            builder.Services.AddScoped<IRAMService, RAMService>();
            builder.Services.AddScoped<IPsuService, PsuService>();
            builder.Services.AddScoped<ICpuCoolerService, CpuCoolerService>();
            builder.Services.AddScoped<ICPUService, CPUService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            AppDbInitializer.Seed(app);
            app.Run();
        }
    }
}