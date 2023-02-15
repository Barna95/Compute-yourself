using API.Data.Services.MotherBoard;
using API.Models;

namespace API.Controllers;

public class MotherBoardController : CrudControllerBase<MotherBoard, IMotherBoardService>
{
    public MotherBoardController(IMotherBoardService service) : base(service)
    {
    }
}