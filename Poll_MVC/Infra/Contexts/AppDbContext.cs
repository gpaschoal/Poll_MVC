using Microsoft.EntityFrameworkCore;

namespace Poll_MVC.Infra.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
