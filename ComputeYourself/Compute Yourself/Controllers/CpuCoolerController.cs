using ComputeYourself.Data.Services.CpuCooler;
using ComputeYourself.Models;


namespace ComputeYourself.Controllers
{
    public class CpuCoolerController : CrudControllerBase<CpuCooler, ICpuCoolerService>
    {
        public CpuCoolerController(ICpuCoolerService service) : base(service)
        {
        }
    }
}