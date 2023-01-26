using ComputeYourself.Data.Services.Drive;
using ComputeYourself.Data.Services.GPU;
using ComputeYourself.Models;


namespace ComputeYourself.Controllers
{
    public class GpuController : CrudControllerBase<Gpu, IGPUService>
    {
        public GpuController(IGPUService service) : base(service)
        {
        }
    }
}