using ComputeYourself.Data.Base;

namespace ComputeYourself.Data.Services.RAM
{
    public class RAMService : BaseService<Models.RAM.Ram>, IRAMService
    {
        private readonly AppDbContext _context;

        public RAMService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}