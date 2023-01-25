using ComputeYourself.Data.Services.Base;

namespace ComputeYourself.Data.Services.Drive
{
    public class DriveService : BaseService<Models.Drive>, IDriveService
    {
        private readonly AppDbContext _context;

        public DriveService(AppDbContext context) : base(context)
        {

        }
    }
}