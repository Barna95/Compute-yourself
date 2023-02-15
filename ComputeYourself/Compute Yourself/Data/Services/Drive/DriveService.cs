using API.Data.Services.Base;

namespace API.Data.Services.Drive;

public class DriveService : BaseService<Models.Drive>, IDriveService
{
    private readonly AppDbContext _context;

    public DriveService(AppDbContext context) : base(context)
    {
    }
}