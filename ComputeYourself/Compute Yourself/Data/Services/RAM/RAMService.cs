using ComputeYourself.Data.Services.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services.RAM
{
    public class RAMService : BaseService<Ram>, IRAMService
    {
        private readonly AppDbContext _context;

        public RAMService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}