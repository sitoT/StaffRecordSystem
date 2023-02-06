using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.EFDataConnection
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<StaffParam> StaffParams { get; set; }
    }
}
