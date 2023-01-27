using ComputeYourself.Data.Services.Drive;
using ComputeYourself.Models;


namespace ComputeYourself.Controllers
{
    public class DriveController : CrudControllerBase<Drive, IDriveService>
    {
        public DriveController(IDriveService service) : base(service)
        {
        }
    }
}