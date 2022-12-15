using ComputeYourself.Data.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services
{
    public class RAMService : BaseService<RAM>,IRAMService
    {
        private readonly AppDbContext _context;

        public RAMService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
