using ComputeYourself.Data.Services.Base;

namespace ComputeYourself.Data.Services.PcCase
{
    public class PcCaseService : BaseService<Models.PcCase>, IPcCaseService
    {
        private readonly AppDbContext _context;
        public PcCaseService(AppDbContext context) : base(context)
        {

        }
    }
}