using ComputeYourself.Data.Base;

namespace ComputeYourself.Data.Services.MotherBoard
{
    public class MotherBoardService : BaseService<Models.MotherBoard.MotherBoard>, IMotherBoardService
    {
        private readonly AppDbContext _context;

        public MotherBoardService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}