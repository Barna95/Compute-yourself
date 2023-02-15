using API.Data.Services.Base;

namespace API.Data.Services.MotherBoard;

public class MotherBoardService : BaseService<Models.MotherBoard>, IMotherBoardService
{
    private readonly AppDbContext _context;

    public MotherBoardService(AppDbContext context) : base(context)
    {
        _context = context;
    }
}