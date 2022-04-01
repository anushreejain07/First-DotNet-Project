using System.Threading.Tasks;
using AspNetCoreWebAPI.Models;

namespace AspNetCoreWebAPI.Data
{
    public interface IAuthRespository
    {
        Task<ServiceResponse<int>> Register(User user,string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string Username);
    }
}