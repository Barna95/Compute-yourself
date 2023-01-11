using ComputeYourself.Data.Base;

namespace ComputeYourself.Data.Services.PSU
{
    public class PsuService : BaseService<Models.PSU.Psu>, IPsuService
    {
        private readonly AppDbContext _context;

        public PsuService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}