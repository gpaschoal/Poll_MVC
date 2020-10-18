using Poll_MVC.Domain.Models;
using Poll_MVC.Domain.Responses.Contracts;
using Poll_MVC.Domain.Responses.Items;
using System.Collections.Generic;
using System.Linq;

namespace Poll_MVC.Domain.Responses
{
    public class GetByIdPollResponse : IResponse
    {
        public GetByIdPollResponse(Poll poll)
        {
            Poll_id = poll.Id;
            Poll_description = poll.Description;
            Options = poll.Options.Select(x => new OptionResponse(x.Id, x.Description));
        }

        public int Poll_id { get; private set; }
        public string Poll_description { get; private set; }
        public IEnumerable<OptionResponse> Options { get; private set; }
    }
}
