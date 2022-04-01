using AspNetCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCOREWEBAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

            
        }

        public DbSet<Character> Character { get; set; }         
        public DbSet<User> Users { get; set; }
    }
}