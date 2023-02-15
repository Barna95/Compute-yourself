using API.Data.Services.CpuCooler;
using API.Models;

namespace API.Controllers;

public class CpuCoolerController : CrudControllerBase<CpuCooler, ICpuCoolerService>
{
    public CpuCoolerController(ICpuCoolerService service) : base(service)
    {
    }
}