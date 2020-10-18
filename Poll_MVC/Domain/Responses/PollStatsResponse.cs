using Poll_MVC.Domain.Responses.Items;
using System.Collections.Generic;

namespace Poll_MVC.Domain.Responses
{
    public class PollStatsResponse
    {
        public PollStatsResponse(int views, IEnumerable<VotesResponse> votes)
        {
            Views = views;
            Votes = votes;
        }

        public int Views { get; private set; }
        public IEnumerable<VotesResponse> Votes { get; private set; }
    }
}
