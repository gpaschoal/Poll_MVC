using Poll_MVC.Domain.Responses.Contracts;

namespace Poll_MVC.Domain.Responses
{
    public class CreatedPollResponse : IResponse
    {
        public CreatedPollResponse(int poll_id)
        {
            Poll_id = poll_id;
        }

        public int Poll_id { get; private set; }
    }
}
