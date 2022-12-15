using ComputeYourself.Data.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services
{
    public class CPUService : BaseService<CPU>, ICPUService
    {
        private readonly AppDbContext _context;

        public CPUService(AppDbContext context) : base(context)
        {
        }
    }
}
