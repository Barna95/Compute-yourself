using ComputeYourself.Data.Services.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services.GPU
{
    public class GPUService : BaseService<Gpu>, IGPUService
    {
        private readonly AppDbContext _context;

        public GPUService(AppDbContext context) : base(context)
        {
        }
    }
}