using Microsoft.EntityFrameworkCore;
using Poll_MVC.Domain.Models;

namespace Poll_MVC.Infra.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Identity keys
            modelBuilder.Entity<Poll>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Option>().Property(p => p.Id).ValueGeneratedOnAdd();
            #endregion

            #region Keys
            modelBuilder.Entity<PollView>().HasKey(x => new { x.PollId, x.CreatedAt });
            modelBuilder.Entity<Option>().HasKey(x => new { x.PollId, x.Id });
            modelBuilder.Entity<OptionVote>().HasKey(x => new { x.PollId, x.OptionId, x.CreatedAt });
            #endregion
        }

        public DbSet<Poll> Polls { get; set; }
        public DbSet<Option> Options { get; set; }
    }
}
