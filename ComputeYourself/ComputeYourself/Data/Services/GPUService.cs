using ComputeYourself.Data.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services
{
    public class GPUService : BaseService<GPU>, IGPUService
    {
        private readonly AppDbContext _context;

        public GPUService(AppDbContext context) : base(context)
        {
        }
    }
}
