using ComputeYourself.Data.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services
{
    public class DriveService : BaseService<Drive>, IDriveService
    {
        private readonly AppDbContext _context;

        public DriveService(AppDbContext context) : base(context)
        {
            
        }
    }
}
