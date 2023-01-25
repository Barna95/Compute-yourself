using ComputeYourself.Data.Services.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services.CPU
{
    public class CPUService : BaseService<Cpu>, ICPUService
    {
        private readonly AppDbContext _context;

        public CPUService(AppDbContext context) : base(context)
        {
        }
    }
}