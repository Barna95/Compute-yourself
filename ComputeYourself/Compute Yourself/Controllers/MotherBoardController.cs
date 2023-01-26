using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.MotherBoard;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class MotherBoardController : CrudControllerBase<MotherBoard, IMotherBoardService>
    {
        public MotherBoardController(IMotherBoardService service) : base(service)
        {
        }
    }
}
