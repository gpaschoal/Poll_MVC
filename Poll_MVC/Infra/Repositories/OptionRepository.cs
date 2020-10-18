using Microsoft.EntityFrameworkCore;
using Poll_MVC.Domain.Models;
using Poll_MVC.Domain.Repositories;
using Poll_MVC.Infra.Contexts;
using System.Linq;

namespace Poll_MVC.Infra.Repositories
{
    public class OptionRepository : IOptionRepository
    {
        private readonly AppDbContext _context;

        public OptionRepository(AppDbContext context) { _context = context; }

        public Option GetById(int idPoll, int idOption)
        {
            return _context
                    .Options
                    .AsNoTracking()
                    .FirstOrDefault(x => x.PollId == idPoll && x.Id == idOption);
        }

        public void Update(Option option)
        {
            _context.Entry(option).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
