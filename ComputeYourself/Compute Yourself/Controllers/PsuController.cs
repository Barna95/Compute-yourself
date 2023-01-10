using ComputeYourself.Data.Services.PSU;
using ComputeYourself.Models.PSU;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class PsuController : Controller
    {
        private readonly IPsuService _service;

        public PsuController(IPsuService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allPsus = await _service.GetAllAsync();
            return View(allPsus);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind(@"Capacity,
                                Modular,
                                Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                Classification")] PSU psu)
        {
            if (!ModelState.IsValid)
            {
                return View(psu);
            }
            await _service.AddAsync(psu);
            return RedirectToAction(nameof(Index));
        }

        // Get -> PcCase/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var psuDetails = await _service.GetByIdAsync(id);
            if (psuDetails == null)
            {
                return View("NotFound");
            }
            return View(psuDetails);
        }

        // Get -> PcCase/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var psuDetails = await _service.GetByIdAsync(id);
            if (psuDetails == null)
            {
                return View("NotFound");
            }
            return View(psuDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,
            [Bind(@"Id,
                                Capacity,
                                Modular,
                                Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                Classification")] PSU psu)
        {
            if (!ModelState.IsValid)
            {
                return View(psu);
            }
            await _service.UpdateAsync(id, psu);
            return RedirectToAction(nameof(Index));
        }

        // Get -> PcCase/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var psuDetails = await _service.GetByIdAsync(id);
            if (psuDetails == null)
            {
                return View("NotFound");
            }
            return View(psuDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var psuDetails = await _service.GetByIdAsync(id);
            if (psuDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}