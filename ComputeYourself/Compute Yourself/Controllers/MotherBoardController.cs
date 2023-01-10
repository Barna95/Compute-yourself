using ComputeYourself.Data.Services.MotherBoard;
using ComputeYourself.Models.MotherBoard;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Controllers
{
    public class MotherBoardController : Controller
    {
        private readonly IMotherBoardService _service;

        public MotherBoardController(IMotherBoardService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMotherBoards = await _service.GetAllAsync();
            return View(allMotherBoards);
        }

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
                                Chipset,
                                Size,
                                Igpu,
                                RAM,
                                Frequency,
                                MemorySockets,
                                XMP,
                                MaxMemory,
                                CForSLISupport,
                                Bluetooth,
                                Lighting,
                                Windows11Support,
                                Wifi,
                                LANPort,
                                LanportsNumber,
                                PCIe16x,
                                SATA3,
                                M2,
                                USB2,
                                USB3,
                                USB31,
                                USBC")] MotherBoard motherBoard)
        {
            if (!ModelState.IsValid)
            {
                return View(motherBoard);
            }
            await _service.AddAsync(motherBoard);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var motherBoardDetails = await _service.GetByIdAsync(id);
            if (motherBoardDetails == null)
            {
                return View("NotFound");
            }
            return View(motherBoardDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var motherBoardDetails = await _service.GetByIdAsync(id);
            if (motherBoardDetails == null)
            {
                return View("NotFound");
            }
            return View(motherBoardDetails);
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
                                Chipset,
                                Size,
                                Igpu,
                                RAM,
                                Frequency,
                                MemorySockets,
                                XMP,
                                MaxMemory,
                                CForSLISupport,
                                Bluetooth,
                                Lighting,
                                Windows11Support,
                                Wifi,
                                LANPort,
                                LanportsNumber,
                                PCIe16x,
                                SATA3,
                                M2,
                                USB2,
                                USB3,
                                USB31,
                                USBC")] MotherBoard motherBoard)
        {
            if (!ModelState.IsValid)
            {
                return View(motherBoard);
            }
            await _service.UpdateAsync(id, motherBoard);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var motherBoardDetails = await _service.GetByIdAsync(id);
            if (motherBoardDetails == null)
            {
                return View("NotFound");
            }
            return View(motherBoardDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motherBoardDetails = await _service.GetByIdAsync(id);
            if (motherBoardDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}