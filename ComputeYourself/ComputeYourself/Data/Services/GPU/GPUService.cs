using ComputeYourself.Data.Base;

namespace ComputeYourself.Data.Services.GPU
{
    public class GPUService : BaseService<Models.GPU.GPU>, IGPUService
    {
        private readonly AppDbContext _context;

        public GPUService(AppDbContext context) : base(context)
        {
        }
    }
}