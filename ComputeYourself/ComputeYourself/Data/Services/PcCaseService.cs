using ComputeYourself.Data.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services
{
    public class PcCaseService : BaseService<PcCase>, IPcCaseService
    {
        private readonly AppDbContext _context;
        public PcCaseService(AppDbContext context) : base(context)
        {

        }
    }
}
