using Poll_MVC.Domain.Commands;
using Poll_MVC.Domain.Handlers.Contracts;
using Poll_MVC.Domain.Models;
using Poll_MVC.Domain.Repositories;
using Poll_MVC.Domain.Responses;

namespace Poll_MVC.Domain.Handlers
{
    public class PollHandler :
        IHandler<CreatePollCommand, CreatedPollResponse>
    {
        private readonly IPollRepository _repository;
        public PollHandler(IPollRepository repository) { _repository = repository; }

        public CreatedPollResponse Handle(CreatePollCommand command)
        {
            var poll = new Poll(command.Poll_description);

            poll.AddOption(command.Option1);
            poll.AddOption(command.Option2);
            poll.AddOption(command.Option3);

            int idPoll = _repository.Create(poll);

            return new CreatedPollResponse(idPoll);
        }

        public Poll GetPoll(int idPoll)
        {
            var poll = _repository.GetById(idPoll);

            if (poll is null)
                return null;

            poll.AddView();
            _repository.Update(poll);

            return poll;
        }
    }
}
