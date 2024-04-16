using API_Login.Models;
using BE_Healthcare.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BE_Healthcare.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region Dbset
        public DbSet<User> Users{ get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
