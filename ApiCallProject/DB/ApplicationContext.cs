using ApiCallProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCallProject.DB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ApiCallInfo> ApiCallHistories { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
