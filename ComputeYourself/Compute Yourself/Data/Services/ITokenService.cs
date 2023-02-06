using ComputeYourself.Models.Identity;

namespace ComputeYourself.Data.Services
{
    public interface ITokenService
    { 
        Task<string> GenerateToken(User user);
    }
}
