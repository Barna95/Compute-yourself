using API.Data.Services.Drive;
using API.Models;

namespace API.Controllers;

public class DriveController : CrudControllerBase<Drive, IDriveService>
{
    public DriveController(IDriveService service) : base(service)
    {
    }
}