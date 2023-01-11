using ComputeYourself.Data;
using ComputeYourself.Data.Services.CPU;
using ComputeYourself.Data.Services.CpuCooler;
using ComputeYourself.Data.Services.Drive;
using ComputeYourself.Data.Services.GPU;
using ComputeYourself.Data.Services.MotherBoard;
using ComputeYourself.Data.Services.PcCase;
using ComputeYourself.Data.Services.PSU;
using ComputeYourself.Data.Services.RAM;
using ComputeYourself.Models.CPU;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult> GetProductTest()
        {
            var cpus = await _cpuService.GetAllAsync();
            if (cpus == null)
            {
                return NotFound();
            }

            return Ok(cpus);
        }

        [HttpPost]
        public async Task<IActionResult> PostProductTest([FromBody] Cpu cpu)
        {
            if (cpu is null)
            {
                return NotFound();
            }

            var newProduct = await _cpuService.AddAsync(cpu);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(cpu);
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> PutProductTest(int productId, [FromBody] Cpu cpu)
        {
            cpu.Id = productId;
            if (productId != cpu.Id)
            {
                return BadRequest();
            }

            await _cpuService.UpdateAsync(productId, cpu);
            return Ok(cpu);
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteProductTest(int productId)
        {
            await _cpuService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }
    }
}
