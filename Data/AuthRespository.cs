using System.Threading.Tasks;
using AspNetCoreWebAPI.Models;
using ASPNETCOREWEBAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebAPI.Data
{
    public class AuthRespository : IAuthRespository
    {
        private readonly DataContext _context;

        public AuthRespository(DataContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            ServiceResponse<int> response=new ServiceResponse<int>();
            if(await UserExists(user.Username))
            {
                response.Success=false;
                response.Message="User Already exists";
                return response;
            }
            CreatePasswordHash(password,out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash=passwordHash;
            user.PasswordSalt=passwordSalt;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            response.Data=user.Id;
            return response;
        }

        public async Task<bool> UserExists(string username)
        {
            if(await _context.Users.AnyAsync(x=> x.Username.ToLower().Equals(username.ToLower())))
            {
                return true;
            }
            return false;
        }
        private void CreatePasswordHash(string password,out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt=hmac.Key;
                passwordHash=hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}