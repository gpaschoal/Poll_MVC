using Poll_MVC.Domain.Models;
using Poll_MVC.Domain.Repositories.Contracts;

namespace Poll_MVC.Domain.Repositories
{
    public interface IPollRepository : IRepository
    {
        int Create(Poll poll);
        void Update(Poll poll);
        Poll GetById(int id);
    }
}
