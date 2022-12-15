using ComputeYourself.Data.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services
{
    public class CpuCoolerService : BaseService<CpuCooler>, ICpuCoolerService
    {
        private readonly AppDbContext _context;
        public CpuCoolerService(AppDbContext context) : base(context)
        {
        }
    }
}