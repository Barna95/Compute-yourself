using ComputeYourself.Data.Base;
using ComputeYourself.Models;

namespace ComputeYourself.Data.Services
{
    public class MotherBoardService : BaseService<MotherBoard>, IMotherBoardService
    {
        private readonly AppDbContext _context;

        public MotherBoardService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
