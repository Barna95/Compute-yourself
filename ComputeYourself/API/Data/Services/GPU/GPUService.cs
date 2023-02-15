using API.Data.Services.Base;
using API.Models;

namespace API.Data.Services.GPU;

public class GPUService : BaseService<Gpu>, IGPUService
{
    private readonly AppDbContext _context;

    public GPUService(AppDbContext context) : base(context)
    {
    }
}