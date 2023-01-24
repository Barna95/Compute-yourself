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
using ComputeYourself.Models.CpuCooler;
using ComputeYourself.Models.Drive;
using ComputeYourself.Models.GPU;
using ComputeYourself.Models.MotherBoard;
using ComputeYourself.Models.PcCase;
using ComputeYourself.Models.PSU;
using ComputeYourself.Models.RAM;
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

        // Cpu
        [HttpGet("cpu")]
        public async Task<ActionResult> GetCpus()
        {
            var cpus = await _cpuService.GetAllAsync();
            if (cpus == null)
            {
                return NotFound();
            }

            return Ok(cpus);
        }

        [HttpGet("cpu/{id}")]
        public async Task<ActionResult> GetCpuById(int id)
        {
            var cpus = await _cpuService.GetByIdAsync(id);
            if (cpus == null)
            {
                return NotFound();
            }

            return Ok(cpus);
        }


        [HttpPost("cpu")]
        public async Task<IActionResult> AddCpu([FromBody] Cpu cpu)
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

        [HttpPut("cpu/{productId}")]
        public async Task<IActionResult> UpdateCpu(int productId, [FromBody] Cpu cpu)
        {
            cpu.Id = productId;
            if (productId != cpu.Id)
            {
                return BadRequest();
            }

            await _cpuService.UpdateAsync(productId, cpu);
            return Ok(cpu);
        }

        [HttpDelete("cpu/{productId}")]
        public async Task<IActionResult> DeleteCpu(int productId)
        {
            await _cpuService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }

        // CpuCooler
        [HttpGet("cpucooler")]
        public async Task<ActionResult> GetCpuCoolers()
        {
            var cpuCoolers = await _cpuCoolerService.GetAllAsync();
            if (cpuCoolers == null)
            {
                return NotFound();
            }

            return Ok(cpuCoolers);
        }

        [HttpGet("cpucooler/{id}")]
        public async Task<ActionResult> GetCpuCoolerById(int id)
        {
            var cpuCoolers = await _cpuCoolerService.GetByIdAsync(id);
            if (cpuCoolers == null)
            {
                return NotFound();
            }

            return Ok(cpuCoolers);
        }

        [HttpPost("cpucooler")]
        public async Task<IActionResult> AddCpuCooler([FromBody] CpuCooler cpuCooler)
        {
            if (cpuCooler is null)
            {
                return NotFound();
            }

            var newProduct = await _cpuCoolerService.AddAsync(cpuCooler);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(cpuCooler);
        }

        [HttpPut("cpucooler/{productId}")]
        public async Task<IActionResult> UpdateCpuCooler(int productId, [FromBody] CpuCooler cpuCooler)
        {
            cpuCooler.Id = productId;
            if (productId != cpuCooler.Id)
            {
                return BadRequest();
            }

            await _cpuCoolerService.UpdateAsync(productId, cpuCooler);
            return Ok(cpuCooler);
        }

        [HttpDelete("cpucooler/{productId}")]
        public async Task<IActionResult> DeleteCpuCooler(int productId)
        {
            await _cpuCoolerService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }

        // Drive
        [HttpGet("drive")]
        public async Task<ActionResult> GetDrives()
        {
            var drives = await _driveService.GetAllAsync();
            if (drives == null)
            {
                return NotFound();
            }

            return Ok(drives);
        }

        [HttpPost("drive")]
        public async Task<IActionResult> AddDrive([FromBody] Drive drive)
        {
            if (drive is null)
            {
                return NotFound();
            }

            var newProduct = await _driveService.AddAsync(drive);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(drive);
        }

        [HttpPut("drive/{productId}")]
        public async Task<IActionResult> UpdateDrive(int productId, [FromBody] Drive drive)
        {
            drive.Id = productId;
            if (productId != drive.Id)
            {
                return BadRequest();
            }

            await _driveService.UpdateAsync(productId, drive);
            return Ok(drive);
        }

        [HttpDelete("drive/{productId}")]
        public async Task<IActionResult> DeleteDrive(int productId)
        {
            await _driveService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }

        // Gpu
        [HttpGet("gpu")]
        public async Task<ActionResult> GetGpus()
        {
            var gpus = await _gpuService.GetAllAsync();
            if (gpus == null)
            {
                return NotFound();
            }

            return Ok(gpus);
        }

        [HttpPost("gpu")]
        public async Task<IActionResult> AddGpu([FromBody] Gpu gpu)
        {
            if (gpu is null)
            {
                return NotFound();
            }

            var newProduct = await _gpuService.AddAsync(gpu);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(gpu);
        }

        [HttpPut("gpu/{productId}")]
        public async Task<IActionResult> UpdateGpu(int productId, [FromBody] Gpu gpu)
        {
            gpu.Id = productId;
            if (productId != gpu.Id)
            {
                return BadRequest();
            }

            await _gpuService.UpdateAsync(productId, gpu);
            return Ok(gpu);
        }

        [HttpDelete("gpu/{productId}")]
        public async Task<IActionResult> DeleteGpu(int productId)
        {
            await _gpuService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }

        // MotherBoard
        [HttpGet("motherboard")]
        public async Task<ActionResult> GetMotherBoards()
        {
            var motherBoards = await _motherBoardService.GetAllAsync();
            if (motherBoards == null)
            {
                return NotFound();
            }

            return Ok(motherBoards);
        }

        [HttpPost("motherboard")]
        public async Task<IActionResult> AddMotherBoard([FromBody] MotherBoard motherboard)
        {
            if (motherboard is null)
            {
                return NotFound();
            }

            var newProduct = await _motherBoardService.AddAsync(motherboard);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(motherboard);
        }

        [HttpPut("motherboard/{productId}")]
        public async Task<IActionResult> UpdateMotherBoard(int productId, [FromBody] MotherBoard motherboard)
        {
            motherboard.Id = productId;
            if (productId != motherboard.Id)
            {
                return BadRequest();
            }

            await _motherBoardService.UpdateAsync(productId, motherboard);
            return Ok(motherboard);
        }

        [HttpDelete("motherboard/{productId}")]
        public async Task<IActionResult> DeleteMotherBoard(int productId)
        {
            await _motherBoardService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }

        // PcCase
        [HttpGet("pccase")]
        public async Task<ActionResult> GetPcCases()
        {
            var pcCases = await _pcCaseService.GetAllAsync();
            if (pcCases == null)
            {
                return NotFound();
            }

            return Ok(pcCases);
        }

        [HttpPost("pccase")]
        public async Task<IActionResult> AddPcCase([FromBody] PcCase pcCase)
        {
            if (pcCase is null)
            {
                return NotFound();
            }

            var newProduct = await _pcCaseService.AddAsync(pcCase);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(pcCase);
        }

        [HttpPut("pccase/{productId}")]
        public async Task<IActionResult> UpdatePcCase(int productId, [FromBody] PcCase pcCase)
        {
            pcCase.Id = productId;
            if (productId != pcCase.Id)
            {
                return BadRequest();
            }

            await _pcCaseService.UpdateAsync(productId, pcCase);
            return Ok(pcCase);
        }

        [HttpDelete("pccase/{productId}")]
        public async Task<IActionResult> DeletePcCase(int productId)
        {
            await _pcCaseService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }

        // Psu
        [HttpGet("psu")]
        public async Task<ActionResult> GetPsus()
        {
            var psus = await _psuService.GetAllAsync();
            if (psus == null)
            {
                return NotFound();
            }

            return Ok(psus);
        }

        [HttpPost("psu")]
        public async Task<IActionResult> AddPsu([FromBody] Psu psu)
        {
            if (psu is null)
            {
                return NotFound();
            }

            var newProduct = await _psuService.AddAsync(psu);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(psu);
        }

        [HttpPut("psu/{productId}")]
        public async Task<IActionResult> UpdatePsu(int productId, [FromBody] Psu psu)
        {
            psu.Id = productId;
            if (productId != psu.Id)
            {
                return BadRequest();
            }

            await _psuService.UpdateAsync(productId, psu);
            return Ok(psu);
        }

        [HttpDelete("psu/{productId}")]
        public async Task<IActionResult> DeletePsu(int productId)
        {
            await _psuService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }

        // Ram
        [HttpGet("ram")]
        public async Task<ActionResult> Getrams()
        {
            var rams = await _ramService.GetAllAsync();
            if (rams == null)
            {
                return NotFound();
            }

            return Ok(rams);
        }

        [HttpPost("ram")]
        public async Task<IActionResult> AddRam([FromBody] Ram ram)
        {
            if (ram is null)
            {
                return NotFound();
            }

            var newProduct = await _ramService.AddAsync(ram);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(ram);
        }

        [HttpPut("ram/{productId}")]
        public async Task<IActionResult> UpdateRam(int productId, [FromBody] Ram ram)
        {
            ram.Id = productId;
            if (productId != ram.Id)
            {
                return BadRequest();
            }

            await _ramService.UpdateAsync(productId, ram);
            return Ok(ram);
        }

        [HttpDelete("ram/{productId}")]
        public async Task<IActionResult> DeleteRam(int productId)
        {
            await _ramService.DeleteAsync(productId);
            return Ok($"{productId} got deleted!");
        }
    }
}
