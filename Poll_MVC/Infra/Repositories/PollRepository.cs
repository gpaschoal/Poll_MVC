using Microsoft.EntityFrameworkCore;
using Poll_MVC.Domain.Models;
using Poll_MVC.Domain.Repositories;
using Poll_MVC.Infra.Contexts;
using System.Linq;

namespace Poll_MVC.Infra.Repositories
{
    public class PollRepository : IPollRepository
    {
        private readonly AppDbContext _context;

        public PollRepository(AppDbContext context) { _context = context; }

        public int Create(Poll poll)
        {
            _context.Polls.Add(poll);
            _context.SaveChanges();
            return poll.Id;
        }

        public Poll GetById(int id)
        {
            return _context
                    .Polls
                    .Include(x => x.Options)
                    .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Poll poll)
        {
            _context.Entry(poll).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
