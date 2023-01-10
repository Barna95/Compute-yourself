using ComputeYourself.Data.Services.RAM;
using ComputeYourself.Models.RAM;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class RAMController : Controller
    {
        private readonly IRAMService _service;

        public RAMController(IRAMService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allRams = await _service.GetAllAsync();
            return View(allRams);
        }

        // Get -> RAM/Create
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
                                Size,
                                MemoryType,
                                Frequency,
                                Latency,
                                HeatSink")] RAM ram)
        {
            if (!ModelState.IsValid)
            {
                return View(ram);
            }
            await _service.AddAsync(ram);
            return RedirectToAction(nameof(Index));
        }

        // Get -> RAM/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var RAMDetails = await _service.GetByIdAsync(id);
            if (RAMDetails == null)
            {
                return View("NotFound");
            }
            return View(RAMDetails);
        }

        // Get -> RAM/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var RAMDetails = await _service.GetByIdAsync(id);
            if (RAMDetails == null)
            {
                return View("NotFound");
            }
            return View(RAMDetails);
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
                                Size,
                                MemoryType,
                                Frequency,
                                Latency,
                                HeatSink")] RAM ram)
        {
            if (!ModelState.IsValid)
            {
                return View(ram);
            }
            await _service.UpdateAsync(id, ram);
            return RedirectToAction(nameof(Index));
        }

        // Get -> RAM/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var RAMDetails = await _service.GetByIdAsync(id);
            if (RAMDetails == null)
            {
                return View("NotFound");
            }
            return View(RAMDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var RAMDetails = await _service.GetByIdAsync(id);
            if (RAMDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}