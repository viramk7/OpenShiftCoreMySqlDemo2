using Microsoft.EntityFrameworkCore;
using OpenShiftCoreMySqlDemo2.Models;

namespace OpenShiftCoreMySqlDemo2.Database
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
