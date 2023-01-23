using ComputeYourself.Data.Base;

namespace ComputeYourself.Data.Services.PcCase
{
    public class PcCaseService : BaseService<Models.PcCase.PcCase>, IPcCaseService
    {
        private readonly AppDbContext _context;
        public PcCaseService(AppDbContext context) : base(context)
        {

        }
    }
}