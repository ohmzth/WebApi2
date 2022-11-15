using WebApi2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi2.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext>options) : base (options)
        {
            
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
