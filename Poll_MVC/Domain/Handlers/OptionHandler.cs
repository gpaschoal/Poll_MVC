using Poll_MVC.Domain.Commands;
using Poll_MVC.Domain.Handlers.Contracts;
using Poll_MVC.Domain.Repositories;
using Poll_MVC.Domain.Responses;

namespace Poll_MVC.Domain.Handlers
{
    public class OptionHandler :
        IHandler<VotePollCommand, EmptyResponse>
    {
        private readonly IOptionRepository _repository;
        public OptionHandler(IOptionRepository repository) { _repository = repository; }

        public EmptyResponse Handle(VotePollCommand command)
        {
            var option = _repository.GetById(command.PollId, command.Option_id);

            if (option == null)
                return null;

            option.AddVote();
            _repository.Update(option);

            return new EmptyResponse();
        }
    }
}
