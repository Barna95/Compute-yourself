using ComputeYourself.Data.Services;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class DriveController : Controller
    {
        private readonly IDriveService _service;

        public DriveController(IDriveService service)
        {
            _service = service;
        }

        //GET index page
        public async Task<IActionResult> Index()
        {
            var allDrivers = await _service.GetAllAsync();
            return View(allDrivers);
        }

        //GET create page
        public IActionResult Create()
        {
            return View();
        }

        //POST create drive
        [HttpPost]
        public async Task<IActionResult> Create(
            [Bind(@"Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                ConnectionType,
                                Capacity,
                                MaxWrite,
                                MaxRead")]
            Drive drive)
        {
            if (!ModelState.IsValid)
            {
                return View(drive);
            }

            await _service.AddAsync(drive);
            return RedirectToAction(nameof(Index));
        }

        //GET Details for details page
        public async Task<IActionResult> Details(int id)
        {
            var driveDetails = await _service.GetByIdAsync(id);
            if (driveDetails == null)
            {
                return View("NotFound");
            }
            return View(driveDetails);
        }

        //GET details for edit page
        public async Task<IActionResult> Edit(int id)
        {
            var driveDetails = await _service.GetByIdAsync(id);
            if (driveDetails == null)
            {
                return View("NotFound");
            }
            return View(driveDetails);
        }

        // POST Edit the drive by ID
        [HttpPost]
        public async Task<IActionResult> Edit(int id,
            [Bind(@"
                                Id,
                                Name,
                                Description,
                                Price,
                                Brand,
                                Warranty,
                                Rating,
                                ConnectionType,
                                Capacity,
                                MaxWrite,
                                MaxRead")] Drive drive)
        {
            if (!ModelState.IsValid)
            {
                return View(drive);
            }

            await _service.UpdateAsync(id, drive);
            return RedirectToAction(nameof(Index));
        }

        //GET details for the delete page
        public async Task<IActionResult> Delete(int id)
        {
            var driveDetails = await _service.GetByIdAsync(id);
            if (driveDetails == null)
            {
                return View("NotFound");
            }
            return View(driveDetails);
        }

        //POST delete by ID
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var driveDetails = await _service.GetByIdAsync(id);
            if (driveDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
