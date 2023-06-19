
using Microsoft.EntityFrameworkCore;
using test_1.Models;

namespace test_1.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            : base(options)
        {
        }
        public DbSet<Issue> Issues{ get; set; }
    }
}
