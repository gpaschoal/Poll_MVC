using Poll_MVC.Domain.Models;
using Poll_MVC.Domain.Repositories.Contracts;

namespace Poll_MVC.Domain.Repositories
{
    public interface IOptionRepository : IRepository
    {
        Option GetById(int idPoll, int idOption);
        void Update(Option option);
    }
}
