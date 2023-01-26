using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Models;


namespace ComputeYourself.Controllers
{
    public class CpuController : CrudControllerBase<Cpu, ICPUService>
    {
        public CpuController(ICPUService service) : base(service)
        {
        }
    }
}