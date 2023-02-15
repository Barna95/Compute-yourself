using API.Data.Services.GPU;
using API.Models;

namespace API.Controllers;

public class GpuController : CrudControllerBase<Gpu, IGPUService>
{
    public GpuController(IGPUService service) : base(service)
    {
    }
}