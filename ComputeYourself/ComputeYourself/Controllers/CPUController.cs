using ComputeYourself.Data.Services;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class CPUController : Controller
    {
        private readonly ICPUService _service;

        public CPUController(ICPUService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCPUs = await _service.GetAllAsync();
            return View(allCPUs);
        }

        // Get -> CPU/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind(@"Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                Socket,
                                ManufacturerCooler,
                                L3Cache,
                                TotalCache,
                                Cores,
                                Threads,
                                Igpu,
                                TDP,
                                CoreClock,
                                TurboCoreClock")]
            CPU cpu)
        {
            if (!ModelState.IsValid)
            {
                return View(cpu);
            }

            await _service.AddAsync(cpu);
            return RedirectToAction(nameof(Index));
        }

        // Get -> CPU/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var CPUDetails = await _service.GetByIdAsync(id);
            if (CPUDetails == null)
            {
                return View("NotFound");
            }
            return View(CPUDetails);
        }

        // Get -> CPU/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var CPUDetails = await _service.GetByIdAsync(id);
            if (CPUDetails == null)
            {
                return View("NotFound");
            }
            return View(CPUDetails);
        }

        
        [HttpPost]
        public async Task<IActionResult> Edit(int id,
            [Bind(@"Id,
                                Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                Socket,
                                ManufacturerCooler,
                                L3Cache,
                                TotalCache,
                                Cores,
                                Threads,
                                Igpu,
                                TDP,
                                CoreClock,
                                TurboCoreClock")]
            CPU cpu)
        {
            if (!ModelState.IsValid)
            {
                return View(cpu);
            }

            await _service.UpdateAsync(id, cpu);
            return RedirectToAction(nameof(Index));
        }

        // Get -> CPU/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var CPUDetails = await _service.GetByIdAsync(id);
            if (CPUDetails == null)
            {
                return View("NotFound");
            }
            return View(CPUDetails);
        }

        
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var CPUDetails = await _service.GetByIdAsync(id);
            if (CPUDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
