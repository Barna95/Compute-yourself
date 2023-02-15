using API.Data.Services.Base;
using API.Models;

namespace API.Data.Services.CPU;

public class CPUService : BaseService<Cpu>, ICPUService
{
    private readonly AppDbContext _context;

    public CPUService(AppDbContext context) : base(context)
    {
    }
}