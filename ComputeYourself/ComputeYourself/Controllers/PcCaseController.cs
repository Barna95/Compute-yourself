using ComputeYourself.Data;
using ComputeYourself.Data.Services.PcCase;
using ComputeYourself.Models.PcCase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputeYourself.Controllers
{
    public class PcCaseController : Controller
    {
        private readonly IPcCaseService _service;

        public PcCaseController(IPcCaseService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allPcCases = await _service.GetAllAsync();
            return View(allPcCases);
        }

        // Get -> PcCases/Create
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
                                SizeCompatibility,
                                MaxCpuCoolerHeight,
                                MaxGpuLength")] 
            PcCase pcCase)
        {
            if (!ModelState.IsValid)
            {
                return View(pcCase);
            }
            await _service.AddAsync(pcCase);
            return RedirectToAction(nameof(Index));
        }

        // Get -> PcCase/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var pcCaseDetails = await _service.GetByIdAsync(id);
            if (pcCaseDetails == null)
            {
                return View("NotFound");
            }
            return View(pcCaseDetails);
        }

        // Get -> PcCase/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var pcCaseDetails = await _service.GetByIdAsync(id);
            if (pcCaseDetails == null)
            {
                return View("NotFound");
            }
            return View(pcCaseDetails);
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
                                SizeCompatibility,
                                MaxCpuCoolerHeight,
                                MaxGpuLength")]PcCase pcCase)
        {
            if (!ModelState.IsValid)
            {
                return View(pcCase);
            }
            await _service.UpdateAsync(id, pcCase);
            return RedirectToAction(nameof(Index));
        }

        // Get -> PcCase/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var pcCaseDetails = await _service.GetByIdAsync(id);
            if (pcCaseDetails == null)
            {
                return View("NotFound");
            }
            return View(pcCaseDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pcCaseDetails = await _service.GetByIdAsync(id);
            if (pcCaseDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}