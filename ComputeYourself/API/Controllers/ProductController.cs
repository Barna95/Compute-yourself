using API.Data.Services.CPU;
using API.Data.Services.CpuCooler;
using API.Data.Services.Drive;
using API.Data.Services.GPU;
using API.Data.Services.MotherBoard;
using API.Data.Services.PcCase;
using API.Data.Services.PSU;
using API.Data.Services.RAM;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ICpuCoolerService _cpuCoolerService;
    private readonly ICPUService _cpuService;
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
        var products = new List<IEnumerable<Product>>
        {
            await _cpuService.GetAllAsync(),
            await _cpuCoolerService.GetAllAsync(),
            await _driveService.GetAllAsync(),
            await _gpuService.GetAllAsync(),
            await _motherBoardService.GetAllAsync(),
            await _pcCaseService.GetAllAsync(),
            await _psuService.GetAllAsync(),
            await _ramService.GetAllAsync()
        };
        return Ok(products);
    }
}