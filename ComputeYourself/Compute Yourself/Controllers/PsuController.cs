using API.Data.Services.PSU;
using API.Models;

namespace API.Controllers;

public class PsuController : CrudControllerBase<Psu, IPsuService>
{
    public PsuController(IPsuService service) : base(service)
    {
    }
}