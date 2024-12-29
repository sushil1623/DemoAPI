using Microsoft.EntityFrameworkCore;

namespace RefreshTokenDemo
{
    public class RefreshTokenContext(DbContextOptions<RefreshTokenContext> option) : DbContext(option)
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<RefreshTokenModel> RefreshTokens { get; set; }
        public DbSet<ProductModel> Products { get; set; }   
    }
}
