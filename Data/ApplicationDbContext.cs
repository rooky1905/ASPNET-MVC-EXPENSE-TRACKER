using ASPNET_MVC_2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_MVC_2._0.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}