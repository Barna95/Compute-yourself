using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.RAM;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class RamController : CrudControllerBase<Ram, IRAMService>
    {
        public RamController(IRAMService service) : base(service)
        {
        }
    }
}
