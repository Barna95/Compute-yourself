using API.Data.Services.CPU;
using API.Models;

namespace API.Controllers;

public class CpuController : CrudControllerBase<Cpu, ICPUService>
{
    public CpuController(ICPUService service) : base(service)
    {
    }
}