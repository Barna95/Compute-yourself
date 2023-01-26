using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.PSU;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class PsuController : CrudControllerBase<Psu, IPsuService>
    {
        public PsuController(IPsuService service) : base(service)
        {
        }
    }
}
