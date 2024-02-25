using System.Security.Claims;

namespace Test.Application.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ClaimsPrincipal?> GetUser();
    }
}