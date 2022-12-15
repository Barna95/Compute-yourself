using ComputeYourself.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputeYourself.Controllers
{
    public class PcCase : Controller
    {
        private readonly AppDbContext _context;

        public PcCase(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allPcCases = await _context.PcCases.ToListAsync();
            return View(allPcCases);
        }
    }
}
