using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.CpuCooler;
using ComputeYourself.Data.Services.Drive;
using ComputeYourself.Data.Services.GPU;
using ComputeYourself.Data.Services.MotherBoard;
using ComputeYourself.Data.Services.PcCase;
using ComputeYourself.Data.Services.PSU;
using ComputeYourself.Data.Services.RAM;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace ComputeYourself.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICPUService _cpuService;
        private readonly ICpuCoolerService _cpuCoolerService;
        private readonly IDriveService _driveService;
        private readonly IGPUService _gpuService;
        private readonly IMotherBoardService _motherBoardService;
        private readonly IPcCaseService _pcCaseService;
        private readonly IPsuService _psuService;
        private readonly IRAMService _ramService;

        public ProductController(ICPUService cpuService, ICpuCoolerService cpuCoolerService, IDriveService driveService,
            IGPUService gpuService, IMotherBoardService motherBoardService, IPcCaseService pcCaseService,
            IPsuService psuService, IRAMService ramService)
        {
            _cpuService = cpuService;
            _cpuCoolerService = cpuCoolerService;
            _driveService = driveService;
            _gpuService = gpuService;
            _motherBoardService = motherBoardService;
            _pcCaseService = pcCaseService;
            _psuService = psuService;
            _ramService = ramService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            List<IEnumerable<Product>> products = new List<IEnumerable<Product>>()
            {
                await _cpuService.GetAllAsync(),
                await _cpuCoolerService.GetAllAsync(),
                await _driveService.GetAllAsync(),
                await _gpuService.GetAllAsync(),
                await _motherBoardService.GetAllAsync(),
                await _pcCaseService.GetAllAsync(),
                await _psuService.GetAllAsync(),
                await _ramService.GetAllAsync(),
            };
            return Ok(products);
        }
    }
}
