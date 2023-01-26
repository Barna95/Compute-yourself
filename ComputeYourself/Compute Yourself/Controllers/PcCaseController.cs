using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.PcCase;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class PcCaseController : CrudControllerBase<PcCase, IPcCaseService>
    {
        public PcCaseController(IPcCaseService service) : base(service)
        {
        }
    }
}
