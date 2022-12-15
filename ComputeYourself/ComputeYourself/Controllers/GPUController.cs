using ComputeYourself.Data.Services;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class GPUController : Controller
    {
        private readonly IGPUService _service;

        public GPUController(IGPUService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allGPUs = await _service.GetAllAsync();
            return View(allGPUs);
        }

        // Get -> GPU/Create
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
                                VideoChipset,
                                VramSize,
                                VramType,
                                RequiredPSU,
                                Length")]
            GPU gpu)
        {
            if (!ModelState.IsValid)
            {
                return View(gpu);
            }

            await _service.AddAsync(gpu);
            return RedirectToAction(nameof(Index));
        }

        // Get -> GPU/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var GPUDetails = await _service.GetByIdAsync(id);
            if (GPUDetails == null)
            {
                return View("NotFound");
            }
            return View(GPUDetails);
        }

        // Get -> GPU/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var GPUDetails = await _service.GetByIdAsync(id);
            if (GPUDetails == null)
            {
                return View("NotFound");
            }
            return View(GPUDetails);
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
                                VideoChipset,
                                VramSize,
                                VramType,
                                RequiredPSU,
                                Length")]
            GPU gpu)
        {
            if (!ModelState.IsValid)
            {
                return View(gpu);
            }

            await _service.UpdateAsync(id, gpu);
            return RedirectToAction(nameof(Index));
        }

        // Get -> GPU/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var GPUDetails = await _service.GetByIdAsync(id);
            if (GPUDetails == null)
            {
                return View("NotFound");
            }
            return View(GPUDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var GPUDetails = await _service.GetByIdAsync(id);
            if (GPUDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
