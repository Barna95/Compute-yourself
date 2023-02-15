using API.Data.Services.RAM;
using API.Models;

namespace API.Controllers;

public class RamController : CrudControllerBase<Ram, IRAMService>
{
    public RamController(IRAMService service) : base(service)
    {
    }
}