using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
    }
}