using ComputeYourself.Data;
using ComputeYourself.Data.Services;
using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.CpuCooler;
using ComputeYourself.Data.Services.Drive;
using ComputeYourself.Data.Services.GPU;
using ComputeYourself.Data.Services.MotherBoard;
using ComputeYourself.Data.Services.PcCase;
using ComputeYourself.Data.Services.PSU;
using ComputeYourself.Data.Services.RAM;
using ComputeYourself.Models.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;

namespace ComputeYourself
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            var provider = builder.Services.BuildServiceProvider();
            var configuration = provider.GetRequiredService<IConfiguration>();

            builder.Services.AddCors(options =>
            {
                var frontendUrl = configuration.GetValue<string>("frontend_url");
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(frontendUrl).AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                });
            });
            
            builder.Services.AddDbContext<AppDbContext>(options => options
                .UseSqlServer(builder.Configuration
                    .GetConnectionString("DefaultConnectionString")));
            builder.Services.AddIdentityCore<User>(opt =>
                {
                    opt.User.RequireUniqueEmail = true;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            builder.Services.AddDbContext<AppDbContext>(options => options.EnableSensitiveDataLogging());
            builder.Host.UseSerilog((ctx, lc) => lc
                .WriteTo.Console()
                // if you want everything, change Warning() to Information()
                .WriteTo.File("D:\\ComputeLogs\\log.txt").MinimumLevel.Warning()
                .WriteTo.File("D:\\ComputeLogs\\structuredLog.json").MinimumLevel.Warning());
            // Service config
            
            builder.Services.AddScoped<IPcCaseService, PcCaseService>();
            builder.Services.AddScoped<IGPUService, GPUService>();
            builder.Services.AddScoped<IDriveService, DriveService>();
            builder.Services.AddScoped<IMotherBoardService, MotherBoardService>();
            builder.Services.AddScoped<IRAMService, RAMService>();
            builder.Services.AddScoped<IPsuService, PsuService>();
            builder.Services.AddScoped<ICpuCoolerService, CpuCoolerService>();
            builder.Services.AddScoped<ICPUService, CPUService>();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        // Our local host is the issuer
                        ValidateIssuer = false,
                        // Clients on our local host 
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        // Checking the secret key in the token, matches the signature
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWTSettings:TokenKey"]))
                    };
                });
            builder.Services.AddAuthorization();
            builder.Services.AddScoped<TokenService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseCors();
            

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            AppDbInitializer.Seed(app);

            AppDbInitializer.SeedUsersAndRolesAsync(app).Wait();

            app.Run();
        }
    }
}