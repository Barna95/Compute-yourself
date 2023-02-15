using API.Models.Identity;

namespace API.Data.Services;

public interface ITokenService
{
    Task<string> GenerateToken(User user);
}