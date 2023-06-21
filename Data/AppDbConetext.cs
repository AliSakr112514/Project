using e_net.Models;
using Microsoft.EntityFrameworkCore;

namespace e_net.Data
{
    public class AppDbConetext : DbContext
    {
        public AppDbConetext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> items { get; set; }
    }
}
