using ComputeYourself.Data.Services.Base;

namespace ComputeYourself.Data.Services.CpuCooler
{
    public class CpuCoolerService : BaseService<Models.CpuCooler>, ICpuCoolerService
    {
        private readonly AppDbContext _context;
        public CpuCoolerService(AppDbContext context) : base(context)
        {
        }
    }
}