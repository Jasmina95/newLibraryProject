using MyWebAPICore.Models;

namespace MyWebAPICore.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Login(string username, string password);
        string Logout();
    }
}
