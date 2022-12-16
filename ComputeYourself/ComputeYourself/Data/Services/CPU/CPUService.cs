using ComputeYourself.Data.Base;

namespace ComputeYourself.Data.Services.CPU
{
    public class CPUService : BaseService<Models.CPU.CPU>, ICPUService
    {
        private readonly AppDbContext _context;

        public CPUService(AppDbContext context) : base(context)
        {
        }
    }
}