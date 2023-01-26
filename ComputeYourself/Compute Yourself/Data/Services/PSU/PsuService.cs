using ComputeYourself.Data.Services.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services.PSU
{
    public class PsuService : BaseService<Psu>, IPsuService
    {
        private readonly AppDbContext _context;

        public PsuService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}