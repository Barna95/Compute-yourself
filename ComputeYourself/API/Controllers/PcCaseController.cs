using API.Data.Services.PcCase;
using API.Models;

namespace API.Controllers;

public class PcCaseController : CrudControllerBase<PcCase, IPcCaseService>
{
    public PcCaseController(IPcCaseService service) : base(service)
    {
    }
}