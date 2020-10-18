using Poll_MVC.Domain.Commands.Contracts;
using Poll_MVC.Domain.Responses.Contracts;

namespace Poll_MVC.Domain.Handlers.Contracts
{
    public interface IHandler<T, R>
            where T : ICommand
            where R : IResponse
    {
        R Handle(T command);
    }
}
