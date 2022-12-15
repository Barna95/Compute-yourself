using ComputeYourself.Data.Services;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class CpuCoolerController : Controller
    {
        private readonly ICpuCoolerService _service;

        public CpuCoolerController(ICpuCoolerService service)
        {
            _service = service;
        }

        //GET index page
        public async Task<IActionResult> Index()
        {
            var allCpuCoolers = await _service.GetAllAsync();
            return View(allCpuCoolers);
        }

        //GET create page
        public IActionResult Create()
        {
            return View();
        }

        //POST create cpucooler
        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind(@"Id,
                                Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                CoolerType,
                                Height,
                                CpuType")]
            CpuCooler cpuCooler)
        {
            if (!ModelState.IsValid)
            {
                return View(cpuCooler);
            }

            await _service.AddAsync(cpuCooler);
            return RedirectToAction(nameof(Index));
        }

        //GET Details for details page
        public async Task<IActionResult> Details(int id)
        {
            var cpuCoolerDetails = await _service.GetByIdAsync(id);
            if (cpuCoolerDetails == null)
            {
                return View("NotFound");
            }
            return View(cpuCoolerDetails);
        }

        //GET details for edit page
        public async Task<IActionResult> Edit(int id)
        {
            var cpuCoolerDetails = await _service.GetByIdAsync(id);
            if (cpuCoolerDetails == null)
            {
                return View("NotFound");
            }
            return View(cpuCoolerDetails);
        }

        // POST Edit the cpucooler by ID
        [HttpPost]
        public async Task<IActionResult> Edit(int id,
            [Bind(@"Id,
                                Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                CoolerType,
                                Height,
                                CpuType")] CpuCooler cpuCooler)
        {
            if (!ModelState.IsValid)
            {
                return View(cpuCooler);
            }

            await _service.UpdateAsync(id, cpuCooler);
            return RedirectToAction(nameof(Index));
        }

        //GET details for the delete page
        public async Task<IActionResult> Delete(int id)
        {
            var cpuCoolerDetails = await _service.GetByIdAsync(id);
            if (cpuCoolerDetails == null)
            {
                return View("NotFound");
            }
            return View(cpuCoolerDetails);
        }

        //POST delete by ID
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cpuCoolerDetails = await _service.GetByIdAsync(id);
            if (cpuCoolerDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
