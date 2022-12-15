using ComputeYourself.Data.Base;
using ComputeYourself.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputeYourself.Data.Services
{
    public class PsuService : BaseService<PSU>, IPsuService
    {
        private readonly AppDbContext _context;

        public PsuService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
